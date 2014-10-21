
using System.Data;
using NapoleonCode.Model;

namespace NapoleonCode.BLL
{
    public class MsSqlDao
    {

        private readonly DAL.MsSqlDao _dal = new DAL.MsSqlDao();

        /// <summary>
        ///  数据库表名节点
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-08-24 17:40:55
        public DataTable GetTreeView(AppConfig appConfig)
        {
            return _dal.GetTreeView(appConfig, "");
        }

        /// <summary>
        ///  具体的数据库表
        /// </summary>
        /// <param name="appConfig">The appconfig.</param>
        /// <param name="tableName">Name of the table.</param>
        /// <param name="type">The type.</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-08-28 14:00:47
        public DataTable GetTreeView(AppConfig appConfig, string tableName, string type)
        {
            return _dal.GetTreeView(appConfig, tableName, type);
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
            return _dal.ExecuteSql(sql, appConfig, dataBaseName);
        }

    }
}
