using System.Data;
using System.Text;
using NapoleonCode.Common;
using NapoleonCode.BLL;
using NapoleonCode.Model;

namespace NapoleonCode.Win.MovingTemplate
{
    public class BaseTemplate
    {

        private static readonly MsSqlService Bll = new MsSqlService();
        private static readonly SqLiteService SqLiteService = new SqLiteService();

        #region SQLServer

        /// <summary>
        ///  公用DataTable
        /// </summary>
        /// <param name="appConfig">数据库配置类</param>
        /// <returns>DataTable.</returns>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-09-25 10:31:18
        private static DataTable GetTable(AppConfig appConfig)
        {
            string sql =
                string.Format(
                    "SELECT obj.name AS TableName ,col.colorder AS Id ,col.name AS TableColumn ,ISNULL(ep.[value], col.name) AS TableDesc ,t.name AS DataType ,col.length AS TypeLength ,ISNULL(COLUMNPROPERTY(col.id, col.name, 'Scale'), 0) AS DecimalLength ,CASE WHEN COLUMNPROPERTY(col.id, col.name, 'IsIdentity') = 1 THEN 'true' ELSE 'false' END AS IsFlag ,CASE WHEN EXISTS (SELECT 1 FROM dbo.sysindexes si INNER JOIN dbo.sysindexkeys sik ON si.id = sik.id INNER JOIN dbo.syscolumns sc ON sc.id = sik.id AND sc.colid = sik.colid INNER JOIN dbo.sysobjects so ON so.name = si.name AND so.xtype = 'PK' WHERE sc.id = col.id AND sc.colid = col.colid ) THEN 'true' ELSE 'false' END AS IsKey , CASE WHEN col.isnullable = 1 THEN 'true' ELSE 'false' END AS IsNull , ISNULL(comm.text, '') AS DefaultValue FROM dbo.syscolumns col LEFT OUTER JOIN dbo.systypes t ON col.xtype = t.xusertype INNER JOIN dbo.sysobjects obj ON col.id = obj.id AND obj.xtype = 'U' AND obj.status >= 0 LEFT OUTER JOIN dbo.syscomments comm ON col.cdefault = comm.id LEFT OUTER JOIN sys.extended_properties ep ON col.id = ep.major_id AND col.colid = ep.minor_id AND ep.name = 'MS_Description' LEFT OUTER JOIN sys.extended_properties epTwo ON obj.id = epTwo.major_id AND epTwo.minor_id = 0 AND epTwo.name ='MS_Description' WHERE obj.name = '{0}' ORDER BY  col.colorder",
                    PublicFiled.TableName);
            DataTable dataBaseTables = Bll.ExecuteSql(sql, appConfig, PublicFiled.DataBaseName);
            return dataBaseTables;
        }

        /// <summary>
        ///  基础模版的字段
        /// </summary>
        /// <param name="appConfig">数据库配置类</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-09-25 15:21:23
        public static string InsertBaseField(AppConfig appConfig)
        {
            StringBuilder sb = new StringBuilder();
            DataTable dataBaseTables = GetTable(appConfig);
            if (dataBaseTables.Rows.Count > 0)
            {
                sb.AppendFormat("#region{0}", PublicFiled.WarpSymbol);
                sb.AppendFormat("{0}", PublicFiled.WarpSymbol);
                foreach (DataRow row in dataBaseTables.Rows)
                {
                    sb.AppendFormat("{0}", PublicFun.GetCommentary(row["TableDesc"].ToString())); //注释
                    sb.AppendFormat("public const string Filed_{0} =\"{0}\" {1}", row["TableColumn"],
                        PublicFiled.WarpSymbol);
                    sb.AppendFormat("{0}", PublicFiled.WarpSymbol);
                }
                sb.AppendFormat("#endregion{0}", PublicFiled.WarpSymbol);
            }
            return sb.ToString();
        }

