
using System.Windows.Forms;

namespace NapoleonCode.Win
{
    public partial class SelectDbForm : BaseForm
    {



        public SelectDbForm()
        {
            InitializeComponent();
        }

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



    }
}
