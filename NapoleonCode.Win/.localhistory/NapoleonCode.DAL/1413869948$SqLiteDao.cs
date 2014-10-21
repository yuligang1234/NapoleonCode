
using System;
using System.Data;
using System.Data.SQLite;
using NapoleonCode.Model;

namespace NapoleonCode.DAL
{
    public class SqLiteDao
    {

        /// <summary>
        ///  获取数据库登录信息
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-08-24 17:59:19
        private string GetConnectionString(AppConfig appConfig)
        {
            return string.Format("Data Source={0}", appConfig.SqliteUrl);
        }

        /// <summary>
        ///  公共语句
        /// </summary>
        /// <param name="sql">The SQL.</param>
        /// <param name="appConfig"></param>
        /// <param name="dataBaseName"></param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-08-24 17:55:17
        public DataTable ExecuteSql(string sql, AppConfig appConfig, string dataBaseName)
        {
            DataTable dataTable = new DataTable();
            SQLiteConnection connection = new SQLiteConnection(GetConnectionString(appConfig));
            try
            {
                SQLiteCommand selectCommand = new SQLiteCommand(sql, connection);
                new SQLiteDataAdapter(selectCommand).Fill(dataTable);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            finally
            {
                connection.Close();
            }
            return dataTable;
        }

        /// <summary>
        ///  数据库表名节点
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-08-24 17:38:40
        public DataTable GetTreeView(AppConfig appConfig, string tableName)
        {
            string sql = string.Format("select * from sqlite_master where type={0}", string.IsNullOrEmpty(tableName) ? "sysdatabases" : tableName);
            return ExecuteSql(sql, appConfig, "");
        }

        /// <summary>
        ///  分类查询数据表信息
        /// </summary>
        /// <param name="appconfig"></param>
        /// <param name="dataBaseName"></param>
        /// <param name="type">类型(U-数据库表，V-视图......)</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-08-28 14:21:01
        public DataTable GetTreeView(AppConfig appconfig, string dataBaseName, string type)
        {
            string sql = string.Format("select sysobjects.name AS name from sysobjects WHERE sysobjects.type='{0}' ORDER BY name", type);
            return ExecuteSql(sql, appconfig, dataBaseName);
        }

    }
}
