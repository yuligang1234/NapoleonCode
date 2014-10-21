namespace NapoleonCode.Win
{
    partial class SelectDbForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectDbForm));
            this.RadSelectDb = new DevExpress.XtraEditors.RadioGroup();
            this.BtnReturn = new DevExpress.XtraEditors.SimpleButton();
            this.BtnRun = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.RadSelectDb.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // RadSelectDb
            // 
            this.RadSelectDb.Location = new System.Drawing.Point(30, 27);
            this.RadSelectDb.Name = "RadSelectDb";
            this.RadSelectDb.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "SQLServer"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "SQLite"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Oracle"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "MySQL")});
            this.RadSelectDb.Size = new System.Drawing.Size(272, 203);
            this.RadSelectDb.TabIndex = 0;
            // 
            // BtnReturn
            // 
            this.BtnReturn.Location = new System.Drawing.Point(227, 303);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(75, 23);
            this.BtnReturn.TabIndex = 20;
            this.BtnReturn.Text = "返回";
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // BtnRun
            // 
            this.BtnRun.Location = new System.Drawing.Point(30, 303);
            this.BtnRun.Name = "BtnRun";
            this.BtnRun.Size = new System.Drawing.Size(75, 23);
            this.BtnRun.TabIndex = 19;
            this.BtnRun.Text = "运行";
            this.BtnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // SelectDbForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 372);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.BtnRun);
            this.Controls.Add(this.RadSelectDb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SelectDbForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择数据库";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SelectDbForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.RadSelectDb.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.RadioGroup RadSelectDb;
        private DevExpress.XtraEditors.SimpleButton BtnReturn;
        private DevExpress.XtraEditors.SimpleButton BtnRun;
    }
}