namespace Login
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnlWelcome = new Panel();
            lblWelcome = new Label();
            btnGetStarted = new Button();
            pnlRegister = new Panel();
            btnRegisterReg = new Button();
            lblRegisterLogin = new Label();
            lblRegisterPassword = new Label();
            lblRegisterUsername = new Label();
            txtRegisterUsername = new TextBox();
            txtRegisterPassword = new TextBox();
            pnlLogin = new Panel();
            lblRegister = new Label();
            lblLogin = new Button();
            txtLoginUsername = new TextBox();
            txtLoginPassword = new TextBox();
            lblLoginUsername = new Label();
            lblLoginPassword = new Label();
            pnlWelcome.SuspendLayout();
            pnlRegister.SuspendLayout();
            pnlLogin.SuspendLayout();
            SuspendLayout();
            // 
            // pnlWelcome
            // 
            pnlWelcome.Controls.Add(lblWelcome);
            pnlWelcome.Controls.Add(btnGetStarted);
            pnlWelcome.Location = new Point(12, 12);
            pnlWelcome.Name = "pnlWelcome";
            pnlWelcome.Size = new Size(416, 221);
            pnlWelcome.TabIndex = 0;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 14F);
            lblWelcome.Location = new Point(75, 83);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(260, 32);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome to Bobs shop";
            // 
            // btnGetStarted
            // 
            btnGetStarted.Location = new Point(152, 158);
            btnGetStarted.Name = "btnGetStarted";
            btnGetStarted.Size = new Size(94, 29);
            btnGetStarted.TabIndex = 0;
            btnGetStarted.Text = "Get Started";
            btnGetStarted.UseVisualStyleBackColor = true;
            btnGetStarted.Click += btnGetStarted_Click;
            // 
            // pnlRegister
            // 
            pnlRegister.Controls.Add(btnRegisterReg);
            pnlRegister.Controls.Add(lblRegisterLogin);
            pnlRegister.Controls.Add(lblRegisterPassword);
            pnlRegister.Controls.Add(lblRegisterUsername);
            pnlRegister.Controls.Add(txtRegisterUsername);
            pnlRegister.Controls.Add(txtRegisterPassword);
            pnlRegister.Location = new Point(434, 12);
            pnlRegister.Name = "pnlRegister";
            pnlRegister.Size = new Size(416, 221);
            pnlRegister.TabIndex = 1;
            pnlRegister.Visible = false;
            // 
            // btnRegisterReg
            // 
            btnRegisterReg.Location = new Point(153, 159);
            btnRegisterReg.Name = "btnRegisterReg";
            btnRegisterReg.Size = new Size(94, 29);
            btnRegisterReg.TabIndex = 3;
            btnRegisterReg.Text = "Register";
            btnRegisterReg.UseVisualStyleBackColor = true;
            btnRegisterReg.Click += btnRegisterReg_Click;
            // 
            // lblRegisterLogin
            // 
            lblRegisterLogin.AutoSize = true;
            lblRegisterLogin.ForeColor = Color.RoyalBlue;
            lblRegisterLogin.Location = new Point(100, 191);
            lblRegisterLogin.Name = "lblRegisterLogin";
            lblRegisterLogin.Size = new Size(219, 20);
            lblRegisterLogin.TabIndex = 4;
            lblRegisterLogin.Text = "Already have an account? Login";
            lblRegisterLogin.Click += lblRegisterLogin_Click;
            // 
            // lblRegisterPassword
            // 
            lblRegisterPassword.AutoSize = true;
            lblRegisterPassword.Location = new Point(100, 96);
            lblRegisterPassword.Name = "lblRegisterPassword";
            lblRegisterPassword.Size = new Size(70, 20);
            lblRegisterPassword.TabIndex = 3;
            lblRegisterPassword.Text = "Password";
            // 
            // lblRegisterUsername
            // 
            lblRegisterUsername.AutoSize = true;
            lblRegisterUsername.Location = new Point(100, 34);
            lblRegisterUsername.Name = "lblRegisterUsername";
            lblRegisterUsername.Size = new Size(75, 20);
            lblRegisterUsername.TabIndex = 2;
            lblRegisterUsername.Text = "Username";
            // 
            // txtRegisterUsername
            // 
            txtRegisterUsername.Location = new Point(100, 57);
            txtRegisterUsername.Name = "txtRegisterUsername";
            txtRegisterUsername.Size = new Size(219, 27);
            txtRegisterUsername.TabIndex = 0;
            // 
            // txtRegisterPassword
            // 
            txtRegisterPassword.Location = new Point(100, 119);
            txtRegisterPassword.Name = "txtRegisterPassword";
            txtRegisterPassword.PasswordChar = '*';
            txtRegisterPassword.Size = new Size(219, 27);
            txtRegisterPassword.TabIndex = 1;
            // 
            // pnlLogin
            // 
            pnlLogin.Controls.Add(lblRegister);
            pnlLogin.Controls.Add(lblLogin);
            pnlLogin.Controls.Add(txtLoginUsername);
            pnlLogin.Controls.Add(txtLoginPassword);
            pnlLogin.Controls.Add(lblLoginUsername);
            pnlLogin.Controls.Add(lblLoginPassword);
            pnlLogin.Location = new Point(12, 239);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(416, 221);
            pnlLogin.TabIndex = 0;
            pnlLogin.Visible = false;
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.ForeColor = Color.RoyalBlue;
            lblRegister.Location = new Point(131, 191);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(142, 20);
            lblRegister.TabIndex = 4;
            lblRegister.Text = "Not a user? Register";
            lblRegister.Click += lblRegister_Click;
            // 
            // lblLogin
            // 
            lblLogin.Location = new Point(153, 159);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(94, 29);
            lblLogin.TabIndex = 3;
            lblLogin.Text = "Login";
            lblLogin.UseVisualStyleBackColor = true;
            lblLogin.Click += lblLogin_Click;
            // 
            // txtLoginUsername
            // 
            txtLoginUsername.Location = new Point(100, 57);
            txtLoginUsername.Name = "txtLoginUsername";
            txtLoginUsername.Size = new Size(219, 27);
            txtLoginUsername.TabIndex = 0;
            // 
            // txtLoginPassword
            // 
            txtLoginPassword.Location = new Point(100, 119);
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.PasswordChar = '*';
            txtLoginPassword.Size = new Size(219, 27);
            txtLoginPassword.TabIndex = 1;
            // 
            // lblLoginUsername
            // 
            lblLoginUsername.AutoSize = true;
            lblLoginUsername.Location = new Point(100, 34);
            lblLoginUsername.Name = "lblLoginUsername";
            lblLoginUsername.Size = new Size(75, 20);
            lblLoginUsername.TabIndex = 1;
            lblLoginUsername.Text = "Username";
            // 
            // lblLoginPassword
            // 
            lblLoginPassword.AutoSize = true;
            lblLoginPassword.Location = new Point(100, 96);
            lblLoginPassword.Name = "lblLoginPassword";
            lblLoginPassword.Size = new Size(70, 20);
            lblLoginPassword.TabIndex = 0;
            lblLoginPassword.Text = "Password";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(916, 503);
            Controls.Add(pnlLogin);
            Controls.Add(pnlRegister);
            Controls.Add(pnlWelcome);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Bobs Shop";
            Load += Form1_Load;
            pnlWelcome.ResumeLayout(false);
            pnlWelcome.PerformLayout();
            pnlRegister.ResumeLayout(false);
            pnlRegister.PerformLayout();
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlWelcome;
        private Button btnGetStarted;
        private Panel pnlRegister;
        private Panel pnlLogin;
        private Label lblWelcome;
        private Label lblRegisterUsername;
        private TextBox txtRegisterUsername;
        private TextBox txtRegisterPassword;
        private Label lblRegister;
        private Button lblLogin;
        private TextBox txtLoginUsername;
        private TextBox txtLoginPassword;
        private Label lblLoginUsername;
        private Label lblLoginPassword;
        private Button btnRegisterReg;
        private Label lblRegisterLogin;
        private Label lblRegisterPassword;
    }
}
