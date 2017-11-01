namespace EZLibTests
{
    partial class licenseForm
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
            this.labelEZLib = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.textLicense = new System.Windows.Forms.TextBox();
            this.labelLicense = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEZLib
            // 
            this.labelEZLib.AutoSize = true;
            this.labelEZLib.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEZLib.Location = new System.Drawing.Point(177, 9);
            this.labelEZLib.Name = "labelEZLib";
            this.labelEZLib.Size = new System.Drawing.Size(58, 25);
            this.labelEZLib.TabIndex = 12;
            this.labelEZLib.Text = "EZLib";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(38, 41);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(336, 13);
            this.labelMessage.TabIndex = 13;
            this.labelMessage.Text = "Please enter  the license key given to you so it may be registered";
            // 
            // textLicense
            // 
            this.textLicense.Location = new System.Drawing.Point(92, 87);
            this.textLicense.Name = "textLicense";
            this.textLicense.Size = new System.Drawing.Size(228, 22);
            this.textLicense.TabIndex = 14;
            this.textLicense.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelLicense
            // 
            this.labelLicense.AutoSize = true;
            this.labelLicense.Location = new System.Drawing.Point(89, 71);
            this.labelLicense.Name = "labelLicense";
            this.labelLicense.Size = new System.Drawing.Size(64, 13);
            this.labelLicense.TabIndex = 15;
            this.labelLicense.Text = "License Key";
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(139, 115);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(134, 23);
            this.buttonRegister.TabIndex = 16;
            this.buttonRegister.Text = "Register License Key";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // licenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 152);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.labelLicense);
            this.Controls.Add(this.textLicense);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.labelEZLib);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "licenseForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EZLibTests";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.licenseForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEZLib;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.TextBox textLicense;
        private System.Windows.Forms.Label labelLicense;
        private System.Windows.Forms.Button buttonRegister;
    }
}