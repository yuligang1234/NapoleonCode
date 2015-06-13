using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using NapoleonCode.Common;
using NapoleonCode.BLL;
using NapoleonCode.Model;
using NapoleonCode.Win.MovingTemplate;

namespace NapoleonCode.Win.DbForm
{
    public partial class MsSqlContent : BaseForm
    {

        private readonly MsSqlService _bll = new MsSqlService();
        private readonly AppConfig _appConfig;
        private SynchronizationContext _sysContext;//UI线程同步上下文

        public MsSqlContent()
        {
            ApplySkin("McSkin");
            _appConfig = AppConfigs;
            InitializeComponent();
            LoadTree();
            LoadForm();
            _sysContext = SynchronizationContext.Current;//获取UI线程同步上下文
        }

        /// <summary>
        ///  初始化窗体的时候，一些参数的设置
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2014-09-24 16:25:30
        private void LoadForm()
        {
            CobSelectTemb.SelectedIndex = 0;
            PlBaseTemp.Visible = true;
            PlNhTemp.Visible = false;
            PlAutofacTemp.Visible = false;
            plAutoDapperTemp.Visible = false;
        }

        /// <summary>
        /// 加载左边的数据库表节点
        /// </summary>
        /// Author  : Napoleon
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
        /// Author  : Napoleon
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
        /// Author  : Napoleon
        /// Created : 2014-08-24 16:32:57
        private void CodeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        ///  返回
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2014-09-29 13:32:31
        private void BtnReturn_Click(object sender, System.EventArgs e)
        {
            MsSqlForm form = new MsSqlForm();
            Hide();
            form.Show();
        }

