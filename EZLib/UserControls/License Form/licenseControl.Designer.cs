namespace EZLib.UserControls
{
    partial class licenseControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(licenseControl));
            this.elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.box_Password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.box_Username = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button_License = new Bunifu.Framework.UI.BunifuFlatButton();
            this.icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // elipse
            // 
            this.elipse.ElipseRadius = 5;
            this.elipse.TargetControl = this.button_License;
            // 
            // box_Password
            // 
            this.box_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.box_Password.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.box_Password.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.box_Password.HintText = "License Key";
            this.box_Password.isPassword = false;
            this.box_Password.LineFocusedColor = System.Drawing.SystemColors.HotTrack;
            this.box_Password.LineIdleColor = System.Drawing.Color.Gray;
            this.box_Password.LineMouseHoverColor = System.Drawing.SystemColors.Highlight;
            this.box_Password.LineThickness = 1;
            this.box_Password.Location = new System.Drawing.Point(91, 231);
            this.box_Password.Margin = new System.Windows.Forms.Padding(4);
            this.box_Password.Name = "box_Password";
            this.box_Password.Size = new System.Drawing.Size(302, 33);
            this.box_Password.TabIndex = 10;
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
            this.box_Username.Location = new System.Drawing.Point(91, 190);
            this.box_Username.Margin = new System.Windows.Forms.Padding(4);
            this.box_Username.Name = "box_Username";
            this.box_Username.Size = new System.Drawing.Size(302, 33);
            this.box_Username.TabIndex = 9;
            this.box_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button_License
            // 
            this.button_License.Activecolor = System.Drawing.SystemColors.Highlight;
            this.button_License.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_License.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_License.BorderRadius = 0;
            this.button_License.ButtonText = "License";
            this.button_License.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_License.DisabledColor = System.Drawing.Color.Gray;
            this.button_License.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_License.Iconcolor = System.Drawing.Color.Transparent;
            this.button_License.Iconimage = ((System.Drawing.Image)(resources.GetObject("button_License.Iconimage")));
            this.button_License.Iconimage_right = null;
            this.button_License.Iconimage_right_Selected = null;
            this.button_License.Iconimage_Selected = null;
            this.button_License.IconMarginLeft = 0;
            this.button_License.IconMarginRight = 0;
            this.button_License.IconRightVisible = true;
            this.button_License.IconRightZoom = 0D;
            this.button_License.IconVisible = false;
            this.button_License.IconZoom = 90D;
            this.button_License.IsTab = false;
            this.button_License.Location = new System.Drawing.Point(300, 271);
            this.button_License.Name = "button_License";
            this.button_License.Normalcolor = System.Drawing.SystemColors.Highlight;
            this.button_License.OnHovercolor = System.Drawing.SystemColors.HotTrack;
            this.button_License.OnHoverTextColor = System.Drawing.Color.White;
            this.button_License.selected = false;
            this.button_License.Size = new System.Drawing.Size(93, 37);
            this.button_License.TabIndex = 8;
            this.button_License.Text = "License";
            this.button_License.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_License.Textcolor = System.Drawing.Color.White;
            this.button_License.TextFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_License.Click += new System.EventHandler(this.button_License_Click);
            // 
            // icon
            // 
            this.icon.Image = ((System.Drawing.Image)(resources.GetObject("icon.Image")));
            this.icon.Location = new System.Drawing.Point(192, 64);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(100, 100);
            this.icon.TabIndex = 11;
            this.icon.TabStop = false;
            // 
            // licenseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.box_Password);
            this.Controls.Add(this.box_Username);
            this.Controls.Add(this.button_License);
            this.Controls.Add(this.icon);
            this.Name = "licenseControl";
            this.Size = new System.Drawing.Size(484, 372);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse elipse;
        private Bunifu.Framework.UI.BunifuMaterialTextbox box_Password;
        private Bunifu.Framework.UI.BunifuMaterialTextbox box_Username;
        private Bunifu.Framework.UI.BunifuFlatButton button_License;
        private System.Windows.Forms.PictureBox icon;
    }
}
