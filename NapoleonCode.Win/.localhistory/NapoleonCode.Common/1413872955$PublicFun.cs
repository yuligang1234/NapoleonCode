using System;
using System.Configuration;
using System.Text;

namespace NapoleonCode.Common
{
    public static class PublicFun
    {

        #region 操作配置文件

        /// <summary>
        ///  根据key读取value
        /// </summary>
        /// <param name="key">The key.</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-08-20 09:59:25
        public static string GetAppConfig(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        /// <summary>
        ///  保存配置文件
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-08-20 10:12:26
        public static void SaveAppConfig(string key, string value)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings[key].Value = value;
            config.Save(ConfigurationSaveMode.Full);
            ConfigurationManager.RefreshSection("appSettings");
        }

        #endregion

        #region 注释

        /// <summary>
        ///  抬头注释
        /// </summary>
        /// <returns>System.String.</returns>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-09-25 14:22:06
        public static string GetTopCommentary()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("/*{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("=================================================={0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("///Author  :{0}{1}", PublicFiled.UserName, PublicFiled.WarpSymbol);
            sb.AppendFormat("///Company :{0}{1}", PublicFiled.CompanyName, PublicFiled.WarpSymbol);
            sb.AppendFormat("///Created :{0}{1}", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"), PublicFiled.WarpSymbol);
            sb.AppendFormat("=================================================={0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("*/{0}", PublicFiled.WarpSymbol);
            return sb.ToString();
        }

        /// <summary>
        ///  注释
        /// </summary>
        /// <param name="tableDesc"></param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-09-25 11:15:59
        public static string GetCommentary(string tableDesc)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("///<summary>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("///{0}{1}", tableDesc, PublicFiled.WarpSymbol);
            sb.AppendFormat("///<summary>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("///Author  :{0}{1}", PublicFiled.UserName, PublicFiled.WarpSymbol);
            sb.AppendFormat("///Company :{0}{1}", PublicFiled.CompanyName, PublicFiled.WarpSymbol);
            sb.AppendFormat("///Created :{0}{1}", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"), PublicFiled.WarpSymbol);
            return sb.ToString();
        }

        #endregion

        #region 格式化

        /// <summary>
        ///  格式化类型(decimal->decimal(12,2))
        /// </summary>
        /// <param name="oldType"></param>
        /// <param name="leng1"></param>
        /// <param name="leng2"></param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-09-25 16:18:11
        public static string FormatType(string oldType, string leng1, string leng2)
        {
            switch (oldType)
            {
                case "decimal":
                    return string.Format("{0}({1},{2})", oldType, leng1, leng2);
                case "nvarchar":
                case "char":
                case "varchar":
                    return string.Format("{0}({1})", oldType, leng1);
                default:
                    return oldType;
            }
        }

        /// <summary>
        ///  格式化类型(nvarchar->string)
        /// </summary>
        /// <param name="i">1表示为Nhibernate实体类，0表示基础实体类</param>
        /// <param name="type"></param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-09-25 16:18:11
        public static string FormatType(int i, string type)
        {
            switch (type)
            {
                case "nvarchar":
                case "varchar":
                    return "string";
                case "datetime":
                case "date":
                    return i == 1 ? "datatime?" : "datetime";
                case "numeric":
                    return "decimal";
                default:
                    return type;
            }
        }

        /// <summary>
        ///  格式化表名(Base_City->BaseCity)
        /// </summary>
        /// <param name="str">The string.</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-09-26 09:48:16
        public static string FormatTableName(string str)
        {
            StringBuilder sb = new StringBuilder();
            string[] strs = str.Split('_');
            foreach (string value in strs)
            {
                sb.AppendFormat("{0}", value);
            }
            return sb.ToString();
        }

        #endregion

        /// <summary>
        ///  根据数据库路径获取数据库文件名
        /// </summary>
        /// <param name="url">The URL.</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-21 14:25:21
        public static string GetDbName(string url)
        {
            string[] name = url.Split(PublicFiled.UrlSplit);
        }



    }
}
