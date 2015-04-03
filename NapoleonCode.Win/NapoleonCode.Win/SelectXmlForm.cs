using System;
using System.Windows.Forms;

namespace NapoleonCode.Win
{
    public partial class SelectXmlForm : BaseForm
    {
        public SelectXmlForm()
        {
            ApplySkin("McSkin");
            InitializeComponent();
        }

        /// <summary>
        ///  动态配置
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2014-09-29 13:24:03
        private void BtnMovingConfing_Click(object sender, EventArgs e)
        {
            SelectDbForm form = new SelectDbForm();
            Hide();
            form.ShowDialog();
        }

        /// <summary>
        ///  静态配置
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2014-09-29 13:25:05
        private void BtnStaticConfing_Click(object sender, EventArgs e)
        {
            StaticForm form = new StaticForm();
            Hide();
            form.ShowDialog();
        }

        /// <summary>
        ///  关闭
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2014-09-29 13:29:18
        private void CodeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }



    }
}
