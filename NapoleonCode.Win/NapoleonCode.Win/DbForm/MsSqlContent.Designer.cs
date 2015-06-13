using System.Windows.Forms;

namespace NapoleonCode.Win.DbForm
{
    partial class MsSqlContent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsSqlContent));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TreeDataBase = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnExport = new DevExpress.XtraEditors.SimpleButton();
            this.plAutoDapperTemp = new System.Windows.Forms.Panel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.BtnBrowser = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtAutoDapper = new DevExpress.XtraEditors.TextEdit();
            this.txtBrowser = new DevExpress.XtraEditors.TextEdit();
            this.BtnReturn = new DevExpress.XtraEditors.SimpleButton();
            this.RtxtContent = new System.Windows.Forms.RichTextBox();
            this.PlNhTemp = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNhModel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNhMapping = new System.Windows.Forms.TextBox();
            this.RadNhMapping = new System.Windows.Forms.RadioButton();
            this.RadNhXml = new System.Windows.Forms.RadioButton();
            this.RadNhModel = new System.Windows.Forms.RadioButton();
            this.BtnSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.PlAutofacTemp = new System.Windows.Forms.Panel();
            this.RadAutofacXml = new System.Windows.Forms.RadioButton();
            this.CobSelectTemb = new DevExpress.XtraEditors.ComboBoxEdit();
            this.PlBaseTemp = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.RadBaseProcedure = new System.Windows.Forms.RadioButton();
            this.RadBaseModel = new System.Windows.Forms.RadioButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.RadBaseField = new System.Windows.Forms.RadioButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.plAutoDapperTemp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAutoDapper.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrowser.Properties)).BeginInit();
            this.PlNhTemp.SuspendLayout();
            this.PlAutofacTemp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CobSelectTemb.Properties)).BeginInit();
            this.PlBaseTemp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TreeDataBase);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 770);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据库表(双击加载)";
            // 
            // TreeDataBase
            // 
            this.TreeDataBase.AllowDrop = true;
            this.TreeDataBase.ImageIndex = 0;
            this.TreeDataBase.ImageList = this.imageList1;
            this.TreeDataBase.Location = new System.Drawing.Point(8, 24);
            this.TreeDataBase.Name = "TreeDataBase";
            this.TreeDataBase.SelectedImageIndex = 0;
            this.TreeDataBase.Size = new System.Drawing.Size(335, 738);
            this.TreeDataBase.TabIndex = 0;
            this.TreeDataBase.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeDataBase_NodeMouseClick);
            this.TreeDataBase.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeDataBase_NodeMouseDoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "database.png");
            this.imageList1.Images.SetKeyName(1, "database_accept.png");
            this.imageList1.Images.SetKeyName(2, "database_add.png");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnExport);
            this.groupBox2.Controls.Add(this.plAutoDapperTemp);
            this.groupBox2.Controls.Add(this.BtnReturn);
            this.groupBox2.Controls.Add(this.RtxtContent);
            this.groupBox2.Controls.Add(this.PlNhTemp);
            this.groupBox2.Controls.Add(this.BtnSubmit);
            this.groupBox2.Controls.Add(this.PlAutofacTemp);
            this.groupBox2.Controls.Add(this.CobSelectTemb);
            this.groupBox2.Controls.Add(this.PlBaseTemp);
            this.groupBox2.Location = new System.Drawing.Point(372, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1225, 770);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "生成代码";
            // 
            // BtnExport
            // 
            this.BtnExport.AllowFocus = false;
            this.BtnExport.Location = new System.Drawing.Point(1015, 21);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(59, 23);
            this.BtnExport.TabIndex = 10;
            this.BtnExport.Text = "导出";
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // plAutoDapperTemp
            // 
            this.plAutoDapperTemp.BackColor = System.Drawing.Color.Transparent;
            this.plAutoDapperTemp.Controls.Add(this.labelControl2);
            this.plAutoDapperTemp.Controls.Add(this.BtnBrowser);
            this.plAutoDapperTemp.Controls.Add(this.labelControl1);
            this.plAutoDapperTemp.Controls.Add(this.txtAutoDapper);
            this.plAutoDapperTemp.Controls.Add(this.txtBrowser);
            this.plAutoDapperTemp.Location = new System.Drawing.Point(198, 14);
            this.plAutoDapperTemp.Name = "plAutoDapperTemp";
            this.plAutoDapperTemp.Size = new System.Drawing.Size(793, 36);
            this.plAutoDapperTemp.TabIndex = 7;
            // 
            // labelControl2
            // 
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(461, 11);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(81, 14);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "命名空间前缀:";
            // 
            // BtnBrowser
            // 
            this.BtnBrowser.AllowFocus = false;
            this.BtnBrowser.Location = new System.Drawing.Point(381, 8);
            this.BtnBrowser.Name = "BtnBrowser";
            this.BtnBrowser.Size = new System.Drawing.Size(59, 23);
            this.BtnBrowser.TabIndex = 9;
            this.BtnBrowser.Text = "浏览";
            this.BtnBrowser.Click += new System.EventHandler(this.BtnBrowser_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(3, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "生成路径:";
            // 
            // txtAutoDapper
            // 
            this.txtAutoDapper.EditValue = "";
            this.txtAutoDapper.Location = new System.Drawing.Point(545, 10);
            this.txtAutoDapper.Name = "txtAutoDapper";
            this.txtAutoDapper.Size = new System.Drawing.Size(224, 20);
            this.txtAutoDapper.TabIndex = 10;
            // 
            // txtBrowser
            // 
            this.txtBrowser.Location = new System.Drawing.Point(59, 10);
            this.txtBrowser.Name = "txtBrowser";
            this.txtBrowser.Properties.ReadOnly = true;
            this.txtBrowser.Size = new System.Drawing.Size(316, 20);
            this.txtBrowser.TabIndex = 0;
            // 
            // BtnReturn
            // 
            this.BtnReturn.AllowFocus = false;
            this.BtnReturn.Location = new System.Drawing.Point(1157, 21);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(59, 23);
            this.BtnReturn.TabIndex = 9;
            this.BtnReturn.Text = "返回";
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // RtxtContent
            // 
            this.RtxtContent.Location = new System.Drawing.Point(6, 62);
            this.RtxtContent.Name = "RtxtContent";
            this.RtxtContent.Size = new System.Drawing.Size(1208, 700);
            this.RtxtContent.TabIndex = 5;
            this.RtxtContent.Text = "";
            // 
            // PlNhTemp
            // 
            this.PlNhTemp.Controls.Add(this.label2);
            this.PlNhTemp.Controls.Add(this.TxtNhModel);
            this.PlNhTemp.Controls.Add(this.label1);
            this.PlNhTemp.Controls.Add(this.TxtNhMapping);
            this.PlNhTemp.Controls.Add(this.RadNhMapping);
            this.PlNhTemp.Controls.Add(this.RadNhXml);
            this.PlNhTemp.Controls.Add(this.RadNhModel);
            this.PlNhTemp.Location = new System.Drawing.Point(198, 14);
            this.PlNhTemp.Name = "PlNhTemp";
            this.PlNhTemp.Size = new System.Drawing.Size(793, 36);
            this.PlNhTemp.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(507, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "类命名空间：";
            // 
            // TxtNhModel
            // 
            this.TxtNhModel.Location = new System.Drawing.Point(586, 7);
            this.TxtNhModel.Name = "TxtNhModel";
            this.TxtNhModel.Size = new System.Drawing.Size(122, 22);
            this.TxtNhModel.TabIndex = 5;
            this.TxtNhModel.Text = "Napoleon.Model";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(224, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "文件命名空间：";
            // 
            // TxtNhMapping
            // 
            this.TxtNhMapping.Location = new System.Drawing.Point(322, 7);
            this.TxtNhMapping.Name = "TxtNhMapping";
            this.TxtNhMapping.Size = new System.Drawing.Size(179, 22);
            this.TxtNhMapping.TabIndex = 3;
            this.TxtNhMapping.Text = "Napoleon.Model.Mapping";
            // 
            // RadNhMapping
            // 
            this.RadNhMapping.AutoSize = true;
            this.RadNhMapping.Location = new System.Drawing.Point(68, 10);
            this.RadNhMapping.Name = "RadNhMapping";
            this.RadNhMapping.Size = new System.Drawing.Size(73, 18);
            this.RadNhMapping.TabIndex = 2;
            this.RadNhMapping.TabStop = true;
            this.RadNhMapping.Text = "映射文件";
            this.RadNhMapping.UseVisualStyleBackColor = true;
            this.RadNhMapping.Click += new System.EventHandler(this.RadNhModel_Click);
            // 
            // RadNhXml
            // 
            this.RadNhXml.AutoSize = true;
            this.RadNhXml.Location = new System.Drawing.Point(147, 9);
            this.RadNhXml.Name = "RadNhXml";
            this.RadNhXml.Size = new System.Drawing.Size(73, 18);
            this.RadNhXml.TabIndex = 1;
            this.RadNhXml.TabStop = true;
            this.RadNhXml.Text = "配置文件";
            this.RadNhXml.UseVisualStyleBackColor = true;
            this.RadNhXml.Click += new System.EventHandler(this.RadNhModel_Click);
            // 
            // RadNhModel
            // 
            this.RadNhModel.AutoSize = true;
            this.RadNhModel.Location = new System.Drawing.Point(4, 9);
            this.RadNhModel.Name = "RadNhModel";
            this.RadNhModel.Size = new System.Drawing.Size(61, 18);
            this.RadNhModel.TabIndex = 0;
            this.RadNhModel.TabStop = true;
            this.RadNhModel.Text = "实体类";
            this.RadNhModel.UseVisualStyleBackColor = true;
            this.RadNhModel.Click += new System.EventHandler(this.RadNhModel_Click);
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.AllowFocus = false;
            this.BtnSubmit.Location = new System.Drawing.Point(1090, 21);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(59, 23);
            this.BtnSubmit.TabIndex = 8;
            this.BtnSubmit.Text = "生成";
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // PlAutofacTemp
            // 
            this.PlAutofacTemp.Controls.Add(this.RadAutofacXml);
            this.PlAutofacTemp.Location = new System.Drawing.Point(198, 14);
            this.PlAutofacTemp.Name = "PlAutofacTemp";
            this.PlAutofacTemp.Size = new System.Drawing.Size(793, 36);
            this.PlAutofacTemp.TabIndex = 6;
            // 
            // RadAutofacXml
            // 
            this.RadAutofacXml.AutoSize = true;
            this.RadAutofacXml.Location = new System.Drawing.Point(19, 9);
            this.RadAutofacXml.Name = "RadAutofacXml";
            this.RadAutofacXml.Size = new System.Drawing.Size(73, 18);
            this.RadAutofacXml.TabIndex = 0;
            this.RadAutofacXml.TabStop = true;
            this.RadAutofacXml.Text = "配置文件";
            this.RadAutofacXml.UseVisualStyleBackColor = true;
            this.RadAutofacXml.Click += new System.EventHandler(this.RadNhModel_Click);
            // 
            // CobSelectTemb
            // 
            this.CobSelectTemb.Location = new System.Drawing.Point(11, 21);
            this.CobSelectTemb.Name = "CobSelectTemb";
            this.CobSelectTemb.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CobSelectTemb.Properties.Items.AddRange(new object[] {
            "基本模版",
            "NHibernate模版",
            "AutoFac模版",
            "AutoFac+Dapper文件"});
            this.CobSelectTemb.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.CobSelectTemb.Size = new System.Drawing.Size(181, 20);
            this.CobSelectTemb.TabIndex = 7;
            this.CobSelectTemb.SelectedIndexChanged += new System.EventHandler(this.CobSelectTemb_SelectedIndexChanged);
            // 
            // PlBaseTemp
            // 
            this.PlBaseTemp.Controls.Add(this.RadBaseProcedure);
            this.PlBaseTemp.Controls.Add(this.RadBaseModel);
            this.PlBaseTemp.Controls.Add(this.RadBaseField);
            this.PlBaseTemp.Location = new System.Drawing.Point(198, 14);
            this.PlBaseTemp.Name = "PlBaseTemp";
            this.PlBaseTemp.Size = new System.Drawing.Size(793, 36);
            this.PlBaseTemp.TabIndex = 2;
            // 
            // simpleButton1
            // 
            this.simpleButton1.AllowFocus = false;
            this.simpleButton1.Location = new System.Drawing.Point(686, 7);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(59, 23);
            this.simpleButton1.TabIndex = 14;
            this.simpleButton1.Text = "浏览";
            // 
            // RadBaseProcedure
            // 
            this.RadBaseProcedure.AutoSize = true;
            this.RadBaseProcedure.Location = new System.Drawing.Point(199, 9);
            this.RadBaseProcedure.Name = "RadBaseProcedure";
            this.RadBaseProcedure.Size = new System.Drawing.Size(73, 18);
            this.RadBaseProcedure.TabIndex = 1;
            this.RadBaseProcedure.TabStop = true;
            this.RadBaseProcedure.Text = "存储过程";
            this.RadBaseProcedure.UseVisualStyleBackColor = true;
            this.RadBaseProcedure.Click += new System.EventHandler(this.RadNhModel_Click);
            // 
            // RadBaseModel
            // 
            this.RadBaseModel.AutoSize = true;
            this.RadBaseModel.Location = new System.Drawing.Point(110, 9);
            this.RadBaseModel.Name = "RadBaseModel";
            this.RadBaseModel.Size = new System.Drawing.Size(61, 18);
            this.RadBaseModel.TabIndex = 2;
            this.RadBaseModel.TabStop = true;
            this.RadBaseModel.Text = "实体类";
            this.RadBaseModel.UseVisualStyleBackColor = true;
            this.RadBaseModel.Click += new System.EventHandler(this.RadNhModel_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(308, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(53, 14);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "生成路径:";
            // 
            // RadBaseField
            // 
            this.RadBaseField.AutoSize = true;
            this.RadBaseField.Location = new System.Drawing.Point(29, 9);
            this.RadBaseField.Name = "RadBaseField";
            this.RadBaseField.Size = new System.Drawing.Size(49, 18);
            this.RadBaseField.TabIndex = 0;
            this.RadBaseField.TabStop = true;
            this.RadBaseField.Text = "字段";
            this.RadBaseField.UseVisualStyleBackColor = true;
            this.RadBaseField.Click += new System.EventHandler(this.RadNhModel_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(364, 9);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.ReadOnly = true;
            this.textEdit1.Size = new System.Drawing.Size(316, 20);
            this.textEdit1.TabIndex = 12;
            // 
            // MsSqlContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1603, 798);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MsSqlContent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MSSQL动态模版";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CodeForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.plAutoDapperTemp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtAutoDapper.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrowser.Properties)).EndInit();
            this.PlNhTemp.ResumeLayout(false);
            this.PlNhTemp.PerformLayout();
            this.PlAutofacTemp.ResumeLayout(false);
            this.PlAutofacTemp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CobSelectTemb.Properties)).EndInit();
            this.PlBaseTemp.ResumeLayout(false);
            this.PlBaseTemp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TreeView TreeDataBase;
        private GroupBox groupBox2;
        private ImageList imageList1;
        private Panel PlBaseTemp;
        private RadioButton RadBaseProcedure;
        private RadioButton RadBaseModel;
        private Panel PlNhTemp;
        private RadioButton RadNhXml;
        private RadioButton RadNhModel;
        private RadioButton RadBaseField;
        private RadioButton RadNhMapping;
        private TextBox TxtNhMapping;
        private Label label1;
        private Label label2;
        private TextBox TxtNhModel;
        private RichTextBox RtxtContent;
        private Panel PlAutofacTemp;
        private RadioButton RadAutofacXml;
        private DevExpress.XtraEditors.ComboBoxEdit CobSelectTemb;
        private DevExpress.XtraEditors.SimpleButton BtnReturn;
        private DevExpress.XtraEditors.SimpleButton BtnSubmit;
        private Panel plAutoDapperTemp;
        private DevExpress.XtraEditors.SimpleButton BtnBrowser;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtBrowser;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtAutoDapper;
        private DevExpress.XtraEditors.SimpleButton BtnExport;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEdit1;
    }
}