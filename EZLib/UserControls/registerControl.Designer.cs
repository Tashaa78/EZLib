namespace EZLib.UserControls
{
    partial class registerControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registerControl));
            this.icon = new System.Windows.Forms.PictureBox();
            this.box_Password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.box_Username = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button_Register = new Bunifu.Framework.UI.BunifuFlatButton();
            this.elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.captcha = new System.Windows.Forms.PictureBox();
            this.box_captcha = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.captcha)).BeginInit();
            this.SuspendLayout();
            // 
            // icon
            // 
            this.icon.Image = ((System.Drawing.Image)(resources.GetObject("icon.Image")));
            this.icon.Location = new System.Drawing.Point(192, 17);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(100, 100);
            this.icon.TabIndex = 11;
            this.icon.TabStop = false;
            // 
            // box_Password
            // 
            this.box_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.box_Password.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.box_Password.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.box_Password.HintText = "";
            this.box_Password.isPassword = true;
            this.box_Password.LineFocusedColor = System.Drawing.SystemColors.HotTrack;
            this.box_Password.LineIdleColor = System.Drawing.Color.Gray;
            this.box_Password.LineMouseHoverColor = System.Drawing.SystemColors.Highlight;
            this.box_Password.LineThickness = 1;
            this.box_Password.Location = new System.Drawing.Point(91, 184);
            this.box_Password.Margin = new System.Windows.Forms.Padding(4);
            this.box_Password.Name = "box_Password";
            this.box_Password.Size = new System.Drawing.Size(302, 33);
            this.box_Password.TabIndex = 10;
            this.box_Password.Text = "Password";
            this.box_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // box_Username
            // 
            this.box_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.box_Username.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.box_Username.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.box_Username.HintText = "Username";
            this.box_Username.isPassword = false;
            this.box_Username.LineFocusedColor = System.Drawing.SystemColors.HotTrack;
            this.box_Username.LineIdleColor = System.Drawing.Color.Gray;
            this.box_Username.LineMouseHoverColor = System.Drawing.SystemColors.Highlight;
            this.box_Username.LineThickness = 1;
            this.box_Username.Location = new System.Drawing.Point(91, 143);
            this.box_Username.Margin = new System.Windows.Forms.Padding(4);
            this.box_Username.Name = "box_Username";
            this.box_Username.Size = new System.Drawing.Size(302, 33);
            this.box_Username.TabIndex = 9;
            this.box_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button_Register
            // 
            this.button_Register.Activecolor = System.Drawing.SystemColors.Highlight;
            this.button_Register.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_Register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Register.BorderRadius = 0;
            this.button_Register.ButtonText = "Sign Up";
            this.button_Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Register.DisabledColor = System.Drawing.Color.Gray;
            this.button_Register.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Register.Iconcolor = System.Drawing.Color.Transparent;
            this.button_Register.Iconimage = ((System.Drawing.Image)(resources.GetObject("button_Register.Iconimage")));
            this.button_Register.Iconimage_right = null;
            this.button_Register.Iconimage_right_Selected = null;
            this.button_Register.Iconimage_Selected = null;
            this.button_Register.IconMarginLeft = 0;
            this.button_Register.IconMarginRight = 0;
            this.button_Register.IconRightVisible = true;
            this.button_Register.IconRightZoom = 0D;
            this.button_Register.IconVisible = false;
            this.button_Register.IconZoom = 90D;
            this.button_Register.IsTab = false;
            this.button_Register.Location = new System.Drawing.Point(300, 318);
            this.button_Register.Name = "button_Register";
            this.button_Register.Normalcolor = System.Drawing.SystemColors.Highlight;
            this.button_Register.OnHovercolor = System.Drawing.SystemColors.HotTrack;
            this.button_Register.OnHoverTextColor = System.Drawing.Color.White;
            this.button_Register.selected = false;
            this.button_Register.Size = new System.Drawing.Size(93, 37);
            this.button_Register.TabIndex = 8;
            this.button_Register.Text = "Sign Up";
            this.button_Register.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_Register.Textcolor = System.Drawing.Color.White;
            this.button_Register.TextFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Register.Click += new System.EventHandler(this.button_Register_Click);
            // 
            // elipse
            // 
            this.elipse.ElipseRadius = 5;
            this.elipse.TargetControl = this.button_Register;
            // 
            // captcha
            // 
            this.captcha.Location = new System.Drawing.Point(91, 224);
            this.captcha.Name = "captcha";
            this.captcha.Size = new System.Drawing.Size(302, 45);
            this.captcha.TabIndex = 12;
            this.captcha.TabStop = false;
            // 
            // box_captcha
            // 
            this.box_captcha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.box_captcha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_captcha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.box_captcha.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.box_captcha.HintText = "Captcha";
            this.box_captcha.isPassword = false;
            this.box_captcha.LineFocusedColor = System.Drawing.SystemColors.HotTrack;
            this.box_captcha.LineIdleColor = System.Drawing.Color.Gray;
            this.box_captcha.LineMouseHoverColor = System.Drawing.SystemColors.Highlight;
            this.box_captcha.LineThickness = 1;
            this.box_captcha.Location = new System.Drawing.Point(91, 276);
            this.box_captcha.Margin = new System.Windows.Forms.Padding(4);
            this.box_captcha.Name = "box_captcha";
            this.box_captcha.Size = new System.Drawing.Size(302, 33);
            this.box_captcha.TabIndex = 13;
            this.box_captcha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // registerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.box_captcha);
            this.Controls.Add(this.captcha);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.box_Password);
            this.Controls.Add(this.box_Username);
            this.Controls.Add(this.button_Register);
            this.Name = "registerControl";
            this.Size = new System.Drawing.Size(484, 372);
            this.Load += new System.EventHandler(this.registerControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.captcha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox icon;
        private Bunifu.Framework.UI.BunifuMaterialTextbox box_Password;
        private Bunifu.Framework.UI.BunifuMaterialTextbox box_Username;
        private Bunifu.Framework.UI.BunifuFlatButton button_Register;
        private Bunifu.Framework.UI.BunifuElipse elipse;
        private System.Windows.Forms.PictureBox captcha;
        private Bunifu.Framework.UI.BunifuMaterialTextbox box_captcha;
    }
}
