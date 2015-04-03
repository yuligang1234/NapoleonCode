
using System.Windows.Forms;
using NapoleonCode.Common;
using NapoleonCode.Model;

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
        /// Author  : Napoleon
        /// Created : 2014-08-24 14:58:18
        private void LoadValue()
        {
            TxtDataBase.Text = Name;
            TxtDbUrl.Text = PublicFun.GetAppConfig("sqliteUrl");
        }

        /// <summary>
        ///  浏览数据库文件
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2014-10-21 10:39:26
        private void BtnBrowser_Click(object sender, System.EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "|*.sqlite||*.db||*.s3db||*.s2db";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    TxtDbUrl.Text = dialog.FileName;
                    PublicFun.SaveAppConfig("sqliteUrl", dialog.FileName);
                }
            }
        }

        /// <summary>
        ///  退出程序
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2014-10-21 10:46:58
        private void SqLiteForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        ///  返回
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2014-10-21 10:58:28
        private void BtnReturn_Click(object sender, System.EventArgs e)
        {
            SelectDbForm selectDb = new SelectDbForm();
            Hide();
            selectDb.Show();
        }

        /// <summary>
        ///  运行
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2014-10-21 11:00:14
        private void BtnRun_Click(object sender, System.EventArgs e)
        {
            AppConfig appConfig=new AppConfig();
            appConfig.SqliteUrl = TxtDbUrl.Text;
            AppConfigs = appConfig;
            SqLiteContent sqLiteContent = new SqLiteContent();
            Hide();
            sqLiteContent.Show();
        }



    }
}
