
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using NapoleonCode.Model;

namespace NapoleonCode.Win
{
    public partial class BaseForm : XtraForm
    {

        private readonly static DefaultLookAndFeel DefaultLook = new DefaultLookAndFeel();

        /// <summary>
        ///  数据库名称字段
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2014-10-21 10:28:31
        protected string DbName { get; set; }

        /// <summary>
        ///  AppConfig实体类
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2014-10-21 11:18:59
        protected static AppConfig AppConfigs { get; set; }

        /// <summary>
        ///  应用皮肤
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2014-10-20 15:08:45
        protected static void ApplySkin(string skinName)
        {
            DefaultLook.LookAndFeel.SkinName = skinName;
        }

    }
}
