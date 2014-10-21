
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



    }
}
