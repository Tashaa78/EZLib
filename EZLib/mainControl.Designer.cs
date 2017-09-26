namespace EZLib
{
    partial class mainControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainControl));
            this.elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel_Control = new System.Windows.Forms.Panel();
            this.label_EZLib = new System.Windows.Forms.Label();
            this.drag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.button_sign_in = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.button_exit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.button_sign_up = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tab_selected = new System.Windows.Forms.PictureBox();
            this.button_news = new Bunifu.Framework.UI.BunifuFlatButton();
            this.form = new System.Windows.Forms.Panel();
            this.panel_Control.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tab_selected)).BeginInit();
            this.SuspendLayout();
            // 
            // elipse
            // 
            this.elipse.ElipseRadius = 5;
            this.elipse.TargetControl = this;
            // 
            // panel_Control
            // 
            this.panel_Control.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel_Control.Controls.Add(this.label_EZLib);
            this.panel_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Control.ForeColor = System.Drawing.Color.Transparent;
            this.panel_Control.Location = new System.Drawing.Point(0, 0);
            this.panel_Control.Name = "panel_Control";
            this.panel_Control.Size = new System.Drawing.Size(697, 34);
            this.panel_Control.TabIndex = 3;
            // 
            // label_EZLib
            // 
            this.label_EZLib.AutoSize = true;
            this.label_EZLib.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_EZLib.Location = new System.Drawing.Point(3, 7);
            this.label_EZLib.Name = "label_EZLib";
            this.label_EZLib.Size = new System.Drawing.Size(46, 20);
            this.label_EZLib.TabIndex = 3;
            this.label_EZLib.Text = "EZLib";
            // 
            // drag
            // 
            this.drag.Fixed = true;
            this.drag.Horizontal = true;
            this.drag.TargetControl = this.panel_Control;
            this.drag.Vertical = true;
            // 
            // button_sign_in
            // 
            this.button_sign_in.Activecolor = System.Drawing.Color.White;
            this.button_sign_in.BackColor = System.Drawing.Color.White;
            this.button_sign_in.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_sign_in.BorderRadius = 0;
            this.button_sign_in.ButtonText = " Sign In";
            this.button_sign_in.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_sign_in.DisabledColor = System.Drawing.Color.Gray;
            this.button_sign_in.Iconcolor = System.Drawing.Color.Transparent;
            this.button_sign_in.Iconimage = ((System.Drawing.Image)(resources.GetObject("button_sign_in.Iconimage")));
            this.button_sign_in.Iconimage_right = null;
            this.button_sign_in.Iconimage_right_Selected = null;
            this.button_sign_in.Iconimage_Selected = null;
            this.button_sign_in.IconMarginLeft = 0;
            this.button_sign_in.IconMarginRight = 0;
            this.button_sign_in.IconRightVisible = true;
            this.button_sign_in.IconRightZoom = 0D;
            this.button_sign_in.IconVisible = true;
            this.button_sign_in.IconZoom = 60D;
            this.button_sign_in.IsTab = false;
            this.button_sign_in.Location = new System.Drawing.Point(12, 87);
            this.button_sign_in.Name = "button_sign_in";
            this.button_sign_in.Normalcolor = System.Drawing.Color.White;
            this.button_sign_in.OnHovercolor = System.Drawing.Color.White;
            this.button_sign_in.OnHoverTextColor = System.Drawing.SystemColors.Highlight;
            this.button_sign_in.selected = false;
            this.button_sign_in.Size = new System.Drawing.Size(200, 41);
            this.button_sign_in.TabIndex = 4;
            this.button_sign_in.Text = " Sign In";
            this.button_sign_in.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_sign_in.Textcolor = System.Drawing.Color.Gray;
            this.button_sign_in.TextFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sign_in.Click += new System.EventHandler(this.button_sign_in_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.button_news);
            this.bunifuGradientPanel1.Controls.Add(this.button_exit);
            this.bunifuGradientPanel1.Controls.Add(this.button_sign_up);
            this.bunifuGradientPanel1.Controls.Add(this.tab_selected);
            this.bunifuGradientPanel1.Controls.Add(this.button_sign_in);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 34);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(212, 372);
            this.bunifuGradientPanel1.TabIndex = 5;
            // 
            // button_exit
            // 
            this.button_exit.Activecolor = System.Drawing.Color.White;
            this.button_exit.BackColor = System.Drawing.Color.White;
            this.button_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_exit.BorderRadius = 0;
            this.button_exit.ButtonText = " Exit";
            this.button_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_exit.DisabledColor = System.Drawing.Color.Gray;
            this.button_exit.Iconcolor = System.Drawing.Color.Transparent;
            this.button_exit.Iconimage = ((System.Drawing.Image)(resources.GetObject("button_exit.Iconimage")));
            this.button_exit.Iconimage_right = null;
            this.button_exit.Iconimage_right_Selected = null;
            this.button_exit.Iconimage_Selected = null;
            this.button_exit.IconMarginLeft = 0;
            this.button_exit.IconMarginRight = 0;
            this.button_exit.IconRightVisible = true;
            this.button_exit.IconRightZoom = 0D;
            this.button_exit.IconVisible = true;
            this.button_exit.IconZoom = 60D;
            this.button_exit.IsTab = false;
            this.button_exit.Location = new System.Drawing.Point(12, 306);
            this.button_exit.Name = "button_exit";
            this.button_exit.Normalcolor = System.Drawing.Color.White;
            this.button_exit.OnHovercolor = System.Drawing.Color.White;
            this.button_exit.OnHoverTextColor = System.Drawing.SystemColors.Highlight;
            this.button_exit.selected = false;
            this.button_exit.Size = new System.Drawing.Size(200, 41);
            this.button_exit.TabIndex = 9;
            this.button_exit.Text = " Exit";
            this.button_exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_exit.Textcolor = System.Drawing.Color.Gray;
            this.button_exit.TextFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_sign_up
            // 
            this.button_sign_up.Activecolor = System.Drawing.Color.White;
            this.button_sign_up.BackColor = System.Drawing.Color.White;
            this.button_sign_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_sign_up.BorderRadius = 0;
            this.button_sign_up.ButtonText = " Sign Up";
            this.button_sign_up.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_sign_up.DisabledColor = System.Drawing.Color.Gray;
            this.button_sign_up.Iconcolor = System.Drawing.Color.Transparent;
            this.button_sign_up.Iconimage = ((System.Drawing.Image)(resources.GetObject("button_sign_up.Iconimage")));
            this.button_sign_up.Iconimage_right = null;
            this.button_sign_up.Iconimage_right_Selected = null;
            this.button_sign_up.Iconimage_Selected = null;
            this.button_sign_up.IconMarginLeft = 0;
            this.button_sign_up.IconMarginRight = 0;
            this.button_sign_up.IconRightVisible = true;
            this.button_sign_up.IconRightZoom = 0D;
            this.button_sign_up.IconVisible = true;
            this.button_sign_up.IconZoom = 60D;
            this.button_sign_up.IsTab = false;
            this.button_sign_up.Location = new System.Drawing.Point(12, 134);
            this.button_sign_up.Name = "button_sign_up";
            this.button_sign_up.Normalcolor = System.Drawing.Color.White;
            this.button_sign_up.OnHovercolor = System.Drawing.Color.White;
            this.button_sign_up.OnHoverTextColor = System.Drawing.SystemColors.Highlight;
            this.button_sign_up.selected = false;
            this.button_sign_up.Size = new System.Drawing.Size(200, 41);
            this.button_sign_up.TabIndex = 8;
            this.button_sign_up.Text = " Sign Up";
            this.button_sign_up.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_sign_up.Textcolor = System.Drawing.Color.Gray;
            this.button_sign_up.TextFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sign_up.Click += new System.EventHandler(this.button_sign_up_Click);
            // 
            // tab_selected
            // 
            this.tab_selected.BackColor = System.Drawing.SystemColors.Highlight;
            this.tab_selected.Location = new System.Drawing.Point(0, 40);
            this.tab_selected.Name = "tab_selected";
            this.tab_selected.Size = new System.Drawing.Size(7, 41);
            this.tab_selected.TabIndex = 7;
            this.tab_selected.TabStop = false;
            // 
            // button_news
            // 
            this.button_news.Activecolor = System.Drawing.Color.White;
            this.button_news.BackColor = System.Drawing.Color.White;
            this.button_news.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_news.BorderRadius = 0;
            this.button_news.ButtonText = " News";
            this.button_news.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_news.DisabledColor = System.Drawing.Color.Gray;
            this.button_news.Iconcolor = System.Drawing.Color.Transparent;
            this.button_news.Iconimage = ((System.Drawing.Image)(resources.GetObject("button_news.Iconimage")));
            this.button_news.Iconimage_right = null;
            this.button_news.Iconimage_right_Selected = null;
            this.button_news.Iconimage_Selected = null;
            this.button_news.IconMarginLeft = 0;
            this.button_news.IconMarginRight = 0;
            this.button_news.IconRightVisible = true;
            this.button_news.IconRightZoom = 0D;
            this.button_news.IconVisible = true;
            this.button_news.IconZoom = 60D;
            this.button_news.IsTab = false;
            this.button_news.Location = new System.Drawing.Point(12, 40);
            this.button_news.Name = "button_news";
            this.button_news.Normalcolor = System.Drawing.Color.White;
            this.button_news.OnHovercolor = System.Drawing.Color.White;
            this.button_news.OnHoverTextColor = System.Drawing.SystemColors.Highlight;
            this.button_news.selected = false;
            this.button_news.Size = new System.Drawing.Size(200, 41);
            this.button_news.TabIndex = 10;
            this.button_news.Text = " News";
            this.button_news.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_news.Textcolor = System.Drawing.Color.Gray;
            this.button_news.TextFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_news.Click += new System.EventHandler(this.button_news_Click);
            // 
            // form
            // 
            this.form.Location = new System.Drawing.Point(216, 34);
            this.form.Name = "form";
            this.form.Size = new System.Drawing.Size(481, 372);
            this.form.TabIndex = 6;
            // 
            // mainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(697, 406);
            this.Controls.Add(this.form);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.panel_Control);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainControl";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EZLib";
            this.panel_Control.ResumeLayout(false);
            this.panel_Control.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tab_selected)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse elipse;
        private System.Windows.Forms.Panel panel_Control;
        private System.Windows.Forms.Label label_EZLib;
        private Bunifu.Framework.UI.BunifuDragControl drag;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton button_sign_in;
        private System.Windows.Forms.PictureBox tab_selected;
        private Bunifu.Framework.UI.BunifuFlatButton button_sign_up;
        private Bunifu.Framework.UI.BunifuFlatButton button_exit;
        private Bunifu.Framework.UI.BunifuFlatButton button_news;
        private System.Windows.Forms.Panel form;
    }
}