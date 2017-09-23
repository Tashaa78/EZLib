namespace EZLib.UserControls.Alert_Messages
{
    partial class alertMessage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(alertMessage));
            this.icon = new System.Windows.Forms.PictureBox();
            this.label_Message = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // icon
            // 
            this.icon.BackColor = System.Drawing.Color.Transparent;
            this.icon.Image = ((System.Drawing.Image)(resources.GetObject("icon.Image")));
            this.icon.Location = new System.Drawing.Point(40, 22);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(50, 50);
            this.icon.TabIndex = 0;
            this.icon.TabStop = false;
            // 
            // label_Message
            // 
            this.label_Message.AutoSize = true;
            this.label_Message.BackColor = System.Drawing.Color.Transparent;
            this.label_Message.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Message.ForeColor = System.Drawing.Color.White;
            this.label_Message.Location = new System.Drawing.Point(113, 39);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(196, 17);
            this.label_Message.TabIndex = 1;
            this.label_Message.Text = "You have successfully registered";
            // 
            // alertMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.Controls.Add(this.label_Message);
            this.Controls.Add(this.icon);
            this.DoubleBuffered = true;
            this.Name = "alertMessage";
            this.Size = new System.Drawing.Size(363, 95);
            this.Load += new System.EventHandler(this.alertMessage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox icon;
        private Bunifu.Framework.UI.BunifuCustomLabel label_Message;
    }
}
