using System.Data;
using System.Text;
using NapoleonCode.BLL;
using NapoleonCode.Common;
using NapoleonCode.Model;

namespace NapoleonCode.Win.MovingTemplate
{
    public class NhibernateTemplate
    {

        private static readonly MsSqlService Bll = new MsSqlService();

        /// <summary>
        ///  公用DataTable
        /// </summary>
        /// <param name="appConfig">数据库配置类</param>
        /// Author  : Napoleon
        /// Created : 2014-09-25 10:31:18
        private static DataTable GetTable(AppConfig appConfig)
        {
            string sql = string.Format("SELECT obj.name AS TableName ,col.colorder AS Id ,col.name AS TableColumn ,ISNULL(ep.[value], col.name) AS TableDesc ,t.name AS DataType ,col.length AS TypeLength ,ISNULL(COLUMNPROPERTY(col.id, col.name, 'Scale'), 0) AS DecimalLength ,CASE WHEN COLUMNPROPERTY(col.id, col.name, 'IsIdentity') = 1 THEN 'true' ELSE 'false' END AS IsFlag ,CASE WHEN EXISTS (SELECT 1 FROM dbo.sysindexes si INNER JOIN dbo.sysindexkeys sik ON si.id = sik.id INNER JOIN dbo.syscolumns sc ON sc.id = sik.id AND sc.colid = sik.colid INNER JOIN dbo.sysobjects so ON so.name = si.name AND so.xtype = 'PK' WHERE sc.id = col.id AND sc.colid = col.colid ) THEN 'true' ELSE 'false' END AS IsKey , CASE WHEN col.isnullable = 1 THEN 'true' ELSE 'false' END AS IsNull , ISNULL(comm.text, '') AS DefaultValue FROM dbo.syscolumns col LEFT OUTER JOIN dbo.systypes t ON col.xtype = t.xusertype INNER JOIN dbo.sysobjects obj ON col.id = obj.id AND obj.xtype = 'U' AND obj.status >= 0 LEFT OUTER JOIN dbo.syscomments comm ON col.cdefault = comm.id LEFT OUTER JOIN sys.extended_properties ep ON col.id = ep.major_id AND col.colid = ep.minor_id AND ep.name = 'MS_Description' LEFT OUTER JOIN sys.extended_properties epTwo ON obj.id = epTwo.major_id AND epTwo.minor_id = 0 AND epTwo.name ='MS_Description' WHERE obj.name = '{0}' ORDER BY  col.colorder", PublicFiled.TableName);
            DataTable dataBaseTables = Bll.ExecuteSql(sql, appConfig, PublicFiled.DataBaseName);
            return dataBaseTables;
        }

        /// <summary>
        ///  NHibernate模版的实体类
        /// </summary>
        /// <param name="appConfig">数据库配置类</param>
        /// Author  : Napoleon
        /// Created : 2014-09-25 10:01:16
        public static string InsertNhibernateModel(AppConfig appConfig)
        {
            StringBuilder sb = new StringBuilder();
            DataTable dataBaseTables = GetTable(appConfig);
            if (dataBaseTables.Rows.Count > 0)
            {
                foreach (DataRow row in dataBaseTables.Rows)
                {
                    sb.AppendFormat("{0}", PublicFun.GetCommentary(row["TableDesc"].ToString()));//注释
                    sb.AppendFormat("public virtual {0} {1}{2}", PublicFun.MsSqlFormatType(1, row["DataType"].ToString()), row["TableColumn"], PublicFiled.WarpSymbol);
                    sb.Append("{");
                    sb.AppendFormat("{0}", PublicFiled.WarpSymbol);
                    sb.AppendFormat("{0}get ;{1}", PublicFiled.TabSymbol, PublicFiled.WarpSymbol);
                    sb.AppendFormat("{0}set ;{1}", PublicFiled.TabSymbol, PublicFiled.WarpSymbol);
                    sb.Append("}");
                    sb.AppendFormat("{0}{0}", PublicFiled.WarpSymbol);
                }
            }
            return sb.ToString();
        }