        /// <summary>
        ///  基础模版的实体类
        /// </summary>
        /// <param name="appConfig">数据库配置类</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-09-25 10:01:16
        public static string InsertBaseModel(AppConfig appConfig)
        {
            StringBuilder sb = new StringBuilder();
            DataTable dataBaseTables = GetTable(appConfig);
            if (dataBaseTables.Rows.Count > 0)
            {
                foreach (DataRow row in dataBaseTables.Rows)
                {
                    //私有属性,_+首字母小写
                    string privateStr = string.Format("_{0}{1}", row["TableColumn"].ToString().ToLower().Substring(0, 1),
                        row["TableColumn"].ToString().Substring(1));
                    sb.AppendFormat("private {0} {1}{2}", PublicFun.FormatType(0, row["DataType"].ToString()),
                        privateStr, PublicFiled.WarpSymbol);
                    sb.AppendFormat("{0}", PublicFun.GetCommentary(row["TableDesc"].ToString())); //注释
                    sb.AppendFormat("public {0} {1}{2}", PublicFun.FormatType(0, row["DataType"].ToString()),
                        row["TableColumn"], PublicFiled.WarpSymbol);
                    sb.Append("{");
                    sb.AppendFormat("{0}", PublicFiled.WarpSymbol);
                    sb.AppendFormat("{0}get {1} return {2};{3}{4}", PublicFiled.TabSymbol, "{", privateStr, "}",
                        PublicFiled.WarpSymbol);
                    sb.AppendFormat("{0}set {1} {2} = value;{3}{4}", PublicFiled.TabSymbol, "{", privateStr, "}",
                        PublicFiled.WarpSymbol);
                    sb.Append("}");
                    sb.AppendFormat("{0}{0}", PublicFiled.WarpSymbol);
                }
            }
            return sb.ToString();
        }

