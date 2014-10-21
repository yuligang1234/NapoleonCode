
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
        private string GetConnectionString(AppConfig appConfig, string dataBaseName)
        {
            return string.Format("Data Source={0}", appConfig.SqliteUrl);
        }

    }
}
