
namespace N01413931_Project
{
    partial class frmAccount
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tbAccount = new System.Windows.Forms.TabControl();
            this.tbpSignIn = new System.Windows.Forms.TabPage();
            this.tbpRegister = new System.Windows.Forms.TabPage();
            this.lblUserNameNew = new System.Windows.Forms.Label();
            this.btnExitReg = new System.Windows.Forms.Button();
            this.lblPasswordNew = new System.Windows.Forms.Label();
            this.txtUserNameNew = new System.Windows.Forms.TextBox();
            this.txtPasswordNew = new System.Windows.Forms.TextBox();
            this.btnLoginNew = new System.Windows.Forms.Button();
            this.tbAccount.SuspendLayout();
            this.tbpSignIn.SuspendLayout();
            this.tbpRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(35, 56);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(109, 20);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "USERNAME";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(178, 53);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 26);
            this.txtUserName.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(178, 97);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 26);
            this.txtPassword.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(35, 100);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(111, 20);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "PASSWORD";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(38, 155);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(91, 34);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(187, 155);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 34);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tbAccount
            // 
            this.tbAccount.Controls.Add(this.tbpSignIn);
            this.tbAccount.Controls.Add(this.tbpRegister);
            this.tbAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAccount.Location = new System.Drawing.Point(2, 3);
            this.tbAccount.Name = "tbAccount";
            this.tbAccount.SelectedIndex = 0;
            this.tbAccount.Size = new System.Drawing.Size(359, 282);
            this.tbAccount.TabIndex = 6;
            // 
            // tbpSignIn
            // 
            this.tbpSignIn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tbpSignIn.Controls.Add(this.lblUserName);
            this.tbpSignIn.Controls.Add(this.btnExit);
            this.tbpSignIn.Controls.Add(this.txtUserName);
            this.tbpSignIn.Controls.Add(this.btnLogin);
            this.tbpSignIn.Controls.Add(this.txtPassword);
            this.tbpSignIn.Controls.Add(this.lblPassword);
            this.tbpSignIn.Location = new System.Drawing.Point(4, 29);
            this.tbpSignIn.Name = "tbpSignIn";
            this.tbpSignIn.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSignIn.Size = new System.Drawing.Size(351, 249);
            this.tbpSignIn.TabIndex = 0;
            this.tbpSignIn.Text = "Sign In";
            // 
            // tbpRegister
            // 
            this.tbpRegister.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tbpRegister.Controls.Add(this.lblUserNameNew);
            this.tbpRegister.Controls.Add(this.btnExitReg);
            this.tbpRegister.Controls.Add(this.lblPasswordNew);
            this.tbpRegister.Controls.Add(this.txtUserNameNew);
            this.tbpRegister.Controls.Add(this.txtPasswordNew);
            this.tbpRegister.Controls.Add(this.btnLoginNew);
            this.tbpRegister.Location = new System.Drawing.Point(4, 29);
            this.tbpRegister.Name = "tbpRegister";
            this.tbpRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRegister.Size = new System.Drawing.Size(351, 249);
            this.tbpRegister.TabIndex = 1;
            this.tbpRegister.Text = "Register";
            // 
            // lblUserNameNew
            // 
            this.lblUserNameNew.AutoSize = true;
            this.lblUserNameNew.Location = new System.Drawing.Point(41, 63);
            this.lblUserNameNew.Name = "lblUserNameNew";
            this.lblUserNameNew.Size = new System.Drawing.Size(109, 20);
            this.lblUserNameNew.TabIndex = 7;
            this.lblUserNameNew.Text = "USERNAME";
            // 
            // btnExitReg
            // 
            this.btnExitReg.Location = new System.Drawing.Point(193, 162);
            this.btnExitReg.Name = "btnExitReg";
            this.btnExitReg.Size = new System.Drawing.Size(91, 34);
            this.btnExitReg.TabIndex = 12;
            this.btnExitReg.Text = "EXIT";
            this.btnExitReg.UseVisualStyleBackColor = true;
            this.btnExitReg.Click += new System.EventHandler(this.btnExitReg_Click);
            // 
            // lblPasswordNew
            // 
            this.lblPasswordNew.AutoSize = true;
            this.lblPasswordNew.Location = new System.Drawing.Point(41, 107);
            this.lblPasswordNew.Name = "lblPasswordNew";
            this.lblPasswordNew.Size = new System.Drawing.Size(111, 20);
            this.lblPasswordNew.TabIndex = 10;
            this.lblPasswordNew.Text = "PASSWORD";
            // 
            // txtUserNameNew
            // 
            this.txtUserNameNew.Location = new System.Drawing.Point(184, 60);
            this.txtUserNameNew.Name = "txtUserNameNew";
            this.txtUserNameNew.Size = new System.Drawing.Size(100, 26);
            this.txtUserNameNew.TabIndex = 8;
            // 
            // txtPasswordNew
            // 
            this.txtPasswordNew.Location = new System.Drawing.Point(184, 104);
            this.txtPasswordNew.Name = "txtPasswordNew";
            this.txtPasswordNew.Size = new System.Drawing.Size(100, 26);
            this.txtPasswordNew.TabIndex = 9;
            // 
            // btnLoginNew
            // 
            this.btnLoginNew.Location = new System.Drawing.Point(44, 162);
            this.btnLoginNew.Name = "btnLoginNew";
            this.btnLoginNew.Size = new System.Drawing.Size(91, 34);
            this.btnLoginNew.TabIndex = 11;
            this.btnLoginNew.Text = "LOGIN";
            this.btnLoginNew.UseVisualStyleBackColor = true;
            this.btnLoginNew.Click += new System.EventHandler(this.btnLoginNew_Click);
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(362, 287);
            this.Controls.Add(this.tbAccount);
            this.MaximizeBox = false;
            this.Name = "frmAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account";
            this.tbAccount.ResumeLayout(false);
            this.tbpSignIn.ResumeLayout(false);
            this.tbpSignIn.PerformLayout();
            this.tbpRegister.ResumeLayout(false);
            this.tbpRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TabControl tbAccount;
        private System.Windows.Forms.TabPage tbpSignIn;
        private System.Windows.Forms.TabPage tbpRegister;
        private System.Windows.Forms.Label lblUserNameNew;
        private System.Windows.Forms.Button btnExitReg;
        private System.Windows.Forms.Label lblPasswordNew;
        private System.Windows.Forms.TextBox txtUserNameNew;
        private System.Windows.Forms.TextBox txtPasswordNew;
        private System.Windows.Forms.Button btnLoginNew;
    }
}