        /// <summary>
        ///  基础模版的存储过程
        /// </summary>
        /// <param name="appConfig">数据库配置类</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-09-25 10:01:16
        public static string InsertBaseProcedure(AppConfig appConfig)
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder sb1 = new StringBuilder(); //字段
            StringBuilder sb2 = new StringBuilder(); //@字段
            StringBuilder sb3 = new StringBuilder(); //字段=@字段
            StringBuilder sb4 = new StringBuilder(); //主键
            DataTable dataBaseTables = GetTable(appConfig);
            if (dataBaseTables.Rows.Count > 0)
            {
                sb.AppendFormat("{0}", PublicFun.GetTopCommentary());
                sb.AppendFormat("CREATE PROCEDURE SP_{0}_Action{1}", PublicFiled.TableName, PublicFiled.WarpSymbol);
                sb.Append("{");
                sb.AppendFormat("{0}", PublicFiled.WarpSymbol);
                sb.AppendFormat(
                    "{0}@SYS_ACTION nvarchar(8),  --\"ADD\"表示增加,\"UPD\"表示修改,\"DEL\"表示删除,\"INF\"表示获取基本信息,\"LST\"表示获取全部列表数据{1}{0}@OutId int = NULL out, --插入数据成功以后，返回插入数据对应的自增字段ID值{1}{0}@RunRowCount int = NULL out, --返回除SELECT操作外的脚本执行以后表受影响的行数{1}",
                    PublicFiled.TabSymbol, PublicFiled.WarpSymbol);
                int i = 0; //计数
                foreach (DataRow row in dataBaseTables.Rows)
                {
                    i++;
                    if (row["IsKey"].ToString().Equals("true"))
                    {
                        sb4.AppendFormat("{0}=@{0}", row["TableColumn"]);
                    }
                    else
                    {
                        sb1.AppendFormat("{0},", row["TableColumn"]);
                        sb2.AppendFormat("@{0},", row["TableColumn"]);
                        sb3.AppendFormat("{0}=@{0},", row["TableColumn"]);
                    }
                    sb.AppendFormat("{0}@{1} {2}=NULL{3}{4}--{5}", PublicFiled.TabSymbol, row["TableColumn"],
                        PublicFun.FormatType(row["DataType"].ToString(), row["TypeLength"].ToString(),
                            row["DecimalLength"].ToString()), i == dataBaseTables.Rows.Count ? "" : ",",
                        PublicFiled.TabSymbol, row["TableDesc"]);
                    sb.AppendFormat("{0}", PublicFiled.WarpSymbol);
                }
                sb.Append("}");
                sb.AppendFormat("{0}AS{0}", PublicFiled.WarpSymbol);
                //新增
                sb.AppendFormat("IF @SYS_ACTION = 'ADD'{0}", PublicFiled.WarpSymbol);
                sb.AppendFormat("{0}BEGIN{1}", PublicFiled.TabSymbol, PublicFiled.WarpSymbol);
                sb.AppendFormat("{0}{0}INSERT INTO {1}({2}) VALUES({3}){4}", PublicFiled.TabSymbol,
                    PublicFiled.TableName, sb1.ToString().Trim(','), sb2.ToString().Trim(','), PublicFiled.WarpSymbol);
                sb.AppendFormat("{0}{0}SET @outId = scope_identity(){1}", PublicFiled.TabSymbol, PublicFiled.WarpSymbol);
                sb.AppendFormat("{0}END{1}", PublicFiled.TabSymbol, PublicFiled.WarpSymbol);
                //更新
                sb.AppendFormat("IF @SYS_ACTION = 'UPD'{0}", PublicFiled.WarpSymbol);
                sb.AppendFormat("{0}BEGIN{1}", PublicFiled.TabSymbol, PublicFiled.WarpSymbol);
                sb.AppendFormat("{0}{0}UPDATE {1} SET {2} WHERE {3}{4}", PublicFiled.TabSymbol, PublicFiled.TableName,
                    sb3.ToString().Trim(','), sb4, PublicFiled.WarpSymbol);
                sb.AppendFormat("{0}{0}SET @RunRowCount = @@ROWCOUNT{1}", PublicFiled.TabSymbol, PublicFiled.WarpSymbol);
                sb.AppendFormat("{0}END{1}", PublicFiled.TabSymbol, PublicFiled.WarpSymbol);
                //删除
                sb.AppendFormat("IF @SYS_ACTION = 'DEL'{0}", PublicFiled.WarpSymbol);
                sb.AppendFormat("{0}BEGIN{1}", PublicFiled.TabSymbol, PublicFiled.WarpSymbol);
                sb.AppendFormat("{0}{0}DELETE {1} WHERE {2}{3}", PublicFiled.TabSymbol, PublicFiled.TableName, sb4,
                    PublicFiled.WarpSymbol);
                sb.AppendFormat("{0}{0}SET @RunRowCount = @@ROWCOUNT{1}", PublicFiled.TabSymbol, PublicFiled.WarpSymbol);
                sb.AppendFormat("{0}END{1}", PublicFiled.TabSymbol, PublicFiled.WarpSymbol);
                //单条查询
                sb.AppendFormat("IF @SYS_ACTION = 'INF'{0}", PublicFiled.WarpSymbol);
                sb.AppendFormat("{0}BEGIN{1}", PublicFiled.TabSymbol, PublicFiled.WarpSymbol);
                sb.AppendFormat("{0}{0}SELECT {1} FORM {2} WHERE {3}{4}", PublicFiled.TabSymbol,
                    sb1.ToString().Trim(','), PublicFiled.TableName, sb4, PublicFiled.WarpSymbol);
                sb.AppendFormat("{0}{0}SET @RunRowCount = @@ROWCOUNT{1}", PublicFiled.TabSymbol, PublicFiled.WarpSymbol);
                sb.AppendFormat("{0}END{1}", PublicFiled.TabSymbol, PublicFiled.WarpSymbol);
                //列表查询
                sb.AppendFormat("IF @SYS_ACTION = 'LST'{0}", PublicFiled.WarpSymbol);
                sb.AppendFormat("{0}BEGIN{1}", PublicFiled.TabSymbol, PublicFiled.WarpSymbol);
                sb.AppendFormat("{0}{0}SELECT {1} FORM {2} {3}", PublicFiled.TabSymbol, sb1.ToString().Trim(','),
                    PublicFiled.TableName, PublicFiled.WarpSymbol);
                sb.AppendFormat("{0}{0}SET @RunRowCount = @@ROWCOUNT{1}", PublicFiled.TabSymbol, PublicFiled.WarpSymbol);
                sb.AppendFormat("{0}END{1}", PublicFiled.TabSymbol, PublicFiled.WarpSymbol);
                sb.AppendFormat("{0}", PublicFiled.WarpSymbol);
            }
            return sb.ToString();
        }

        #endregion

        #region SQLite

        /// <summary>
        ///  公用DataTable
        /// </summary>
        /// <param name="appConfig">数据库配置类</param>
        /// <param name="tableName">数据库配置类</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-09-25 10:31:18
        private static DataTable GetSqLiteTable(AppConfig appConfig,string tableName)
        {
            DataTable dataBaseTables = SqLiteService.GetTreeViews(appConfig, tableName);
            return dataBaseTables;
        }

        #endregion




    }
}
