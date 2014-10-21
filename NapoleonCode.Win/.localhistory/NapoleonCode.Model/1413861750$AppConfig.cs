
namespace NapoleonCode.Model
{
    public class AppConfig
    {

        private string _author;

        private string _database;

        private string _serverName;

        private string _userName;

        private string _passWord;

        private string _sqliteUrl;

        /// <summary>
        ///  数据库
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-08-24 16:57:56
        public string Database
        {
            get { return _database; }
            set { _database = value; }
        }

        /// <summary>
        ///  服务器名称
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-08-24 16:58:24
        public string ServerName
        {
            get { return _serverName; }
            set { _serverName = value; }
        }

        /// <summary>
        ///  登陆名
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-08-24 16:59:04
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        /// <summary>
        ///  密码
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-08-24 16:59:47
        public string PassWord
        {
            get { return _passWord; }
            set { _passWord = value; }
        }

        /// <summary>
        ///  作者
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-08-24 17:00:07
        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        /// <summary>
        ///  sqlite数据库文件路径
        /// </summary>
        /// <value>The sqlite URL.</value>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-21 11:22:11
        public string SqliteUrl
        {
            get { return _sqliteUrl; }
            set { _sqliteUrl = value; }
        }
    }
}
