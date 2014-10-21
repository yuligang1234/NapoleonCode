
using System.Windows.Forms;

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
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosedEventArgs"/> instance containing the event data.</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-21 10:12:12
        private void SelectDbForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        ///  返回
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
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
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-21 10:06:01
        private void BtnRun_Click(object sender, System.EventArgs e)
        {
            switch (RadSelectDb.SelectedIndex)
            {
                case 1://SQLServer
                    MsSqlForm msSql = new MsSqlForm();
                    Hide();
                    msSql.Show();
                    break;
            }
        }



    }
}
