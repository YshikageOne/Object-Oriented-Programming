namespace LoginForm
{
    partial class LoginFormWindow
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
            background1 = new Label();
            backgroundImage = new Label();
            backgroundText = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            backgroundText2 = new Label();
            btnExit = new Button();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // background1
            // 
            background1.BackColor = Color.Gray;
            background1.Location = new Point(-6, -1);
            background1.Name = "background1";
            background1.Size = new Size(240, 391);
            background1.TabIndex = 0;
            // 
            // backgroundImage
            // 
            backgroundImage.Image = Properties.Resources.blackmen;
            backgroundImage.Location = new Point(12, 9);
            backgroundImage.Name = "backgroundImage";
            backgroundImage.Size = new Size(209, 221);
            backgroundImage.TabIndex = 1;
            // 
            // backgroundText
            // 
            backgroundText.BackColor = Color.Gray;
            backgroundText.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            backgroundText.ForeColor = SystemColors.ActiveCaptionText;
            backgroundText.Location = new Point(12, 242);
            backgroundText.Name = "backgroundText";
            backgroundText.Size = new Size(209, 132);
            backgroundText.TabIndex = 2;
            backgroundText.Text = "Welcome to the Basic Login System";
            backgroundText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.Location = new Point(240, 25);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(81, 21);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(240, 49);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(187, 35);
            txtUsername.TabIndex = 4;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(240, 129);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(76, 21);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(240, 153);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(187, 35);
            txtPassword.TabIndex = 6;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(246, 212);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(81, 38);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // backgroundText2
            // 
            backgroundText2.AutoSize = true;
            backgroundText2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            backgroundText2.Location = new Point(262, 263);
            backgroundText2.Name = "backgroundText2";
            backgroundText2.Size = new Size(150, 30);
            backgroundText2.TabIndex = 9;
            backgroundText2.Text = "New to this???\r\nCreate an Account NOW!!";
            backgroundText2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(346, 212);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(81, 38);
            btnExit.TabIndex = 11;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(296, 306);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(81, 38);
            btnRegister.TabIndex = 12;
            btnRegister.Text = "Sign Up";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // LoginFormWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 383);
            Controls.Add(btnRegister);
            Controls.Add(btnExit);
            Controls.Add(backgroundText2);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(backgroundText);
            Controls.Add(backgroundImage);
            Controls.Add(background1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "LoginFormWindow";
            Text = "LoginFormWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label background1;
        private Label backgroundImage;
        private Label backgroundText;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label backgroundText2;
        private Button btnExit;
        private Button btnRegister;
    }
}