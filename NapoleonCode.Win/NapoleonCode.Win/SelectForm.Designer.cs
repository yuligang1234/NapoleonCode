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
            this.BtnStaticConfing = new System.Windows.Forms.Button();
            this.BtnMovingConfing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnStaticConfing
            // 
            this.BtnStaticConfing.Location = new System.Drawing.Point(86, 67);
            this.BtnStaticConfing.Name = "BtnStaticConfing";
            this.BtnStaticConfing.Size = new System.Drawing.Size(97, 23);
            this.BtnStaticConfing.TabIndex = 9;
            this.BtnStaticConfing.Text = "静态配置";
            this.BtnStaticConfing.UseVisualStyleBackColor = true;
            this.BtnStaticConfing.Click += new System.EventHandler(this.BtnStaticConfing_Click);
            // 
            // BtnMovingConfing
            // 
            this.BtnMovingConfing.Location = new System.Drawing.Point(86, 140);
            this.BtnMovingConfing.Name = "BtnMovingConfing";
            this.BtnMovingConfing.Size = new System.Drawing.Size(97, 23);
            this.BtnMovingConfing.TabIndex = 10;
            this.BtnMovingConfing.Text = "动态配置";
            this.BtnMovingConfing.UseVisualStyleBackColor = true;
            this.BtnMovingConfing.Click += new System.EventHandler(this.BtnMovingConfing_Click);
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.BtnMovingConfing);
            this.Controls.Add(this.BtnStaticConfing);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "配置选择";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CodeForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnStaticConfing;
        private System.Windows.Forms.Button BtnMovingConfing;

    }
}