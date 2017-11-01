namespace EZLibTests
{
    partial class registerForm
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
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelEZLib = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.labelFName = new System.Windows.Forms.Label();
            this.textFName = new System.Windows.Forms.TextBox();
            this.labelLName = new System.Windows.Forms.Label();
            this.textLName = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(215, 147);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(56, 13);
            this.labelPassword.TabIndex = 13;
            this.labelPassword.Text = "Password";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(10, 147);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(58, 13);
            this.labelUsername.TabIndex = 12;
            this.labelUsername.Text = "Username";
            // 
            // labelEZLib
            // 
            this.labelEZLib.AutoSize = true;
            this.labelEZLib.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEZLib.Location = new System.Drawing.Point(180, 9);
            this.labelEZLib.Name = "labelEZLib";
            this.labelEZLib.Size = new System.Drawing.Size(58, 25);
            this.labelEZLib.TabIndex = 11;
            this.labelEZLib.Text = "EZLib";
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(291, 209);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(116, 23);
            this.buttonRegister.TabIndex = 6;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(13, 209);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(87, 23);
            this.buttonLogin.TabIndex = 7;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(218, 163);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(190, 22);
            this.textPassword.TabIndex = 5;
            this.textPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textPassword.UseSystemPasswordChar = true;
            // 
            // textUsername
            // 
            this.textUsername.Location = new System.Drawing.Point(13, 163);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(190, 22);
            this.textUsername.TabIndex = 4;
            this.textUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.Location = new System.Drawing.Point(10, 55);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(61, 13);
            this.labelFName.TabIndex = 15;
            this.labelFName.Text = "First Name";
            // 
            // textFName
            // 
            this.textFName.Location = new System.Drawing.Point(13, 71);
            this.textFName.Name = "textFName";
            this.textFName.Size = new System.Drawing.Size(190, 22);
            this.textFName.TabIndex = 1;
            this.textFName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelLName
            // 
            this.labelLName.AutoSize = true;
            this.labelLName.Location = new System.Drawing.Point(215, 55);
            this.labelLName.Name = "labelLName";
            this.labelLName.Size = new System.Drawing.Size(59, 13);
            this.labelLName.TabIndex = 17;
            this.labelLName.Text = "Last Name";
            // 
            // textLName
            // 
            this.textLName.Location = new System.Drawing.Point(218, 71);
            this.textLName.Name = "textLName";
            this.textLName.Size = new System.Drawing.Size(190, 22);
            this.textLName.TabIndex = 2;
            this.textLName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(10, 101);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(78, 13);
            this.labelEmail.TabIndex = 19;
            this.labelEmail.Text = "Email Address";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(13, 117);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(395, 22);
            this.textEmail.TabIndex = 3;
            this.textEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // registerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 244);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.labelLName);
            this.Controls.Add(this.textLName);
            this.Controls.Add(this.labelFName);
            this.Controls.Add(this.textFName);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelEZLib);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textUsername);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "registerForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EZLibTests";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.registerForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelEZLib;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.TextBox textFName;
        private System.Windows.Forms.Label labelLName;
        private System.Windows.Forms.TextBox textLName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textEmail;
    }
}