using System;
using System.Data;
using System.Data.SqlClient;
using NapoleonCode.Model;

namespace NapoleonCode.DAL
{
    public class MsSqlDao
    {

        /// <summary>
        ///  默认使用系统的数据库名登录
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2014-08-24 17:59:05
        private readonly string _dbName = string.Format("master");

        /// <summary>
        ///  获取数据库登录信息
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2014-08-24 17:59:19
        private string GetConnectionString(AppConfig appConfig, string dataBaseName)
        {
            return string.Format("server={0};database={1};uid={2};pwd={3};", appConfig.ServerName, string.IsNullOrEmpty(dataBaseName) ? _dbName : dataBaseName, appConfig.UserName, appConfig.PassWord);
        }

        /// <summary>
        ///  公共语句
        /// </summary>
        /// <param name="sql">The SQL.</param>
        /// <param name="appConfig"></param>
        /// <param name="dataBaseName"></param>
        /// Author  : Napoleon
        /// Created : 2014-08-24 17:55:17
        public DataTable ExecuteSql(string sql, AppConfig appConfig, string dataBaseName)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(GetConnectionString(appConfig, dataBaseName));
            try
            {
                SqlCommand selectCommand = new SqlCommand(sql, connection);
                new SqlDataAdapter(selectCommand).Fill(dataTable);
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
        /// <returns>DataTable.</returns>
        /// Author  : Napoleon
        /// Created : 2014-08-24 17:38:40
        public DataTable GetTreeView(AppConfig appConfig, string tableName)
        {
            string sql = string.Format("SELECT DB_NAME(dbid) AS name FROM {0} order by name", string.IsNullOrEmpty(tableName) ? "sysdatabases" : tableName);
            return ExecuteSql(sql, appConfig, "");
        }

        /// <summary>
        ///  分类查询数据表信息
        /// </summary>
        /// <param name="appconfig"></param>
        /// <param name="dataBaseName"></param>
        /// <param name="type">类型(U-数据库表，V-视图......)</param>
        /// Author  : Napoleon
        /// Created : 2014-08-28 14:21:01
        public DataTable GetTreeView(AppConfig appconfig, string dataBaseName, string type)
        {
            string sql = string.Format("select sysobjects.name AS name from sysobjects WHERE sysobjects.type='{0}' ORDER BY name", type);
            return ExecuteSql(sql, appconfig, dataBaseName);
        }



    }
}
