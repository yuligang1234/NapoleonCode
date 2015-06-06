
using System.Data;
using System.Text;
using NapoleonCode.BLL;
using NapoleonCode.Common;
using NapoleonCode.Model;

namespace NapoleonCode.Win.MovingTemplate
{
    public class PublicTemplate
    {

        private static readonly MsSqlService Bll = new MsSqlService();

        /// <summary>
        ///  公用DataTable
        /// </summary>
        /// <param name="appConfig">数据库配置类</param>
        /// Author  : Napoleon
        /// Created : 2014-12-15 20:27:01
        public static DataTable GetTable(AppConfig appConfig)
        {
            string sql =
                string.Format(
                    "SELECT obj.name AS TableName ,col.colorder AS Id ,col.name AS TableColumn ,ISNULL(ep.[value], col.name) AS TableDesc ,t.name AS DataType ,col.length AS TypeLength ,ISNULL(COLUMNPROPERTY(col.id, col.name, 'Scale'), 0) AS DecimalLength ,CASE WHEN COLUMNPROPERTY(col.id, col.name, 'IsIdentity') = 1 THEN 'true' ELSE 'false' END AS IsFlag ,CASE WHEN EXISTS (SELECT 1 FROM dbo.sysindexes si INNER JOIN dbo.sysindexkeys sik ON si.id = sik.id INNER JOIN dbo.syscolumns sc ON sc.id = sik.id AND sc.colid = sik.colid INNER JOIN dbo.sysobjects so ON so.name = si.name AND so.xtype = 'PK' WHERE sc.id = col.id AND sc.colid = col.colid ) THEN 'true' ELSE 'false' END AS IsKey , CASE WHEN col.isnullable = 1 THEN 'true' ELSE 'false' END AS IsNull , ISNULL(comm.text, '') AS DefaultValue FROM dbo.syscolumns col LEFT OUTER JOIN dbo.systypes t ON col.xtype = t.xusertype INNER JOIN dbo.sysobjects obj ON col.id = obj.id AND obj.xtype = 'U' AND obj.status >= 0 LEFT OUTER JOIN dbo.syscomments comm ON col.cdefault = comm.id LEFT OUTER JOIN sys.extended_properties ep ON col.id = ep.major_id AND col.colid = ep.minor_id AND ep.name = 'MS_Description' LEFT OUTER JOIN sys.extended_properties epTwo ON obj.id = epTwo.major_id AND epTwo.minor_id = 0 AND epTwo.name ='MS_Description' WHERE obj.name = '{0}' ORDER BY  col.colorder",
                    PublicFiled.TableName);
            DataTable dataBaseTables = Bll.ExecuteSql(sql, appConfig, PublicFiled.DataBaseName);
            return dataBaseTables;
        }

        /// <summary>
        ///  将T_Table转换成table
        /// </summary>
        /// <param name="tableName">tableName</param>
        /// Author  : Napoleon
        /// Created : 2015-05-27 16:10:34
        public static string SwitchTableName(string tableName)
        {
            string[] table = tableName.Split(PublicFiled.UnderLineSplit);
            if (table.Length > 1)
            {
                return table[1];
            }
            return tableName;
        }

        /// <summary>
        ///  将News_Table组合成NewsTable
        /// </summary>
        /// <param name="tableName">tableName</param>
        /// Author  : Napoleon
        /// Created : 2015-06-06 11:16:43
        public static string ComposeTableName(string tableName)
        {
            string[] table = tableName.Split(PublicFiled.UnderLineSplit);
            if (table.Length > 1)
            {
                return table[0] + table[1];
            }
            return tableName;
        }

        /// <summary>
        ///  返回字段
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2015-05-27 16:20:50
        public static string GetFiled1(DataTable dt)
        {
            StringBuilder filed = new StringBuilder(); //字段
            foreach (DataRow row in dt.Rows)
            {
                filed.AppendFormat("{0},", row["TableColumn"]);
            }
            return filed.ToString().Trim(PublicFiled.CommaSplit);
        }

        /// <summary>
        ///  返回@字段
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2015-05-27 16:20:50
        public static string GetFiled2(DataTable dt)
        {
            StringBuilder filed = new StringBuilder(); //字段
            foreach (DataRow row in dt.Rows)
            {
                filed.AppendFormat("@{0},", row["TableColumn"]);
            }
            return filed.ToString().Trim(PublicFiled.CommaSplit);
        }

        /// <summary>
        ///  返回字段=@字段
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2015-05-27 16:20:50
        public static string GetFiled3(DataTable dt)
        {
            StringBuilder filed = new StringBuilder(); //字段
            foreach (DataRow row in dt.Rows)
            {
                filed.AppendFormat("{0}=@{0},", row["TableColumn"]);
            }
            return filed.ToString().Trim(PublicFiled.CommaSplit);
        }

    }
}
