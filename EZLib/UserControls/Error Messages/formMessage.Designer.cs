namespace EZLib.UserControls.Error_Messages
{
    partial class formMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMessage));
            this.elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel_Control = new System.Windows.Forms.Panel();
            this.button_Close = new System.Windows.Forms.Panel();
            this.label_EZLib = new System.Windows.Forms.Label();
            this.panel_Status = new System.Windows.Forms.Panel();
            this.label_Status = new System.Windows.Forms.Label();
            this.label_Error = new System.Windows.Forms.Label();
            this.box_Error = new System.Windows.Forms.TextBox();
            this.drag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel_Control.SuspendLayout();
            this.panel_Status.SuspendLayout();
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
            this.panel_Control.Controls.Add(this.button_Close);
            this.panel_Control.Controls.Add(this.label_EZLib);
            this.panel_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Control.ForeColor = System.Drawing.Color.Transparent;
            this.panel_Control.Location = new System.Drawing.Point(0, 0);
            this.panel_Control.Name = "panel_Control";
            this.panel_Control.Size = new System.Drawing.Size(435, 34);
            this.panel_Control.TabIndex = 3;
            // 
            // button_Close
            // 
            this.button_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Close.BackgroundImage")));
            this.button_Close.Location = new System.Drawing.Point(405, 5);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(24, 24);
            this.button_Close.TabIndex = 3;
            this.button_Close.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_Close_MouseClick);
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
            // panel_Status
            // 
            this.panel_Status.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel_Status.Controls.Add(this.label_Status);
            this.panel_Status.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Status.ForeColor = System.Drawing.Color.Transparent;
            this.panel_Status.Location = new System.Drawing.Point(0, 351);
            this.panel_Status.Name = "panel_Status";
            this.panel_Status.Size = new System.Drawing.Size(435, 26);
            this.panel_Status.TabIndex = 5;
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Status.Location = new System.Drawing.Point(160, 7);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(115, 13);
            this.label_Status.TabIndex = 3;
            this.label_Status.Text = "Copyright 2017 EZLib";
            // 
            // label_Error
            // 
            this.label_Error.AutoSize = true;
            this.label_Error.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Error.Location = new System.Drawing.Point(130, 49);
            this.label_Error.Name = "label_Error";
            this.label_Error.Size = new System.Drawing.Size(174, 21);
            this.label_Error.TabIndex = 6;
            this.label_Error.Text = "An error has occurred!";
            // 
            // box_Error
            // 
            this.box_Error.BackColor = System.Drawing.Color.White;
            this.box_Error.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_Error.Location = new System.Drawing.Point(12, 92);
            this.box_Error.Multiline = true;
            this.box_Error.Name = "box_Error";
            this.box_Error.ReadOnly = true;
            this.box_Error.Size = new System.Drawing.Size(411, 239);
            this.box_Error.TabIndex = 7;
            // 
            // drag
            // 
            this.drag.Fixed = true;
            this.drag.Horizontal = true;
            this.drag.TargetControl = this.panel_Control;
            this.drag.Vertical = true;
            // 
            // formMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(435, 377);
            this.Controls.Add(this.box_Error);
            this.Controls.Add(this.label_Error);
            this.Controls.Add(this.panel_Status);
            this.Controls.Add(this.panel_Control);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formMessage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel_Control.ResumeLayout(false);
            this.panel_Control.PerformLayout();
            this.panel_Status.ResumeLayout(false);
            this.panel_Status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse elipse;
        private System.Windows.Forms.Panel panel_Control;
        private System.Windows.Forms.Panel button_Close;
        private System.Windows.Forms.Label label_EZLib;
        private System.Windows.Forms.Panel panel_Status;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.Label label_Error;
        private System.Windows.Forms.TextBox box_Error;
        private Bunifu.Framework.UI.BunifuDragControl drag;
    }
}