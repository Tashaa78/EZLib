namespace EZLib.UserControls
{
    partial class loaderControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loaderControl));
            this.elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label_EZLib = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.preloader = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.label_Message = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.drag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.load_time = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // elipse
            // 
            this.elipse.ElipseRadius = 5;
            this.elipse.TargetControl = this;
            // 
            // label_EZLib
            // 
            this.label_EZLib.AutoSize = true;
            this.label_EZLib.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_EZLib.Location = new System.Drawing.Point(192, 11);
            this.label_EZLib.Name = "label_EZLib";
            this.label_EZLib.Size = new System.Drawing.Size(58, 25);
            this.label_EZLib.TabIndex = 0;
            this.label_EZLib.Text = "EZLib";
            // 
            // preloader
            // 
            this.preloader.animated = true;
            this.preloader.animationIterval = 20;
            this.preloader.animationSpeed = 20;
            this.preloader.BackColor = System.Drawing.Color.Transparent;
            this.preloader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("preloader.BackgroundImage")));
            this.preloader.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.preloader.ForeColor = System.Drawing.Color.Transparent;
            this.preloader.LabelVisible = false;
            this.preloader.LineProgressThickness = 8;
            this.preloader.LineThickness = 0;
            this.preloader.Location = new System.Drawing.Point(135, 71);
            this.preloader.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.preloader.MaxValue = 100;
            this.preloader.Name = "preloader";
            this.preloader.ProgressBackColor = System.Drawing.Color.Transparent;
            this.preloader.ProgressColor = System.Drawing.SystemColors.Highlight;
            this.preloader.Size = new System.Drawing.Size(172, 172);
            this.preloader.TabIndex = 1;
            this.preloader.Value = 45;
            // 
            // label_Message
            // 
            this.label_Message.AutoSize = true;
            this.label_Message.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Message.Location = new System.Drawing.Point(146, 36);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(150, 17);
            this.label_Message.TabIndex = 2;
            this.label_Message.Text = "Loading your program...";
            // 
            // drag
            // 
            this.drag.Fixed = true;
            this.drag.Horizontal = true;
            this.drag.TargetControl = this;
            this.drag.Vertical = true;
            // 
            // load_time
            // 
            this.load_time.Interval = 3000;
            this.load_time.Tick += new System.EventHandler(this.load_time_Tick);
            // 
            // loaderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_Message);
            this.Controls.Add(this.preloader);
            this.Controls.Add(this.label_EZLib);
            this.Name = "loaderControl";
            this.Size = new System.Drawing.Size(442, 270);
            this.Load += new System.EventHandler(this.loaderControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse elipse;
        private Bunifu.Framework.UI.BunifuCustomLabel label_EZLib;
        private Bunifu.Framework.UI.BunifuCircleProgressbar preloader;
        private Bunifu.Framework.UI.BunifuCustomLabel label_Message;
        private Bunifu.Framework.UI.BunifuDragControl drag;
        private System.Windows.Forms.Timer load_time;
    }
}
