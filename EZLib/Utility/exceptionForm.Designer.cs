namespace EZLib.Utility
{
    partial class exceptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(exceptionForm));
            this.controlBar = new System.Windows.Forms.Panel();
            this.controlTitle = new System.Windows.Forms.Label();
            this.textException = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.errorImage = new System.Windows.Forms.PictureBox();
            this.message = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.controlBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlBar
            // 
            this.controlBar.BackColor = System.Drawing.Color.Gainsboro;
            this.controlBar.Controls.Add(this.controlTitle);
            this.controlBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlBar.Location = new System.Drawing.Point(0, 0);
            this.controlBar.Name = "controlBar";
            this.controlBar.Size = new System.Drawing.Size(499, 34);
            this.controlBar.TabIndex = 0;
            // 
            // controlTitle
            // 
            this.controlTitle.AutoSize = true;
            this.controlTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlTitle.Location = new System.Drawing.Point(4, 7);
            this.controlTitle.Name = "controlTitle";
            this.controlTitle.Size = new System.Drawing.Size(48, 21);
            this.controlTitle.TabIndex = 5;
            this.controlTitle.Text = "EZLib";
            // 
            // textException
            // 
            this.textException.BackColor = System.Drawing.SystemColors.Control;
            this.textException.Location = new System.Drawing.Point(12, 100);
            this.textException.Multiline = true;
            this.textException.Name = "textException";
            this.textException.ReadOnly = true;
            this.textException.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textException.Size = new System.Drawing.Size(475, 141);
            this.textException.TabIndex = 1;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(375, 247);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(112, 23);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Close Application";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // errorImage
            // 
            this.errorImage.Image = ((System.Drawing.Image)(resources.GetObject("errorImage.Image")));
            this.errorImage.Location = new System.Drawing.Point(3, 3);
            this.errorImage.Name = "errorImage";
            this.errorImage.Size = new System.Drawing.Size(48, 48);
            this.errorImage.TabIndex = 3;
            this.errorImage.TabStop = false;
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(64, 21);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(391, 13);
            this.message.TabIndex = 4;
            this.message.Text = "The application has encountered an unexpected exception and must close.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.errorImage);
            this.panel1.Controls.Add(this.message);
            this.panel1.Location = new System.Drawing.Point(12, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 54);
            this.panel1.TabIndex = 5;
            // 
            // exceptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(499, 276);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.textException);
            this.Controls.Add(this.controlBar);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "exceptionForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EZLib";
            this.controlBar.ResumeLayout(false);
            this.controlBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel controlBar;
        private System.Windows.Forms.TextBox textException;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.PictureBox errorImage;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label controlTitle;
    }
}