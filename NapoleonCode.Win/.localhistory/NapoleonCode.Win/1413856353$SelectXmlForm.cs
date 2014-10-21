using System;
using System.Windows.Forms;

namespace NapoleonCode.Win
{
    public partial class SelectForm : BaseForm
    {
        public SelectForm()
        {
            ApplySkin("McSkin");
            InitializeComponent();
        }

        /// <summary>
        ///  动态配置
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-09-29 13:24:03
        private void BtnMovingConfing_Click(object sender, EventArgs e)
        {
            StartForm form = new StartForm();
            Hide();
            form.ShowDialog();
        }

        /// <summary>
        ///  静态配置
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
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
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-09-29 13:29:18
        private void CodeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }



    }
}
