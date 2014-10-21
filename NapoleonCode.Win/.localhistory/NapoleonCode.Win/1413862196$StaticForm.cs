using System.Drawing;
using System.Windows.Forms;
using NapoleonCode.Common;
using NapoleonCode.Win.StaticTemplate;

namespace NapoleonCode.Win
{
    public partial class StaticForm : BaseForm
    {



        public StaticForm()
        {
            ApplySkin("McSkin");
            InitializeComponent();
        }

        /// <summary>
        ///  关闭
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-09-29 14:44:21
        private void CodeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        ///  返回
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-09-29 13:55:09
        private void BtnReturn_Click(object sender, System.EventArgs e)
        {
            SelectXmlForm form = new SelectXmlForm();
            Hide();
            form.Show();
        }

        /// <summary>
        ///  代码生成
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-09-29 14:24:06
        private void BtnSubmit_Click(object sender, System.EventArgs e)
        {
            RtbContent.Clear();//清除样式
            if (string.IsNullOrEmpty(PublicFiled.StaticTemplateName))
            {
                MessageBox.Show("请先选择模版，再生成代码！");
                return;
            }
            switch (PublicFiled.StaticTemplateName)
            {
                case "TxtConfing"://文本配置
                    RtbContent.Text = Log4Template.InsertTxtConfig();
                    RtbContent.Find("将下面配置加入到log4net.config中，并在AssemblyInfo.cs中加入log4net.config路径");
                    RtbContent.SelectionFont = new Font("", 12, FontStyle.Bold);
                    RtbContent.SelectionColor = Color.Red;
                    break;
                case "TxtHelper"://文本Helper
                    RtbContent.Text = Log4Template.InsertTxtHelper();
                    break;
                case "DbConfing"://数据库配置
                    RtbContent.Text = Log4Template.InsertDbConfig();
                    RtbContent.Find("该配置为Oracle数据库的配置，更换数据库，请修改对应的appender-ref节点和parameterName的value形式");
                    RtbContent.SelectionFont = new Font("", 12, FontStyle.Bold);
                    RtbContent.SelectionColor = Color.Red;
                    break;
                case "DbHelper"://数据库Helper
                    RtbContent.Text = Log4Template.InsertDbHelper();
                    break;
            }
        }

        /// <summary>
        ///  双击选择模版节点
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-09-29 14:32:21
        private void TreeStaticTemp_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //子节点
            if (e.Node.Level == 2)
            {
                PublicFiled.StaticTemplateName = e.Node.Name;
            }
        }



    }
}
