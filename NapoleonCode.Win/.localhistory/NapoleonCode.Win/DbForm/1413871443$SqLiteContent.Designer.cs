namespace NapoleonCode.Win.DbForm
{
    partial class SqLiteContent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqLiteContent));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.TreeDataBase = new System.Windows.Forms.TreeView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.RtxtContent = new System.Windows.Forms.RichTextBox();
            this.BtnReturn = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.PlBaseTemp = new System.Windows.Forms.Panel();
            this.RadBaseModel = new System.Windows.Forms.RadioButton();
            this.CobSelectTemb = new DevExpress.XtraEditors.ComboBoxEdit();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.PlBaseTemp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CobSelectTemb.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.TreeDataBase);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(319, 774);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "数据库表(双击加载)";
            // 
            // TreeDataBase
            // 
            this.TreeDataBase.AllowDrop = true;
            this.TreeDataBase.Location = new System.Drawing.Point(5, 25);
            this.TreeDataBase.Name = "TreeDataBase";
            this.TreeDataBase.Size = new System.Drawing.Size(308, 744);
            this.TreeDataBase.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.RtxtContent);
            this.groupControl2.Controls.Add(this.BtnReturn);
            this.groupControl2.Controls.Add(this.BtnSubmit);
            this.groupControl2.Controls.Add(this.PlBaseTemp);
            this.groupControl2.Controls.Add(this.CobSelectTemb);
            this.groupControl2.Location = new System.Drawing.Point(337, 13);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(935, 773);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "生成代码";
            // 
            // RtxtContent
            // 
            this.RtxtContent.Location = new System.Drawing.Point(5, 64);
            this.RtxtContent.Name = "RtxtContent";
            this.RtxtContent.Size = new System.Drawing.Size(925, 704);
            this.RtxtContent.TabIndex = 12;
            this.RtxtContent.Text = "";
            // 
            // BtnReturn
            // 
            this.BtnReturn.AllowFocus = false;
            this.BtnReturn.Location = new System.Drawing.Point(861, 31);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(59, 23);
            this.BtnReturn.TabIndex = 11;
            this.BtnReturn.Text = "返回";
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.AllowFocus = false;
            this.BtnSubmit.Location = new System.Drawing.Point(794, 31);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(59, 23);
            this.BtnSubmit.TabIndex = 10;
            this.BtnSubmit.Text = "生成";
            // 
            // PlBaseTemp
            // 
            this.PlBaseTemp.Controls.Add(this.RadBaseModel);
            this.PlBaseTemp.Location = new System.Drawing.Point(192, 29);
            this.PlBaseTemp.Name = "PlBaseTemp";
            this.PlBaseTemp.Size = new System.Drawing.Size(596, 29);
            this.PlBaseTemp.TabIndex = 9;
            // 
            // RadBaseModel
            // 
            this.RadBaseModel.AutoSize = true;
            this.RadBaseModel.Location = new System.Drawing.Point(19, 5);
            this.RadBaseModel.Name = "RadBaseModel";
            this.RadBaseModel.Size = new System.Drawing.Size(61, 18);
            this.RadBaseModel.TabIndex = 0;
            this.RadBaseModel.TabStop = true;
            this.RadBaseModel.Text = "实体类";
            this.RadBaseModel.UseVisualStyleBackColor = true;
            // 
            // CobSelectTemb
            // 
            this.CobSelectTemb.Location = new System.Drawing.Point(5, 34);
            this.CobSelectTemb.Name = "CobSelectTemb";
            this.CobSelectTemb.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CobSelectTemb.Properties.Items.AddRange(new object[] {
            "基本模版"});
            this.CobSelectTemb.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.CobSelectTemb.Size = new System.Drawing.Size(181, 20);
            this.CobSelectTemb.TabIndex = 8;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "database.png");
            this.imageList1.Images.SetKeyName(1, "database_accept.png");
            this.imageList1.Images.SetKeyName(2, "database_add.png");
            // 
            // SqLiteContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 798);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SqLiteContent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "动态模版";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SqLiteContent_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.PlBaseTemp.ResumeLayout(false);
            this.PlBaseTemp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CobSelectTemb.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.TreeView TreeDataBase;
        private DevExpress.XtraEditors.ComboBoxEdit CobSelectTemb;
        private System.Windows.Forms.Panel PlBaseTemp;
        private System.Windows.Forms.RadioButton RadBaseModel;
        private DevExpress.XtraEditors.SimpleButton BtnReturn;
        private DevExpress.XtraEditors.SimpleButton BtnSubmit;
        private System.Windows.Forms.RichTextBox RtxtContent;
        private System.Windows.Forms.ImageList imageList1;
    }
}