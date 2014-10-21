
using System.Windows.Forms;
using NapoleonCode.Common;

namespace NapoleonCode.Win.DbForm
{
    public partial class SqLiteForm : BaseForm
    {



        public SqLiteForm()
        {
            ApplySkin("McSkin");
            InitializeComponent();
            LoadValue();
        }

        /// <summary>
        ///  加载配置信息
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-08-24 14:58:18
        private void LoadValue()
        {
            TxtDataBase.Text = Name;
            TxtDbUrl.Text = PublicFun.GetAppConfig("sqliteUrl");
        }



    }
}
