namespace TypingApplication
{
    partial class LogIn
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
            checkBoxShowPassword = new CheckBox();
            labelNoAccount = new Label();
            buttonSignUp = new Button();
            buttonLogIn = new Button();
            textBoxPassword = new TextBox();
            textBoxEmail = new TextBox();
            labelPassword = new Label();
            labelEmail = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // checkBoxShowPassword
            // 
            checkBoxShowPassword.AutoSize = true;
            checkBoxShowPassword.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxShowPassword.Location = new Point(167, 257);
            checkBoxShowPassword.Name = "checkBoxShowPassword";
            checkBoxShowPassword.Size = new Size(161, 29);
            checkBoxShowPassword.TabIndex = 16;
            checkBoxShowPassword.Text = "Show Password";
            checkBoxShowPassword.UseVisualStyleBackColor = true;
            checkBoxShowPassword.CheckedChanged += checkBoxShowPassword_CheckedChanged;
            // 
            // labelNoAccount
            // 
            labelNoAccount.AutoSize = true;
            labelNoAccount.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelNoAccount.Location = new Point(207, 373);
            labelNoAccount.Name = "labelNoAccount";
            labelNoAccount.Size = new Size(236, 25);
            labelNoAccount.TabIndex = 15;
            labelNoAccount.Text = "Don't Have an Account Yet?";
            // 
            // buttonSignUp
            // 
            buttonSignUp.FlatAppearance.BorderSize = 0;
            buttonSignUp.FlatStyle = FlatStyle.Flat;
            buttonSignUp.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSignUp.Location = new Point(256, 401);
            buttonSignUp.Name = "buttonSignUp";
            buttonSignUp.Size = new Size(116, 45);
            buttonSignUp.TabIndex = 14;
            buttonSignUp.Text = "Sign Up";
            buttonSignUp.UseVisualStyleBackColor = true;
            buttonSignUp.Click += buttonSignUp_Click;
            // 
            // buttonLogIn
            // 
            buttonLogIn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogIn.Location = new Point(167, 292);
            buttonLogIn.Name = "buttonLogIn";
            buttonLogIn.Size = new Size(96, 44);
            buttonLogIn.TabIndex = 13;
            buttonLogIn.Text = "Log In";
            buttonLogIn.UseVisualStyleBackColor = true;
            buttonLogIn.Click += buttonLogIn_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(167, 205);
            textBoxPassword.MaxLength = 30;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(341, 43);
            textBoxPassword.TabIndex = 12;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.Location = new Point(167, 158);
            textBoxEmail.MaxLength = 30;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(341, 43);
            textBoxEmail.TabIndex = 11;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI Semilight", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.Location = new Point(26, 211);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(126, 37);
            labelPassword.TabIndex = 10;
            labelPassword.Text = "Password";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI Semilight", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmail.Location = new Point(26, 164);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(80, 37);
            labelEmail.TabIndex = 9;
            labelEmail.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(387, 262);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 17;
            label1.Text = "Forgot Password?";
            label1.Click += label1_Click;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 501);
            Controls.Add(label1);
            Controls.Add(checkBoxShowPassword);
            Controls.Add(labelNoAccount);
            Controls.Add(buttonSignUp);
            Controls.Add(buttonLogIn);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxEmail);
            Controls.Add(labelPassword);
            Controls.Add(labelEmail);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "LogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Type It";
            Load += LogIn_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxShowPassword;
        private Label labelNoAccount;
        private Button buttonSignUp;
        private Button buttonLogIn;
        private TextBox textBoxPassword;
        private TextBox textBoxEmail;
        private Label labelPassword;
        private Label labelEmail;
        private Label label1;
    }
}