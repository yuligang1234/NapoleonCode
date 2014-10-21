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
            // SelectDbForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 372);
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
    }
}