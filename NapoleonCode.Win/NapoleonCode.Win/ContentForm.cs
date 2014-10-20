using System.Data;
using System.Drawing;
using System.Windows.Forms;
using NapoleonCode.Common;
using NapoleonCode.BLL;
using NapoleonCode.Model;
using NapoleonCode.Win.MovingTemplate;

namespace NapoleonCode.Win
{
    public partial class ContentForm : BaseForm
    {

        private readonly MsSql _bll = new MsSql();
        private readonly AppConfig _appConfig;

        public ContentForm(AppConfig appConfig)
        {
            ApplySkin("McSkin");
            _appConfig = appConfig;
            InitializeComponent();
            LoadTree();
            LoadForm();
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
            PlNhTemp.Visible = false;
            PlAutofacTemp.Visible = false;
        }

        /// <summary>
        /// 加载左边的数据库表节点
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-08-24 17:56:13
        private void LoadTree()
        {
            DataTable dt = _bll.GetTreeView(_appConfig);
            TreeDataBase.Nodes.Add("", PublicFiled.TreeName);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    TreeDataBase.Nodes[0].Nodes.Add("", row[0].ToString(), 0);
                }
                TreeDataBase.ExpandAll();
            }
        }

        /// <summary>
        ///  加载具体的数据库表格
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-08-28 13:46:06
        private void LoadChildrenTree(string tableName, TreeNode node)
        {
            DataTable dt = _bll.GetTreeView(_appConfig, tableName, "U");
            foreach (DataRow row in dt.Rows)
            {
                node.Nodes.Add("", row[0].ToString(), 0);
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
                LoadChildrenTree(e.Node.Text, e.Node.Nodes["U"]);
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
            //清除选中状态
            RadAutofacXml.Checked = RadBaseField.Checked = RadBaseModel.Checked = RadBaseProcedure.Checked = RadNhMapping.Checked = RadNhModel.Checked = RadNhXml.Checked = false;
            if (CobSelectTemb.SelectedIndex == 0)//基础模版
            {
                PlBaseTemp.Visible = true;
                PlNhTemp.Visible = PlAutofacTemp.Visible = false;
            }
            else if (CobSelectTemb.SelectedIndex == 1)//NHibernate模版
            {
                PlNhTemp.Visible = true;
                PlBaseTemp.Visible = PlAutofacTemp.Visible = false;
                //加载对应的命名空间
                TxtNhMapping.Text = PublicFun.GetAppConfig("NhMappingNameSpace");
                TxtNhModel.Text = PublicFun.GetAppConfig("NhNameSpace");
            }
            else if (CobSelectTemb.SelectedIndex == 2)//AutoFac模版
            {
                PlAutofacTemp.Visible = true;
                PlBaseTemp.Visible = PlNhTemp.Visible = false;
            }
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
                    PublicFiled.NhMappingNameSpace = TxtNhMapping.Text;
                    PublicFiled.NhNameSpace = TxtNhModel.Text;
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
                        case "RadNhModel"://NHibernate模版的实体类
                            RtxtContent.Text = NhibernateTemplate.InsertNhibernateModel(_appConfig);
                            break;
                        case "RadNhMapping"://NHibernate模版的映射文件
                            //保存设置
                            if (string.IsNullOrEmpty(TxtNhMapping.Text) || string.IsNullOrEmpty(TxtNhModel.Text))
                            {
                                RtxtContent.Text = "";
                                MessageBox.Show("请填写对应的命名空间！");
                            }
                            else
                            {
                                PublicFun.SaveAppConfig("NhMappingNameSpace", PublicFiled.NhMappingNameSpace);
                                PublicFun.SaveAppConfig("NhNameSpace", PublicFiled.NhNameSpace);
                                RtxtContent.Text = NhibernateTemplate.InsertNhibernateMapping(_appConfig);
                            }
                            break;
                        case "RadNhXml"://NHibernate模版的配置文件
                            RtxtContent.Text = NhibernateTemplate.InsertNhiberanteXml(_appConfig);
                            RtxtContent.Find("该配置为MSSQL下的配置，更换数据库请修改对应的dialect、driver_class属性");
                            RtxtContent.SelectionFont = new Font("", 12, FontStyle.Bold);
                            RtxtContent.SelectionColor = Color.Red;
                            break;
                        case "RadAutofacXml"://Autofac模版的配置文件
                            RtxtContent.Text = AutofacTemplate.InsertAutofacXml(_appConfig);
                            RtxtContent.Find("新建配置文件AuthConfig.cs，将配置写入进去，并在Application_Start()中启用");
                            RtxtContent.SelectionFont = new Font("", 12, FontStyle.Bold);
                            RtxtContent.SelectionColor = Color.Red;
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
            StartForm form = new StartForm();
            Hide();
            form.Show();
        }





    }
}
