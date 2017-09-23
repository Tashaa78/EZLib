namespace EZLib.UserControls
{
    partial class loginControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginControl));
            this.panel_Control = new System.Windows.Forms.Panel();
            this.button_Close = new System.Windows.Forms.Panel();
            this.label_EZLib = new System.Windows.Forms.Label();
            this.button_Login = new Bunifu.Framework.UI.BunifuFlatButton();
            this.box_Username = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.box_Password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel_Status = new System.Windows.Forms.Panel();
            this.label_Status = new System.Windows.Forms.Label();
            this.button_Register = new System.Windows.Forms.Label();
            this.panel_Control.SuspendLayout();
            this.panel_Status.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Control
            // 
            this.panel_Control.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel_Control.Controls.Add(this.button_Close);
            this.panel_Control.Controls.Add(this.label_EZLib);
            this.panel_Control.ForeColor = System.Drawing.Color.Transparent;
            this.panel_Control.Location = new System.Drawing.Point(0, 0);
            this.panel_Control.Name = "panel_Control";
            this.panel_Control.Size = new System.Drawing.Size(442, 34);
            this.panel_Control.TabIndex = 2;
            // 
            // button_Close
            // 
            this.button_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Close.BackgroundImage")));
            this.button_Close.Location = new System.Drawing.Point(410, 5);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(24, 24);
            this.button_Close.TabIndex = 3;
            this.button_Close.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_Close_MouseClick);
            // 
            // label_EZLib
            // 
            this.label_EZLib.AutoSize = true;
            this.label_EZLib.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_EZLib.Location = new System.Drawing.Point(3, 8);
            this.label_EZLib.Name = "label_EZLib";
            this.label_EZLib.Size = new System.Drawing.Size(48, 18);
            this.label_EZLib.TabIndex = 3;
            this.label_EZLib.Text = "EZLib";
            // 
            // button_Login
            // 
            this.button_Login.Activecolor = System.Drawing.SystemColors.Highlight;
            this.button_Login.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Login.BorderRadius = 0;
            this.button_Login.ButtonText = "Sign In";
            this.button_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Login.DisabledColor = System.Drawing.Color.Gray;
            this.button_Login.Iconcolor = System.Drawing.Color.Transparent;
            this.button_Login.Iconimage = ((System.Drawing.Image)(resources.GetObject("button_Login.Iconimage")));
            this.button_Login.Iconimage_right = null;
            this.button_Login.Iconimage_right_Selected = null;
            this.button_Login.Iconimage_Selected = null;
            this.button_Login.IconMarginLeft = 0;
            this.button_Login.IconMarginRight = 0;
            this.button_Login.IconRightVisible = true;
            this.button_Login.IconRightZoom = 0D;
            this.button_Login.IconVisible = true;
            this.button_Login.IconZoom = 90D;
            this.button_Login.IsTab = false;
            this.button_Login.Location = new System.Drawing.Point(244, 168);
            this.button_Login.Name = "button_Login";
            this.button_Login.Normalcolor = System.Drawing.SystemColors.Highlight;
            this.button_Login.OnHovercolor = System.Drawing.SystemColors.HotTrack;
            this.button_Login.OnHoverTextColor = System.Drawing.Color.White;
            this.button_Login.selected = false;
            this.button_Login.Size = new System.Drawing.Size(135, 37);
            this.button_Login.TabIndex = 3;
            this.button_Login.Text = "Sign In";
            this.button_Login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Login.Textcolor = System.Drawing.Color.White;
            this.button_Login.TextFont = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // box_Username
            // 
            this.box_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.box_Username.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.box_Username.HintForeColor = System.Drawing.SystemColors.Highlight;
            this.box_Username.HintText = "Username";
            this.box_Username.isPassword = false;
            this.box_Username.LineFocusedColor = System.Drawing.SystemColors.HotTrack;
            this.box_Username.LineIdleColor = System.Drawing.Color.Gray;
            this.box_Username.LineMouseHoverColor = System.Drawing.SystemColors.Highlight;
            this.box_Username.LineThickness = 1;
            this.box_Username.Location = new System.Drawing.Point(77, 77);
            this.box_Username.Margin = new System.Windows.Forms.Padding(4);
            this.box_Username.Name = "box_Username";
            this.box_Username.Size = new System.Drawing.Size(302, 33);
            this.box_Username.TabIndex = 5;
            this.box_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // box_Password
            // 
            this.box_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.box_Password.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.box_Password.HintForeColor = System.Drawing.SystemColors.Highlight;
            this.box_Password.HintText = "Password";
            this.box_Password.isPassword = true;
            this.box_Password.LineFocusedColor = System.Drawing.SystemColors.HotTrack;
            this.box_Password.LineIdleColor = System.Drawing.Color.Gray;
            this.box_Password.LineMouseHoverColor = System.Drawing.SystemColors.Highlight;
            this.box_Password.LineThickness = 1;
            this.box_Password.Location = new System.Drawing.Point(77, 128);
            this.box_Password.Margin = new System.Windows.Forms.Padding(4);
            this.box_Password.Name = "box_Password";
            this.box_Password.Size = new System.Drawing.Size(302, 33);
            this.box_Password.TabIndex = 6;
            this.box_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel_Status
            // 
            this.panel_Status.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel_Status.Controls.Add(this.label_Status);
            this.panel_Status.ForeColor = System.Drawing.Color.Transparent;
            this.panel_Status.Location = new System.Drawing.Point(0, 244);
            this.panel_Status.Name = "panel_Status";
            this.panel_Status.Size = new System.Drawing.Size(442, 26);
            this.panel_Status.TabIndex = 4;
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Status.Location = new System.Drawing.Point(3, 7);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(79, 13);
            this.label_Status.TabIndex = 3;
            this.label_Status.Text = "Status: Idle";
            // 
            // button_Register
            // 
            this.button_Register.AutoSize = true;
            this.button_Register.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Register.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_Register.Location = new System.Drawing.Point(74, 178);
            this.button_Register.Name = "button_Register";
            this.button_Register.Size = new System.Drawing.Size(56, 15);
            this.button_Register.TabIndex = 4;
            this.button_Register.Text = "Sign Up";
            // 
            // loginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button_Register);
            this.Controls.Add(this.panel_Status);
            this.Controls.Add(this.box_Password);
            this.Controls.Add(this.box_Username);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.panel_Control);
            this.Name = "loginControl";
            this.Size = new System.Drawing.Size(442, 270);
            this.panel_Control.ResumeLayout(false);
            this.panel_Control.PerformLayout();
            this.panel_Status.ResumeLayout(false);
            this.panel_Status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Control;
        private System.Windows.Forms.Panel button_Close;
        private System.Windows.Forms.Label label_EZLib;
        private Bunifu.Framework.UI.BunifuFlatButton button_Login;
        private Bunifu.Framework.UI.BunifuMaterialTextbox box_Username;
        private Bunifu.Framework.UI.BunifuMaterialTextbox box_Password;
        private System.Windows.Forms.Panel panel_Status;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.Label button_Register;
    }
}
