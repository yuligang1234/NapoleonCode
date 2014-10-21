using System;
using System.Windows.Forms;
using NapoleonCode.Common;
using NapoleonCode.Model;

namespace NapoleonCode.Win
{
    public partial class StartForm : BaseForm
    {

        public StartForm()
        {
            ApplySkin("McSkin");
            InitializeComponent();
            //读取配置
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
            DropDataBase.SelectedItem = PublicFun.GetAppConfig("database");
            TxtBrowse.Text = PublicFun.GetAppConfig("serverName");
            TxtUserName.Text = PublicFun.GetAppConfig("userName");
            TxtPassWord.Text = PublicFun.GetAppConfig("passWord");
        }

        /// <summary>
        ///  保存配置
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-08-24 15:15:48
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!IsNull())
            {
                try
                {
                    PublicFun.SaveAppConfig("database", DropDataBase.SelectedItem.ToString());
                    PublicFun.SaveAppConfig("serverName", TxtBrowse.Text);
                    PublicFun.SaveAppConfig("userName", TxtUserName.Text);
                    PublicFun.SaveAppConfig("passWord", TxtPassWord.Text);
                    MessageBox.Show("保存成功！");
                }
                catch (Exception)
                {
                    MessageBox.Show("保存失败！");
                }
            }
            else
            {
                MessageBox.Show("请填写完整配置！");
            }
        }

        /// <summary>
        ///  判空
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-08-24 15:17:37
        private bool IsNull()
        {
            if (string.IsNullOrEmpty(DropDataBase.Text) || string.IsNullOrEmpty(TxtBrowse.Text) ||
                string.IsNullOrEmpty(TxtUserName.Text) || string.IsNullOrEmpty(TxtPassWord.Text))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        ///  连接数据库
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-08-24 15:25:21
        private void BtnRun_Click(object sender, EventArgs e)
        {
            ContentForm form = new ContentForm(GetModel())
            {
                Owner = this,
            };
            Hide();
            form.ShowDialog();
        }

        /// <summary>
        ///  配置实体类
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-08-24 17:24:47
        private AppConfig GetModel()
        {
            AppConfig appconfig = new AppConfig();
            appconfig.Author = PublicFun.GetAppConfig("author");
            appconfig.Database = DropDataBase.Text;
            appconfig.ServerName = TxtBrowse.Text;
            appconfig.UserName = TxtUserName.Text;
            appconfig.PassWord = TxtPassWord.Text;
            return appconfig;
        }

        /// <summary>
        ///  返回
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-09-29 13:34:33
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            SelectForm form = new SelectForm();
            Hide();
            form.ShowDialog();
        }

        /// <summary>
        ///  关闭
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-09-29 14:45:08
        private void CodeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        ///  数据库选择事件
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-21 09:19:08
        private void DropDataBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (DropDataBase.SelectedText)
            {
                case "MSSQL"://MSSQL数据库
                    LblBrowse.Visible =
                        LblPassWord.Visible =
                            LblUserName.Visible = TxtBrowse.Visible = TxtPassWord.Visible = TxtUserName.Visible = false;
                    break;
                case "SQLite"://SQLite数据库
                    break;
            }
        }



    }
}
