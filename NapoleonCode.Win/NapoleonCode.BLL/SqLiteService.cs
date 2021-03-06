﻿
using System.Data;
using NapoleonCode.DAL;
using NapoleonCode.Model;

namespace NapoleonCode.BLL
{
    public class SqLiteService
    {

        private readonly SqLiteDao _dal = new SqLiteDao();

        /// <summary>
        ///  数据库表名节点
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-08-24 17:40:55
        public DataTable GetTreeView(AppConfig appConfig, string type)
        {
            return _dal.GetTreeView(appConfig, type);
        }

        /// <summary>
        ///  具体的数据库表
        /// </summary>
        /// <param name="appConfig">The appconfig.</param>
        /// <param name="tableName">Name of the table.</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-08-28 14:00:47
        public DataTable GetTreeViews(AppConfig appConfig, string tableName)
        {
            return _dal.GetTreeViews(appConfig, tableName);
        }

    }
}
