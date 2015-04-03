
using System.Windows.Forms;
using NapoleonCode.Win.DbForm;

namespace NapoleonCode.Win
{
    public partial class SelectDbForm : BaseForm
    {



        public SelectDbForm()
        {
            InitializeComponent();
        }

        /// <summary>
        ///  退出程序
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2014-10-21 10:12:12
        private void SelectDbForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        ///  返回
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2014-10-21 10:04:28
        private void BtnReturn_Click(object sender, System.EventArgs e)
        {
            SelectXmlForm form = new SelectXmlForm();
            Hide();
            form.ShowDialog();
        }

        /// <summary>
        ///  选择数据库类型
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2014-10-21 10:06:01
        private void BtnRun_Click(object sender, System.EventArgs e)
        {
            switch (RadSelectDb.SelectedIndex)
            {
                case 0://SQLServer
                    DbName = "SQLServer";
                    MsSqlForm msSql = new MsSqlForm();
                    Hide();
                    msSql.Show();
                    break;
                case 1://SQLite
                    DbName = "SQLite";
                    SqLiteForm sqLite = new SqLiteForm();
                    Hide();
                    sqLite.Show();
                    break;
                case 2://Oracle
                    Name = "Oracle";
                    break;
                case 3://MySQL
                    Name = "MySQL";
                    break;
            }
        }



    }
}
