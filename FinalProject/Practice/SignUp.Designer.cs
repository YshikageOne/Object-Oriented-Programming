namespace LoginForm
{
    partial class SignUp
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
            lblRegister = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblUserName = new Label();
            lblPassword = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnRegister = new Button();
            btnExit = new Button();
            chkBox = new CheckBox();
            SuspendLayout();
            // 
            // lblRegister
            // 
            lblRegister.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegister.Location = new Point(12, 8);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(295, 38);
            lblRegister.TabIndex = 0;
            lblRegister.Text = "Register now!!!\r\n";
            lblRegister.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblFirstName.Location = new Point(12, 47);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(124, 30);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "First Name :";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblLastName.Location = new Point(12, 87);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(123, 30);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name :";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserName.Location = new Point(12, 142);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(117, 30);
            lblUserName.TabIndex = 3;
            lblUserName.Text = "Username :";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(12, 186);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(110, 30);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password :";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.Location = new Point(132, 49);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(183, 35);
            txtFirstName.TabIndex = 5;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(132, 87);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(183, 35);
            txtLastName.TabIndex = 6;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(132, 139);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(183, 35);
            txtUsername.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(132, 183);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(183, 35);
            txtPassword.TabIndex = 8;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(12, 282);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(110, 34);
            btnRegister.TabIndex = 9;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(197, 282);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(110, 34);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // chkBox
            // 
            chkBox.AutoSize = true;
            chkBox.Location = new Point(12, 241);
            chkBox.Name = "chkBox";
            chkBox.Size = new Size(259, 19);
            chkBox.TabIndex = 11;
            chkBox.Text = "I understand that I am giving you my soul :) ";
            chkBox.UseVisualStyleBackColor = true;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 328);
            Controls.Add(chkBox);
            Controls.Add(btnExit);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblPassword);
            Controls.Add(lblUserName);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblRegister);
            MaximizeBox = false;
            Name = "SignUp";
            Text = "Sign Up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegister;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblUserName;
        private Label lblPassword;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnRegister;
        private Button btnExit;
        private CheckBox chkBox;
    }
}