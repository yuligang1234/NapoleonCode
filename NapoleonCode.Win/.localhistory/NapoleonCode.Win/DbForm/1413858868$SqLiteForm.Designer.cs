namespace NapoleonCode.Win.DbForm
{
    partial class SqLiteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqLiteForm));
            this.TxtDbUrl = new DevExpress.XtraEditors.TextEdit();
            this.BtnBrowser = new DevExpress.XtraEditors.SimpleButton();
            this.LblDbUrl = new System.Windows.Forms.Label();
            this.BtnReturn = new DevExpress.XtraEditors.SimpleButton();
            this.BtnRun = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.TxtDataBase = new DevExpress.XtraEditors.TextEdit();
            this.LblDataBase = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDbUrl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDataBase.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtDbUrl
            // 
            this.TxtDbUrl.Location = new System.Drawing.Point(27, 173);
            this.TxtDbUrl.Name = "TxtDbUrl";
            this.TxtDbUrl.Size = new System.Drawing.Size(278, 20);
            this.TxtDbUrl.TabIndex = 27;
            this.TxtDbUrl.Visible = false;
            // 
            // BtnBrowser
            // 
            this.BtnBrowser.Location = new System.Drawing.Point(230, 114);
            this.BtnBrowser.Name = "BtnBrowser";
            this.BtnBrowser.Size = new System.Drawing.Size(75, 23);
            this.BtnBrowser.TabIndex = 26;
            this.BtnBrowser.Text = "浏览";
            this.BtnBrowser.Visible = false;
            // 
            // LblDbUrl
            // 
            this.LblDbUrl.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblDbUrl.Location = new System.Drawing.Point(24, 114);
            this.LblDbUrl.Name = "LblDbUrl";
            this.LblDbUrl.Size = new System.Drawing.Size(117, 22);
            this.LblDbUrl.TabIndex = 25;
            this.LblDbUrl.Text = "文件路径：";
            this.LblDbUrl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblDbUrl.Visible = false;
            // 
            // BtnReturn
            // 
            this.BtnReturn.Location = new System.Drawing.Point(232, 257);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(75, 23);
            this.BtnReturn.TabIndex = 24;
            this.BtnReturn.Text = "返回";
            // 
            // BtnRun
            // 
            this.BtnRun.Location = new System.Drawing.Point(131, 257);
            this.BtnRun.Name = "BtnRun";
            this.BtnRun.Size = new System.Drawing.Size(75, 23);
            this.BtnRun.TabIndex = 23;
            this.BtnRun.Text = "运行";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(26, 257);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 22;
            this.BtnSave.Text = "保存";
            // 
            // TxtDataBase
            // 
            this.TxtDataBase.Location = new System.Drawing.Point(140, 39);
            this.TxtDataBase.Name = "TxtDataBase";
            this.TxtDataBase.Properties.ReadOnly = true;
            this.TxtDataBase.Size = new System.Drawing.Size(167, 20);
            this.TxtDataBase.TabIndex = 29;
            // 
            // LblDataBase
            // 
            this.LblDataBase.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblDataBase.Location = new System.Drawing.Point(24, 37);
            this.LblDataBase.Name = "LblDataBase";
            this.LblDataBase.Size = new System.Drawing.Size(110, 22);
            this.LblDataBase.TabIndex = 28;
            this.LblDataBase.Text = "数　据　库：";
            this.LblDataBase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SqLiteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 372);
            this.Controls.Add(this.TxtDataBase);
            this.Controls.Add(this.LblDataBase);
            this.Controls.Add(this.TxtDbUrl);
            this.Controls.Add(this.BtnBrowser);
            this.Controls.Add(this.LblDbUrl);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.BtnRun);
            this.Controls.Add(this.BtnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SqLiteForm";
            this.Text = "SQLite数据库登录";
            ((System.ComponentModel.ISupportInitialize)(this.TxtDbUrl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDataBase.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit TxtDbUrl;
        private DevExpress.XtraEditors.SimpleButton BtnBrowser;
        private System.Windows.Forms.Label LblDbUrl;
        private DevExpress.XtraEditors.SimpleButton BtnReturn;
        private DevExpress.XtraEditors.SimpleButton BtnRun;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraEditors.TextEdit TxtDataBase;
        private System.Windows.Forms.Label LblDataBase;
    }
}