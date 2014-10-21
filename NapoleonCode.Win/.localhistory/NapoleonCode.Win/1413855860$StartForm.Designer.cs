﻿namespace NapoleonCode.Win
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.LblDataBase = new System.Windows.Forms.Label();
            this.LblBrowse = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DropDataBase = new DevExpress.XtraEditors.ComboBoxEdit();
            this.TxtBrowse = new DevExpress.XtraEditors.TextEdit();
            this.TxtUserName = new DevExpress.XtraEditors.TextEdit();
            this.TxtPassWord = new DevExpress.XtraEditors.TextEdit();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.BtnRun = new DevExpress.XtraEditors.SimpleButton();
            this.BtnReturn = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnBrowser = new DevExpress.XtraEditors.SimpleButton();
            this.TxtDbUrl = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.DropDataBase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBrowse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPassWord.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDbUrl.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LblDataBase
            // 
            this.LblDataBase.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblDataBase.Location = new System.Drawing.Point(23, 47);
            this.LblDataBase.Name = "LblDataBase";
            this.LblDataBase.Size = new System.Drawing.Size(110, 22);
            this.LblDataBase.TabIndex = 0;
            this.LblDataBase.Text = "数　据　库：";
            this.LblDataBase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblBrowse
            // 
            this.LblBrowse.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblBrowse.Location = new System.Drawing.Point(13, 106);
            this.LblBrowse.Name = "LblBrowse";
            this.LblBrowse.Size = new System.Drawing.Size(120, 22);
            this.LblBrowse.TabIndex = 2;
            this.LblBrowse.Text = "服务器名称：";
            this.LblBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(16, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "登　录　名：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(20, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "密　　　码：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DropDataBase
            // 
            this.DropDataBase.Location = new System.Drawing.Point(139, 49);
            this.DropDataBase.Name = "DropDataBase";
            this.DropDataBase.Properties.AllowFocused = false;
            this.DropDataBase.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DropDataBase.Properties.Items.AddRange(new object[] {
            "MSSQL",
            "SQLite"});
            this.DropDataBase.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            this.DropDataBase.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.DropDataBase.Size = new System.Drawing.Size(168, 20);
            this.DropDataBase.TabIndex = 12;
            this.DropDataBase.SelectedIndexChanged += new System.EventHandler(this.DropDataBase_SelectedIndexChanged);
            // 
            // TxtBrowse
            // 
            this.TxtBrowse.Location = new System.Drawing.Point(139, 106);
            this.TxtBrowse.Name = "TxtBrowse";
            this.TxtBrowse.Size = new System.Drawing.Size(167, 20);
            this.TxtBrowse.TabIndex = 13;
            // 
            // TxtUserName
            // 
            this.TxtUserName.Location = new System.Drawing.Point(139, 172);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(167, 20);
            this.TxtUserName.TabIndex = 14;
            // 
            // TxtPassWord
            // 
            this.TxtPassWord.Location = new System.Drawing.Point(139, 235);
            this.TxtPassWord.Name = "TxtPassWord";
            this.TxtPassWord.Size = new System.Drawing.Size(167, 20);
            this.TxtPassWord.TabIndex = 15;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(28, 303);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 16;
            this.BtnSave.Text = "保存";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnRun
            // 
            this.BtnRun.Location = new System.Drawing.Point(133, 303);
            this.BtnRun.Name = "BtnRun";
            this.BtnRun.Size = new System.Drawing.Size(75, 23);
            this.BtnRun.TabIndex = 17;
            this.BtnRun.Text = "运行";
            this.BtnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // BtnReturn
            // 
            this.BtnReturn.Location = new System.Drawing.Point(234, 303);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(75, 23);
            this.BtnReturn.TabIndex = 18;
            this.BtnReturn.Text = "返回";
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(25, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 22);
            this.label5.TabIndex = 19;
            this.label5.Text = "文件路径：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnBrowser
            // 
            this.BtnBrowser.Location = new System.Drawing.Point(231, 139);
            this.BtnBrowser.Name = "BtnBrowser";
            this.BtnBrowser.Size = new System.Drawing.Size(75, 23);
            this.BtnBrowser.TabIndex = 20;
            this.BtnBrowser.Text = "浏览";
            // 
            // TxtDbUrl
            // 
            this.TxtDbUrl.Location = new System.Drawing.Point(28, 198);
            this.TxtDbUrl.Name = "TxtDbUrl";
            this.TxtDbUrl.Size = new System.Drawing.Size(278, 20);
            this.TxtDbUrl.TabIndex = 21;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 372);
            this.Controls.Add(this.TxtDbUrl);
            this.Controls.Add(this.BtnBrowser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.BtnRun);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtPassWord);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.TxtBrowse);
            this.Controls.Add(this.DropDataBase);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblBrowse);
            this.Controls.Add(this.LblDataBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据库登录";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CodeForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.DropDataBase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBrowse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPassWord.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDbUrl.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblDataBase;
        private System.Windows.Forms.Label LblBrowse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.ComboBoxEdit DropDataBase;
        private DevExpress.XtraEditors.TextEdit TxtBrowse;
        private DevExpress.XtraEditors.TextEdit TxtUserName;
        private DevExpress.XtraEditors.TextEdit TxtPassWord;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraEditors.SimpleButton BtnRun;
        private DevExpress.XtraEditors.SimpleButton BtnReturn;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton BtnBrowser;
        private DevExpress.XtraEditors.TextEdit TxtDbUrl;
    }
}