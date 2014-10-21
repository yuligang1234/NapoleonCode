using System.Windows.Forms;

namespace NapoleonCode.Win
{
    partial class ContentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContentForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TreeDataBase = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnReturn = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.CobSelectTemb = new DevExpress.XtraEditors.ComboBoxEdit();
            this.PlAutofacTemp = new System.Windows.Forms.Panel();
            this.RadAutofacXml = new System.Windows.Forms.RadioButton();
            this.RtxtContent = new System.Windows.Forms.RichTextBox();
            this.PlNhTemp = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNhModel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNhMapping = new System.Windows.Forms.TextBox();
            this.RadNhMapping = new System.Windows.Forms.RadioButton();
            this.RadNhXml = new System.Windows.Forms.RadioButton();
            this.RadNhModel = new System.Windows.Forms.RadioButton();
            this.PlBaseTemp = new System.Windows.Forms.Panel();
            this.RadBaseProcedure = new System.Windows.Forms.RadioButton();
            this.RadBaseModel = new System.Windows.Forms.RadioButton();
            this.RadBaseField = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CobSelectTemb.Properties)).BeginInit();
            this.PlAutofacTemp.SuspendLayout();
            this.PlNhTemp.SuspendLayout();
            this.PlBaseTemp.SuspendLayout();
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
            this.groupBox2.Controls.Add(this.BtnReturn);
            this.groupBox2.Controls.Add(this.BtnSubmit);
            this.groupBox2.Controls.Add(this.CobSelectTemb);
            this.groupBox2.Controls.Add(this.PlAutofacTemp);
            this.groupBox2.Controls.Add(this.RtxtContent);
            this.groupBox2.Controls.Add(this.PlNhTemp);
            this.groupBox2.Controls.Add(this.PlBaseTemp);
            this.groupBox2.Location = new System.Drawing.Point(372, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1225, 770);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "生成代码";
            // 
            // BtnReturn
            // 
            this.BtnReturn.Location = new System.Drawing.Point(1157, 21);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(59, 23);
            this.BtnReturn.TabIndex = 9;
            this.BtnReturn.Text = "返回";
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(1090, 21);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(59, 23);
            this.BtnSubmit.TabIndex = 8;
            this.BtnSubmit.Text = "生成";
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // CobSelectTemb
            // 
            this.CobSelectTemb.Location = new System.Drawing.Point(11, 27);
            this.CobSelectTemb.Name = "CobSelectTemb";
            this.CobSelectTemb.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CobSelectTemb.Properties.Items.AddRange(new object[] {
            "基本模版",
            "NHibernate模版",
            "AutoFac模版"});
            this.CobSelectTemb.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.CobSelectTemb.Size = new System.Drawing.Size(181, 20);
            this.CobSelectTemb.TabIndex = 7;
            this.CobSelectTemb.SelectedIndexChanged += new System.EventHandler(this.CobSelectTemb_SelectedIndexChanged);
            // 
            // PlAutofacTemp
            // 
            this.PlAutofacTemp.Controls.Add(this.RadAutofacXml);
            this.PlAutofacTemp.Location = new System.Drawing.Point(198, 19);
            this.PlAutofacTemp.Name = "PlAutofacTemp";
            this.PlAutofacTemp.Size = new System.Drawing.Size(882, 36);
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
            // RtxtContent
            // 
            this.RtxtContent.Location = new System.Drawing.Point(8, 62);
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
            this.PlNhTemp.Location = new System.Drawing.Point(198, 15);
            this.PlNhTemp.Name = "PlNhTemp";
            this.PlNhTemp.Size = new System.Drawing.Size(881, 36);
            this.PlNhTemp.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(650, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "类命名空间：";
            // 
            // TxtNhModel
            // 
            this.TxtNhModel.Location = new System.Drawing.Point(747, 7);
            this.TxtNhModel.Name = "TxtNhModel";
            this.TxtNhModel.Size = new System.Drawing.Size(122, 22);
            this.TxtNhModel.TabIndex = 5;
            this.TxtNhModel.Text = "Napoleon.Model";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(302, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "文件命名空间：";
            // 
            // TxtNhMapping
            // 
            this.TxtNhMapping.Location = new System.Drawing.Point(418, 7);
            this.TxtNhMapping.Name = "TxtNhMapping";
            this.TxtNhMapping.Size = new System.Drawing.Size(216, 22);
            this.TxtNhMapping.TabIndex = 3;
            this.TxtNhMapping.Text = "Napoleon.Model.Mapping";
            // 
            // RadNhMapping
            // 
            this.RadNhMapping.AutoSize = true;
            this.RadNhMapping.Location = new System.Drawing.Point(105, 9);
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
            this.RadNhXml.Location = new System.Drawing.Point(209, 9);
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
            this.RadNhModel.Location = new System.Drawing.Point(20, 9);
            this.RadNhModel.Name = "RadNhModel";
            this.RadNhModel.Size = new System.Drawing.Size(61, 18);
            this.RadNhModel.TabIndex = 0;
            this.RadNhModel.TabStop = true;
            this.RadNhModel.Text = "实体类";
            this.RadNhModel.UseVisualStyleBackColor = true;
            this.RadNhModel.Click += new System.EventHandler(this.RadNhModel_Click);
            // 
            // PlBaseTemp
            // 
            this.PlBaseTemp.Controls.Add(this.RadBaseProcedure);
            this.PlBaseTemp.Controls.Add(this.RadBaseModel);
            this.PlBaseTemp.Controls.Add(this.RadBaseField);
            this.PlBaseTemp.Location = new System.Drawing.Point(198, 19);
            this.PlBaseTemp.Name = "PlBaseTemp";
            this.PlBaseTemp.Size = new System.Drawing.Size(881, 36);
            this.PlBaseTemp.TabIndex = 2;
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
            // ContentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1603, 798);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ContentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MSSQL动态模版";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CodeForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CobSelectTemb.Properties)).EndInit();
            this.PlAutofacTemp.ResumeLayout(false);
            this.PlAutofacTemp.PerformLayout();
            this.PlNhTemp.ResumeLayout(false);
            this.PlNhTemp.PerformLayout();
            this.PlBaseTemp.ResumeLayout(false);
            this.PlBaseTemp.PerformLayout();
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
    }
}