        /// <summary>
        ///  树节点双击事件
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2014-08-27 16:54:33
        private void TreeDataBase_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Level == 1)//双击数据库
            {
                e.Node.SelectedImageIndex = 2;
                e.Node.Nodes.Clear();
                e.Node.Nodes.Add("U", "用户表", 0);
                LoadChildrenTree(e.Node.Text, e.Node.Nodes["U"]);
                PublicFiled.DataBaseName = e.Node.Text;
                PublicFiled.TableName = "";
            }
            else
            {
                if (e.Node.Level == 3)//双击数据库表获取其名称
                {
                    PublicFiled.TableName = e.Node.Text;
                }
            }
        }

        /// <summary>
        ///  单击事件
        /// </summary>
        /// Author  : Napoleon
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
        /// Author  : Napoleon
        /// Created : 2014-09-24 16:36:55
        private void CobSelectTemb_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            //清除选中状态
            RadAutofacXml.Checked = RadBaseField.Checked = RadBaseModel.Checked = RadBaseProcedure.Checked = RadNhMapping.Checked = RadNhModel.Checked = RadNhXml.Checked = false;
            //txtBrowser.Text = "";//路径清空
            RtxtContent.Clear();//清除样式
            PublicFiled.MovingTemplateName = "";
            switch (CobSelectTemb.SelectedIndex)
            {
                case 0://基础模版
                    PlBaseTemp.Visible = true;
                    PlNhTemp.Visible = PlAutofacTemp.Visible = plAutoDapperTemp.Visible = false;
                    break;
                case 1://NHibernate模版
                    PlNhTemp.Visible = true;
                    PlBaseTemp.Visible = PlAutofacTemp.Visible = plAutoDapperTemp.Visible = false;
                    //加载对应的命名空间
                    TxtNhMapping.Text = PublicFun.GetAppConfig("NhMappingNameSpace");
                    TxtNhModel.Text = PublicFun.GetAppConfig("NhNameSpace");
                    break;
                case 2://AutoFac模版
                    PlAutofacTemp.Visible = true;
                    PlBaseTemp.Visible = PlNhTemp.Visible = plAutoDapperTemp.Visible = false;
                    break;
                case 3://AutoFac+Dapper文件
                    plAutoDapperTemp.Visible = true;
                    PlBaseTemp.Visible = PlNhTemp.Visible = PlAutofacTemp.Visible = false;
                    txtAutoDapper.Text = PublicFun.GetAppConfig("AutoDapperSpace");
                    break;
            }
        }

        /// <summary>
        ///  生成代码
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2014-09-25 11:13:20
        private void BtnSubmit_Click(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(PublicFiled.TableName))
            {
                if (!string.IsNullOrEmpty(PublicFiled.MovingTemplateName))
                {
                    //映射文件和类的命名空间
                    PublicFiled.NhMappingNameSpace = TxtNhMapping.Text;
                    PublicFiled.NhNameSpace = TxtNhModel.Text;
                    DataTable dt = PublicTemplate.GetTable(_appConfig, PublicFiled.TableName);//数据库表查询信息
                    switch (PublicFiled.MovingTemplateName)
                    {
                        case "RadBaseField":
                            RtxtContent.Text = BaseTemplate.InsertBaseField(dt);
                            break;
                        case "RadBaseModel"://基础模版的实体类
                            RtxtContent.Clear();//清除样式
                            RtxtContent.Text = BaseTemplate.InsertBaseModel(dt);
                            break;
                        case "RadBaseProcedure"://基础模版的存储过程
                            RtxtContent.Clear();//清除样式
                            RtxtContent.Text = BaseTemplate.InsertBaseProcedure(dt);
                            break;
                        case "RadNhModel"://NHibernate模版的实体类
                            RtxtContent.Clear();//清除样式
                            RtxtContent.Text = NhibernateTemplate.InsertNhibernateModel(dt);
                            break;
                        case "RadNhMapping"://NHibernate模版的映射文件
                            RtxtContent.Clear();//清除样式
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
                                RtxtContent.Text = NhibernateTemplate.InsertNhibernateMapping(dt);
                            }
                            break;
                        case "RadNhXml"://NHibernate模版的配置文件
                            RtxtContent.Clear();//清除样式
                            RtxtContent.Text = NhibernateTemplate.InsertNhiberanteXml(_appConfig);
                            RtxtContent.Find("该配置为MSSQL下的配置，更换数据库请修改对应的dialect、driver_class属性");
                            RtxtContent.SelectionFont = new Font("", 12, FontStyle.Bold);
                            RtxtContent.SelectionColor = Color.Red;
                            break;
                        case "RadAutofacXml"://Autofac模版的配置文件
                            RtxtContent.Clear();//清除样式
                            RtxtContent.Text = AutofacTemplate.InsertAutofacXml(_appConfig);
                            RtxtContent.Find("新建配置文件AuthConfig.cs，将配置写入进去，并在Application_Start()中启用");
                            RtxtContent.SelectionFont = new Font("", 12, FontStyle.Bold);
                            RtxtContent.SelectionColor = Color.Red;
                            break;
                        case "AutoDapper"://AutoFac+Dapper文件
                            Thread thread = new Thread(CreateAutoDapperCs);
                            thread.Start();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("请选择需要使用的模版或者选择生成路径！");
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
        /// Author  : Napoleon
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
        ///  选择生成路径
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2015-05-27 14:20:03
        private void BtnBrowser_Click(object sender, System.EventArgs e)
        {
            PublicFiled.MovingTemplateName = "AutoDapper";
            using (FolderBrowserDialog folder = new FolderBrowserDialog())
            {
                folder.ShowNewFolderButton = true;
                if (folder.ShowDialog() == DialogResult.OK)
                {
                    txtBrowser.Text = folder.SelectedPath;
                }
            }
        }

        /// <summary>
        ///  生成autofac+dapper文件
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2015-06-06 13:58:45
        private void CreateAutoDapperCs()
        {
            DataTable dt = PublicTemplate.GetTable(_appConfig, PublicFiled.TableName);//数据库表查询信息
            string tableModel = PublicTemplate.ComposeTableName(dt.Rows[0][0].ToString());
            string namespaces = txtAutoDapper.Text;

            #region DAL文件

            string filePath = txtBrowser.Text + "\\" + tableModel + "Dao.cs";
            string content = AutoDapperTemplate.CompleteDao(namespaces, tableModel, dt);
            FileFunc.OperateFile(filePath, content);
            //在线程中更新UI（通过UI线程同步上下文_sysContext）
            _sysContext.Post(AppendToText, filePath);

            #endregion

            #region IDAL文件

            filePath = txtBrowser.Text + "\\" + "I" + tableModel + "Dao.cs";
            content = AutoDapperTemplate.CompleteIDao(namespaces, tableModel, dt);
            FileFunc.OperateFile(filePath, content);
            _sysContext.Post(AppendToText, filePath);

            #endregion

            #region BLL文件

            filePath = txtBrowser.Text + "\\" + tableModel + "Service.cs";
            content = AutoDapperTemplate.CompleteService(namespaces, tableModel, dt);
            FileFunc.OperateFile(filePath, content);
            _sysContext.Post(AppendToText, filePath);

            #endregion

            #region IBLL文件

            filePath = txtBrowser.Text + "\\" + "I" + tableModel + "Service.cs";
            content = AutoDapperTemplate.CompleteIService(namespaces, tableModel, dt);
            FileFunc.OperateFile(filePath, content);
            _sysContext.Post(AppendToText, filePath);

            #endregion

        }

        /// <summary>
        ///  实时显示导出情况
        /// </summary>
        /// <param name="value"></param>
        /// Author  : Napoleon
        /// Created : 2015-06-06 13:59:29
        private void AppendToText(object value)
        {
            RtxtContent.AppendText(value.ToString());
            RtxtContent.AppendText("\r\n");
        }

        /// <summary>
        ///  导出功能
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2015-06-13 13:59:00
        private void BtnExport_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PublicFiled.DataBaseName))
            {
                MessageBox.Show("请双击选择需要使用的数据库表！");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtBrowser.Text))
            {
                MessageBox.Show("请在Autofac+Dapper文件中选择导出路径！");
                return;
            }
            if (!PublicFiled.MovingTemplateName.Equals("RadBaseModel") && !PublicFiled.MovingTemplateName.Equals("RadNhModel") && !PublicFiled.MovingTemplateName.Equals("RadNhMapping"))
            {
                MessageBox.Show("导出功能只对基础模版实体类、NHibernate模版的实体类/映射文件有效！");
                return;
            }
            if (string.IsNullOrEmpty(TxtNhMapping.Text) || string.IsNullOrEmpty(TxtNhModel.Text))
            {
                MessageBox.Show("请填写对应的命名空间！");
                return;
            }
            DataTable dt;
            if (string.IsNullOrWhiteSpace(PublicFiled.TableName))//批量导出该数据库下的所有表
            {
                dt = _bll.GetTreeView(_appConfig, PublicFiled.DataBaseName, "U");//所有数据库表
                foreach (DataRow row in dt.Rows)
                {
                    dt = PublicTemplate.GetTable(_appConfig, row[0].ToString());
                    ExportSingleFile(dt);
                }
            }
            else//导出单个的数据库表
            {
                dt = PublicTemplate.GetTable(_appConfig, PublicFiled.TableName);//数据库表查询信息
                ExportSingleFile(dt);
            }
        }

        /// <summary>
        ///  导出单个文件
        /// </summary>
        /// <param name="dt">The dt.</param>
        /// Author  : Napoleon
        /// Created : 2015-06-13 15:27:26
        private void ExportSingleFile(DataTable dt)
        {
            string filePath = txtBrowser.Text,
                content = "",
                tableModel = PublicTemplate.ComposeTableName(dt.Rows[0][0].ToString()),
                namespaces = txtAutoDapper.Text;
            switch (PublicFiled.MovingTemplateName)
            {
                case "RadBaseModel"://基础模版的实体类
                    filePath += "\\" + tableModel + ".cs";
                    namespaces += ".Model";
                    content = ExportTemplate.ExportModel(namespaces, tableModel, BaseTemplate.InsertBaseModel(dt));
                    break;
                case "RadNhModel"://NHibernate模版的实体类
                    filePath += "\\" + tableModel + ".cs";
                    namespaces += ".Model.Entities";
                    content = ExportTemplate.ExportModel(namespaces, tableModel, NhibernateTemplate.InsertNhibernateModel(dt));
                    break;
                case "RadNhMapping"://NHibernate模版的映射文件
                    filePath += "\\" + tableModel + ".hbm.xml";
                    PublicFiled.NhMappingNameSpace = TxtNhMapping.Text;
                    PublicFiled.NhNameSpace = TxtNhModel.Text;
                    content = NhibernateTemplate.InsertNhibernateMapping(dt);
                    break;
            }
            FileFunc.OperateFile(filePath, content);
            _sysContext.Post(AppendToText, filePath);
        }


    }
}
