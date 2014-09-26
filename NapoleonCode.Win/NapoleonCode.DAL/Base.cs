using NapoleonCode.Model;

namespace NapoleonCode.DAL
{
    public class Base
    {

        private AppConfig appConfig;

        /// <summary>
        ///  配置实体类
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-08-24 17:33:44
        public AppConfig AppConfig
        {
            get { return appConfig; }
            set { appConfig = value; }
        }
    }
}
