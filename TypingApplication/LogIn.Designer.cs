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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            checkBoxShowPassword = new CheckBox();
            labelNoAccount = new Label();
            buttonSignUp = new Button();
            buttonLogIn = new Button();
            textBoxPassword = new TextBox();
            textBoxEmail = new TextBox();
            labelPassword = new Label();
            labelEmail = new Label();
            labelForgotPassword = new Label();
            labelAppName = new Label();
            SuspendLayout();
            // 
            // checkBoxShowPassword
            // 
            checkBoxShowPassword.AutoSize = true;
            checkBoxShowPassword.BackColor = Color.Transparent;
            checkBoxShowPassword.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxShowPassword.ForeColor = Color.White;
            checkBoxShowPassword.Location = new Point(197, 304);
            checkBoxShowPassword.Name = "checkBoxShowPassword";
            checkBoxShowPassword.Size = new Size(161, 29);
            checkBoxShowPassword.TabIndex = 16;
            checkBoxShowPassword.Text = "Show Password";
            checkBoxShowPassword.UseVisualStyleBackColor = false;
            checkBoxShowPassword.CheckedChanged += checkBoxShowPassword_CheckedChanged;
            // 
            // labelNoAccount
            // 
            labelNoAccount.AutoSize = true;
            labelNoAccount.BackColor = Color.Transparent;
            labelNoAccount.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelNoAccount.ForeColor = Color.White;
            labelNoAccount.Location = new Point(231, 420);
            labelNoAccount.Name = "labelNoAccount";
            labelNoAccount.Size = new Size(236, 25);
            labelNoAccount.TabIndex = 15;
            labelNoAccount.Text = "Don't Have an Account Yet?";
            // 
            // buttonSignUp
            // 
            buttonSignUp.BackColor = Color.Transparent;
            buttonSignUp.Cursor = Cursors.Hand;
            buttonSignUp.FlatAppearance.BorderSize = 0;
            buttonSignUp.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonSignUp.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonSignUp.FlatStyle = FlatStyle.Flat;
            buttonSignUp.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSignUp.ForeColor = Color.White;
            buttonSignUp.Location = new Point(286, 448);
            buttonSignUp.Name = "buttonSignUp";
            buttonSignUp.Size = new Size(116, 45);
            buttonSignUp.TabIndex = 14;
            buttonSignUp.Text = "Sign Up";
            buttonSignUp.UseVisualStyleBackColor = false;
            buttonSignUp.Click += buttonSignUp_Click;
            // 
            // buttonLogIn
            // 
            buttonLogIn.BackColor = Color.Transparent;
            buttonLogIn.Cursor = Cursors.Hand;
            buttonLogIn.FlatAppearance.BorderSize = 0;
            buttonLogIn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonLogIn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonLogIn.FlatStyle = FlatStyle.Flat;
            buttonLogIn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogIn.ForeColor = Color.White;
            buttonLogIn.Location = new Point(197, 339);
            buttonLogIn.Name = "buttonLogIn";
            buttonLogIn.Size = new Size(96, 44);
            buttonLogIn.TabIndex = 13;
            buttonLogIn.Text = "Log In";
            buttonLogIn.UseVisualStyleBackColor = false;
            buttonLogIn.Click += buttonLogIn_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.FromArgb(64, 64, 64);
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.ForeColor = Color.White;
            textBoxPassword.Location = new Point(197, 258);
            textBoxPassword.MaxLength = 30;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(341, 36);
            textBoxPassword.TabIndex = 12;
            textBoxPassword.KeyDown += textBoxPassword_KeyDown;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.FromArgb(64, 64, 64);
            textBoxEmail.BorderStyle = BorderStyle.None;
            textBoxEmail.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.ForeColor = Color.White;
            textBoxEmail.Location = new Point(197, 211);
            textBoxEmail.MaxLength = 30;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(341, 36);
            textBoxEmail.TabIndex = 11;
            textBoxEmail.KeyDown += textBoxEmail_KeyDown;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.BackColor = Color.Transparent;
            labelPassword.Font = new Font("Segoe UI Semilight", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.ForeColor = Color.White;
            labelPassword.Location = new Point(56, 258);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(126, 37);
            labelPassword.TabIndex = 10;
            labelPassword.Text = "Password";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.BackColor = Color.Transparent;
            labelEmail.Font = new Font("Segoe UI Semilight", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmail.ForeColor = Color.White;
            labelEmail.Location = new Point(56, 211);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(80, 37);
            labelEmail.TabIndex = 9;
            labelEmail.Text = "Email";
            // 
            // labelForgotPassword
            // 
            labelForgotPassword.AutoSize = true;
            labelForgotPassword.BackColor = Color.Transparent;
            labelForgotPassword.Cursor = Cursors.Hand;
            labelForgotPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            labelForgotPassword.ForeColor = Color.White;
            labelForgotPassword.Location = new Point(417, 309);
            labelForgotPassword.Name = "labelForgotPassword";
            labelForgotPassword.Size = new Size(121, 20);
            labelForgotPassword.TabIndex = 17;
            labelForgotPassword.Text = "Forgot Password?";
            labelForgotPassword.Click += labelForgotPassword_Click;
            // 
            // labelAppName
            // 
            labelAppName.AutoSize = true;
            labelAppName.BackColor = Color.Transparent;
            labelAppName.Font = new Font("Snap ITC", 48F, FontStyle.Regular, GraphicsUnit.Point);
            labelAppName.ForeColor = Color.Khaki;
            labelAppName.Location = new Point(197, 59);
            labelAppName.Name = "labelAppName";
            labelAppName.Size = new Size(307, 82);
            labelAppName.TabIndex = 18;
            labelAppName.Text = "Type It";
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = Properties.Resources.kbbg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(699, 551);
            Controls.Add(labelAppName);
            Controls.Add(labelForgotPassword);
            Controls.Add(checkBoxShowPassword);
            Controls.Add(labelNoAccount);
            Controls.Add(buttonSignUp);
            Controls.Add(buttonLogIn);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxEmail);
            Controls.Add(labelPassword);
            Controls.Add(labelEmail);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private Label labelForgotPassword;
        private Label labelAppName;
    }
}