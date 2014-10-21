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
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.BtnReturn = new DevExpress.XtraEditors.SimpleButton();
            this.BtnRun = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(30, 27);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "SQLServer"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "SQLite"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Oracle"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "MySQL")});
            this.radioGroup1.Size = new System.Drawing.Size(272, 191);
            this.radioGroup1.TabIndex = 0;
            // 
            // BtnReturn
            // 
            this.BtnReturn.Location = new System.Drawing.Point(227, 280);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(75, 23);
            this.BtnReturn.TabIndex = 20;
            this.BtnReturn.Text = "返回";
            // 
            // BtnRun
            // 
            this.BtnRun.Location = new System.Drawing.Point(30, 280);
            this.BtnRun.Name = "BtnRun";
            this.BtnRun.Size = new System.Drawing.Size(75, 23);
            this.BtnRun.TabIndex = 19;
            this.BtnRun.Text = "运行";
            // 
            // SelectDbForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 372);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.BtnRun);
            this.Controls.Add(this.radioGroup1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SelectDbForm";
            this.Text = "选择数据库";
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraEditors.SimpleButton BtnReturn;
        private DevExpress.XtraEditors.SimpleButton BtnRun;
    }
}