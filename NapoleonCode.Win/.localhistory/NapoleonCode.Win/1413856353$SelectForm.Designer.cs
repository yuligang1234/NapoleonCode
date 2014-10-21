namespace NapoleonCode.Win
{
    partial class SelectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectForm));
            this.BtnStaticConfing = new DevExpress.XtraEditors.SimpleButton();
            this.BtnMovingConfing = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // BtnStaticConfing
            // 
            this.BtnStaticConfing.AllowFocus = false;
            this.BtnStaticConfing.Location = new System.Drawing.Point(100, 74);
            this.BtnStaticConfing.Name = "BtnStaticConfing";
            this.BtnStaticConfing.Size = new System.Drawing.Size(113, 23);
            this.BtnStaticConfing.TabIndex = 11;
            this.BtnStaticConfing.Text = "静态配置";
            this.BtnStaticConfing.Click += new System.EventHandler(this.BtnStaticConfing_Click);
            // 
            // BtnMovingConfing
            // 
            this.BtnMovingConfing.AllowFocus = false;
            this.BtnMovingConfing.Location = new System.Drawing.Point(100, 170);
            this.BtnMovingConfing.Name = "BtnMovingConfing";
            this.BtnMovingConfing.Size = new System.Drawing.Size(113, 23);
            this.BtnMovingConfing.TabIndex = 12;
            this.BtnMovingConfing.Text = "动态配置";
            this.BtnMovingConfing.Click += new System.EventHandler(this.BtnMovingConfing_Click);
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 306);
            this.Controls.Add(this.BtnMovingConfing);
            this.Controls.Add(this.BtnStaticConfing);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "McSkin";
            this.MaximizeBox = false;
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "配置选择";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CodeForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnStaticConfing;
        private DevExpress.XtraEditors.SimpleButton BtnMovingConfing;

    }
}