        /// <summary>
        ///  NHibernate模版的映射文件
        /// </summary>
        /// <param name="appConfig">数据库配置类</param>
        /// Author  : Napoleon
        /// Created : 2014-09-26 09:53:28
        public static string InsertNhibernateMapping(AppConfig appConfig)
        {
            StringBuilder sb = new StringBuilder();
            DataTable dataBaseTables = GetTable(appConfig);
            sb.AppendFormat("<?xml version=\"1.0\" encoding=\"utf-8\" ?>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("<hibernate-mapping xmlns=\"urn:nhibernate-mapping-2.2\">{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("  <class name=\"{0}.{1}, {2}\" table=\"{3}\" lazy=\"false\">{4}", PublicFiled.NhMappingNameSpace, PublicFun.FormatTableName(PublicFiled.TableName), PublicFiled.NhNameSpace, PublicFiled.TableName, PublicFiled.WarpSymbol);
            foreach (DataRow row in dataBaseTables.Rows)
            {
                //主键
                if (row["IsKey"].ToString().Equals("true"))
                {
                    sb.AppendFormat("    <id name=\"{0}\" column=\"{0}\" type=\"{1}\">{2}", row["TableColumn"], row["DataType"], PublicFiled.WarpSymbol);
                    sb.AppendFormat("      <generator class=\"assigned\" />{0}", PublicFiled.WarpSymbol);
                    sb.AppendFormat("    </id>{0}", PublicFiled.WarpSymbol);
                    continue;
                }
                sb.AppendFormat("    <property name=\"{0}\" column=\"{0}\" type=\"{1}\" />{2}", row["TableColumn"], PublicFun.MsSqlFormatType(0, row["DataType"].ToString()), PublicFiled.WarpSymbol);
            }
            sb.AppendFormat("  </class>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("</hibernate-mapping>{0}", PublicFiled.WarpSymbol);
            return sb.ToString();
        }

        /// <summary>
        ///  NHibernate模版的配置文件
        /// </summary>
        /// <param name="appConfig">数据库配置类</param>
        /// Author  : Napoleon
        /// Created : 2014-09-26 10:51:27
        public static string InsertNhiberanteXml(AppConfig appConfig)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("该配置为MSSQL下的配置，更换数据库请修改对应的dialect、driver_class属性{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("{0}{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("<?xml version=\"1.0\" encoding=\"utf-8\" ?>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("<hibernate-configuration xmlns=\"urn:nhibernate-configuration-2.2\">{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("  <session-factory>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    <property name=\"dialect\">NHibernate.Dialect.MsSql2008Dialect</property>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    <property name=\"connection.provider\">NHibernate.Connection.DriverConnectionProvider</property>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    <property name=\"connection.driver_class\">NHibernate.Driver.SqlClientDriver</property>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    <property name=\"connection.connection_string\">server={0};database={1};uid={2};pwd={3};</property>{4}", appConfig.ServerName, PublicFiled.DataBaseName, appConfig.UserName, appConfig.PassWord, PublicFiled.WarpSymbol);
            sb.AppendFormat("    <property name=\"proxyfactory.factory_class\">NHibernate.Bytecode.DefaultProxyFactoryFactory,NHibernate</property>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    <property name=\"show_sql\">true</property>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    <property name=\"command_timeout\">10</property>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    <property name=\"adonet.batch_size\">10</property>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    <property name=\"query.substitutions\">true 1, false 0, yes 'Y', no 'N'</property>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    <mapping assembly=\"{0}\" />{1}", PublicFiled.NhNameSpace, PublicFiled.WarpSymbol);
            sb.AppendFormat("  </session-factory>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("</hibernate-configuration>{0}", PublicFiled.WarpSymbol);
            return sb.ToString();
        }


    }
}
