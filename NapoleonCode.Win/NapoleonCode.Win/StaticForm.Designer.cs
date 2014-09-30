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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("文本配置", 1, 2);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("文本Helper", 1, 2);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("数据库配置", 1, 2);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("数据库Helper", 1, 2);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Log4模版", 1, 2, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("扩展方法");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("模版树", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaticForm));
            this.TreeStaticTemp = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.RtbContent = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TreeStaticTemp
            // 
            this.TreeStaticTemp.ImageIndex = 1;
            this.TreeStaticTemp.ImageList = this.imageList1;
            this.TreeStaticTemp.ImeMode = System.Windows.Forms.ImeMode.On;
            this.TreeStaticTemp.Location = new System.Drawing.Point(6, 20);
            this.TreeStaticTemp.Name = "TreeStaticTemp";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "TxtConfing";
            treeNode1.SelectedImageIndex = 2;
            treeNode1.Text = "文本配置";
            treeNode2.ImageIndex = 1;
            treeNode2.Name = "TxtHelper";
            treeNode2.SelectedImageIndex = 2;
            treeNode2.Text = "文本Helper";
            treeNode3.ImageIndex = 1;
            treeNode3.Name = "DbConfing";
            treeNode3.SelectedImageIndex = 2;
            treeNode3.Text = "数据库配置";
            treeNode4.ImageIndex = 1;
            treeNode4.Name = "DbHelper";
            treeNode4.SelectedImageIndex = 2;
            treeNode4.Text = "数据库Helper";
            treeNode5.ImageIndex = 1;
            treeNode5.Name = "Log4Confing";
            treeNode5.SelectedImageIndex = 2;
            treeNode5.Text = "Log4模版";
            treeNode6.Name = "ExpandFunc";
            treeNode6.Text = "扩展方法";
            treeNode7.ImageIndex = 1;
            treeNode7.Name = "BaseTemp";
            treeNode7.SelectedImageIndex = 1;
            treeNode7.Text = "模版树";
            this.TreeStaticTemp.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7});
            this.TreeStaticTemp.Nodes[0].Expand();
            this.TreeStaticTemp.SelectedImageIndex = 1;
            this.TreeStaticTemp.Size = new System.Drawing.Size(293, 612);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 638);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "模版节点";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnReturn);
            this.groupBox2.Controls.Add(this.BtnSubmit);
            this.groupBox2.Controls.Add(this.RtbContent);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(333, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(939, 638);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "代码生成";
            // 
            // BtnReturn
            // 
            this.BtnReturn.ForeColor = System.Drawing.Color.Black;
            this.BtnReturn.Location = new System.Drawing.Point(709, 13);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(52, 23);
            this.BtnReturn.TabIndex = 4;
            this.BtnReturn.Text = "返回";
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.ForeColor = System.Drawing.Color.Black;
            this.BtnSubmit.Location = new System.Drawing.Point(628, 13);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(55, 23);
            this.BtnSubmit.TabIndex = 3;
            this.BtnSubmit.Text = "生成";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // RtbContent
            // 
            this.RtbContent.Location = new System.Drawing.Point(8, 41);
            this.RtbContent.Name = "RtbContent";
            this.RtbContent.Size = new System.Drawing.Size(925, 591);
            this.RtbContent.TabIndex = 2;
            this.RtbContent.Text = "";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(63, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "在左侧的模版树中双击选择相应的模版，并点击右侧的生成按钮来生成需要的代码";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StaticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 662);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.RichTextBox RtbContent;
        private System.Windows.Forms.ImageList imageList1;
    }
}