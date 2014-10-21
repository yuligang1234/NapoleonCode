
using System.Data;
using System.Windows.Forms;
using NapoleonCode.BLL;
using NapoleonCode.Common;
using NapoleonCode.Model;
using NapoleonCode.Win.MovingTemplate;

namespace NapoleonCode.Win.DbForm
{
    public partial class SqLiteContent : BaseForm
    {

        private readonly SqLiteService _bll = new SqLiteService();
        private readonly AppConfig _appConfig;

        public SqLiteContent()
        {
            _appConfig = AppConfigs;
            ApplySkin("McSkin");
            InitializeComponent();
            LoadForm();
            LoadTree();
        }


        /// <summary>
        ///  初始化窗体的时候，一些参数的设置
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-09-24 16:25:30
        private void LoadForm()
        {
            CobSelectTemb.SelectedIndex = 0;
            PlBaseTemp.Visible = true;
        }

        /// <summary>
        /// 加载左边的数据库表节点
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-08-24 17:56:13
        private void LoadTree()
        {
            TreeDataBase.Nodes.Add("", PublicFiled.TreeName);
            TreeDataBase.Nodes[0].Nodes.Add("", PublicFun.GetDbName(_appConfig.SqliteUrl), 0);
            /*DataTable dt = _bll.GetTreeView(_appConfig, "table");
            TreeDataBase.Nodes.Add("", PublicFiled.TreeName);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    TreeDataBase.Nodes[0].Nodes.Add("", row["name"].ToString(), 0);
                }
                TreeDataBase.ExpandAll();
            }*/
        }

        /// <summary>
        ///  加载具体的数据库表格
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-08-28 13:46:06
        private void LoadChildrenTree(TreeNode node)
        {
            DataTable dt = _bll.GetTreeView(_appConfig, "table");
            foreach (DataRow row in dt.Rows)
            {
                node.Nodes.Add("", row["name"].ToString(), 0);
            }
        }

        /// <summary>
        ///  关闭页面
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-08-24 16:32:57
        private void CodeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        ///  树节点双击事件
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-08-27 16:54:33
        private void TreeDataBase_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Level == 1)
            {
                e.Node.SelectedImageIndex = 2;
                e.Node.Nodes.Clear();
                e.Node.Nodes.Add("U", "用户表", 0);
                LoadChildrenTree(e.Node.Nodes["U"]);
            }
            else
            {
                if (e.Node.Level == 3)//双击数据库表获取其名称
                {
                    PublicFiled.DataBaseName = e.Node.Parent.Parent.Text;
                    PublicFiled.TableName = e.Node.Text;
                }
            }
        }

        /// <summary>
        ///  单击事件
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-08-28 14:26:36
        private void TreeDataBase_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Level == 3)
            {
                e.Node.SelectedImageIndex = 1;
            }
        }

        /// <summary>
        ///  下拉框改变事件
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-09-24 16:36:55
        private void CobSelectTemb_SelectedIndexChanged(object sender, System.EventArgs e)
        {
        }

        /// <summary>
        ///  生成代码
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-09-25 11:13:20
        private void BtnSubmit_Click(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(PublicFiled.DataBaseName))
            {
                if (!string.IsNullOrEmpty(PublicFiled.MovingTemplateName))
                {
                    //映射文件和类的命名空间
                    RtxtContent.Clear();//清除样式
                    switch (PublicFiled.MovingTemplateName)
                    {
                        case "RadBaseField"://基础模版的字段
                            RtxtContent.Text = BaseTemplate.InsertBaseField(_appConfig);
                            break;
                        case "RadBaseModel"://基础模版的实体类
                            RtxtContent.Text = BaseTemplate.InsertBaseModel(_appConfig);
                            break;
                        case "RadBaseProcedure"://基础模版的存储过程
                            RtxtContent.Text = BaseTemplate.InsertBaseProcedure(_appConfig);
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("请选择需要使用的模版！");
                }
            }
            else
            {
                MessageBox.Show("请双击选择需要使用的数据库表！");
            }
        }

        /// <summary>
        ///  模版选择事件
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 0001-01-01 00:00:00
        private void RadNhModel_Click(object sender, System.EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            if (radio.Checked)
            {
                PublicFiled.MovingTemplateName = radio.Name;
            }
        }

        /// <summary>
        ///  返回
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-09-29 13:32:31
        private void BtnReturn_Click(object sender, System.EventArgs e)
        {
            MsSqlForm form = new MsSqlForm();
            Hide();
            form.Show();
        }




    }
}
