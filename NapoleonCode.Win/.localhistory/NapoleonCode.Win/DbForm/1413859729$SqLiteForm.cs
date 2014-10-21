
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

        /// <summary>
        ///  浏览数据库文件
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-21 10:39:26
        private void BtnBrowser_Click(object sender, System.EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "*.sqlite|*.db|*.s3db|*.s2db";
            }
        }

        /// <summary>
        ///  退出程序
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-21 10:46:58
        private void SqLiteForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }



    }
}
