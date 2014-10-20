namespace NapoleonCode.Win
{
    partial class StaticForm
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
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("文本配置", 1, 2);
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("文本Helper", 1, 2);
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("数据库配置", 1, 2);
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("数据库Helper", 1, 2);
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Log4模版", 1, 2, new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("扩展方法");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("模版树", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaticForm));
            this.TreeStaticTemp = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RtbContent = new System.Windows.Forms.RichTextBox();
            this.BtnSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.BtnReturn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TreeStaticTemp
            // 
            this.TreeStaticTemp.ImageIndex = 1;
            this.TreeStaticTemp.ImageList = this.imageList1;
            this.TreeStaticTemp.ImeMode = System.Windows.Forms.ImeMode.On;
            this.TreeStaticTemp.Location = new System.Drawing.Point(7, 23);
            this.TreeStaticTemp.Name = "TreeStaticTemp";
            treeNode8.ImageIndex = 1;
            treeNode8.Name = "TxtConfing";
            treeNode8.SelectedImageIndex = 2;
            treeNode8.Text = "文本配置";
            treeNode9.ImageIndex = 1;
            treeNode9.Name = "TxtHelper";
            treeNode9.SelectedImageIndex = 2;
            treeNode9.Text = "文本Helper";
            treeNode10.ImageIndex = 1;
            treeNode10.Name = "DbConfing";
            treeNode10.SelectedImageIndex = 2;
            treeNode10.Text = "数据库配置";
            treeNode11.ImageIndex = 1;
            treeNode11.Name = "DbHelper";
            treeNode11.SelectedImageIndex = 2;
            treeNode11.Text = "数据库Helper";
            treeNode12.ImageIndex = 1;
            treeNode12.Name = "Log4Confing";
            treeNode12.SelectedImageIndex = 2;
            treeNode12.Text = "Log4模版";
            treeNode13.Name = "ExpandFunc";
            treeNode13.Text = "扩展方法";
            treeNode14.ImageIndex = 1;
            treeNode14.Name = "BaseTemp";
            treeNode14.SelectedImageIndex = 1;
            treeNode14.Text = "模版树";
            this.TreeStaticTemp.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode14});
            this.TreeStaticTemp.SelectedImageIndex = 1;
            this.TreeStaticTemp.Size = new System.Drawing.Size(341, 713);
            this.TreeStaticTemp.TabIndex = 0;
            this.TreeStaticTemp.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeStaticTemp_NodeMouseDoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder_stroke.png");
            this.imageList1.Images.SetKeyName(1, "folder-close.png");
            this.imageList1.Images.SetKeyName(2, "folder-open.png");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TreeStaticTemp);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 744);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "模版节点";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelControl1);
            this.groupBox2.Controls.Add(this.BtnReturn);
            this.groupBox2.Controls.Add(this.BtnSubmit);
            this.groupBox2.Controls.Add(this.RtbContent);
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(388, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1095, 744);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "代码生成";
            // 
            // RtbContent
            // 
            this.RtbContent.Location = new System.Drawing.Point(9, 48);
            this.RtbContent.Name = "RtbContent";
            this.RtbContent.Size = new System.Drawing.Size(1078, 689);
            this.RtbContent.TabIndex = 2;
            this.RtbContent.Text = "";
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.AllowFocus = false;
            this.BtnSubmit.Location = new System.Drawing.Point(753, 17);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(64, 23);
            this.BtnSubmit.TabIndex = 5;
            this.BtnSubmit.Text = "生成";
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // BtnReturn
            // 
            this.BtnReturn.AllowFocus = false;
            this.BtnReturn.Location = new System.Drawing.Point(851, 17);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(64, 23);
            this.BtnReturn.TabIndex = 6;
            this.BtnReturn.Text = "返回";
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(101, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(631, 25);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "在左侧的模版树中双击选择相应的模版，并点击右侧的生成按钮来生成需要的代码";
            // 
            // StaticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1498, 772);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StaticForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "静态模版";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CodeForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView TreeStaticTemp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox RtbContent;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.SimpleButton BtnReturn;
        private DevExpress.XtraEditors.SimpleButton BtnSubmit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}