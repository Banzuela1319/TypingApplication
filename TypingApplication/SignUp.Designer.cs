﻿namespace TypingApplication
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
            labelNameError = new Label();
            buttonLogInInstead = new Button();
            textBoxEmail = new TextBox();
            labelName = new Label();
            checkBoxShowPassword = new CheckBox();
            labelCreate = new Label();
            buttonSignUp = new Button();
            labelPasswordError = new Label();
            labelEmailError = new Label();
            textBoxPassword = new TextBox();
            labelPassword = new Label();
            labelEmail = new Label();
            textBoxName = new TextBox();
            SuspendLayout();
            // 
            // labelNameError
            // 
            labelNameError.AutoSize = true;
            labelNameError.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            labelNameError.ForeColor = Color.Red;
            labelNameError.Location = new Point(165, 171);
            labelNameError.Name = "labelNameError";
            labelNameError.Size = new Size(88, 17);
            labelNameError.TabIndex = 26;
            labelNameError.Text = "Invalid Format";
            labelNameError.Visible = false;
            // 
            // buttonLogInInstead
            // 
            buttonLogInInstead.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogInInstead.Location = new Point(12, 450);
            buttonLogInInstead.Name = "buttonLogInInstead";
            buttonLogInInstead.Size = new Size(129, 39);
            buttonLogInInstead.TabIndex = 25;
            buttonLogInInstead.Text = "Log In Instead";
            buttonLogInInstead.UseVisualStyleBackColor = true;
            buttonLogInInstead.Click += buttonLogInInstead_Click;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.Location = new Point(165, 201);
            textBoxEmail.MaxLength = 30;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(392, 43);
            textBoxEmail.TabIndex = 15;
            textBoxEmail.MouseClick += textBoxEmail_MouseClick;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(21, 128);
            labelName.Name = "labelName";
            labelName.Size = new Size(85, 37);
            labelName.TabIndex = 24;
            labelName.Text = "Name";
            // 
            // checkBoxShowPassword
            // 
            checkBoxShowPassword.AutoSize = true;
            checkBoxShowPassword.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxShowPassword.Location = new Point(165, 343);
            checkBoxShowPassword.Name = "checkBoxShowPassword";
            checkBoxShowPassword.Size = new Size(161, 29);
            checkBoxShowPassword.TabIndex = 23;
            checkBoxShowPassword.Text = "Show Password";
            checkBoxShowPassword.UseVisualStyleBackColor = true;
            checkBoxShowPassword.CheckedChanged += checkBoxShowPassword_CheckedChanged;
            // 
            // labelCreate
            // 
            labelCreate.AutoSize = true;
            labelCreate.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelCreate.Location = new Point(192, 23);
            labelCreate.Name = "labelCreate";
            labelCreate.Size = new Size(257, 40);
            labelCreate.TabIndex = 22;
            labelCreate.Text = "Create an Account";
            // 
            // buttonSignUp
            // 
            buttonSignUp.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSignUp.Location = new Point(269, 392);
            buttonSignUp.Name = "buttonSignUp";
            buttonSignUp.Size = new Size(136, 59);
            buttonSignUp.TabIndex = 19;
            buttonSignUp.Text = "Sign Up";
            buttonSignUp.UseVisualStyleBackColor = true;
            buttonSignUp.Click += buttonSignUp_Click;
            // 
            // labelPasswordError
            // 
            labelPasswordError.AutoSize = true;
            labelPasswordError.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            labelPasswordError.Location = new Point(165, 323);
            labelPasswordError.Name = "labelPasswordError";
            labelPasswordError.Size = new Size(392, 17);
            labelPasswordError.TabIndex = 21;
            labelPasswordError.Text = "Use 8 or more characters with a mix of letters, numbers and symbols";
            // 
            // labelEmailError
            // 
            labelEmailError.AutoSize = true;
            labelEmailError.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            labelEmailError.ForeColor = Color.Red;
            labelEmailError.Location = new Point(165, 247);
            labelEmailError.Name = "labelEmailError";
            labelEmailError.Size = new Size(88, 17);
            labelEmailError.TabIndex = 20;
            labelEmailError.Text = "Invalid Format";
            labelEmailError.Visible = false;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(165, 277);
            textBoxPassword.MaxLength = 30;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(392, 43);
            textBoxPassword.TabIndex = 17;
            textBoxPassword.MouseClick += textBoxPassword_MouseClick;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.Location = new Point(21, 280);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(120, 37);
            labelPassword.TabIndex = 18;
            labelPassword.Text = "Password";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmail.Location = new Point(21, 204);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(78, 37);
            labelEmail.TabIndex = 16;
            labelEmail.Text = "Email";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(165, 128);
            textBoxName.MaxLength = 50;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(392, 43);
            textBoxName.TabIndex = 14;
            textBoxName.MouseClick += textBoxName_MouseClick;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 501);
            Controls.Add(labelNameError);
            Controls.Add(buttonLogInInstead);
            Controls.Add(textBoxEmail);
            Controls.Add(labelName);
            Controls.Add(checkBoxShowPassword);
            Controls.Add(labelCreate);
            Controls.Add(buttonSignUp);
            Controls.Add(labelPasswordError);
            Controls.Add(labelEmailError);
            Controls.Add(textBoxPassword);
            Controls.Add(labelPassword);
            Controls.Add(labelEmail);
            Controls.Add(textBoxName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign Up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNameError;
        private Button buttonLogInInstead;
        private TextBox textBoxEmail;
        private Label labelName;
        private CheckBox checkBoxShowPassword;
        private Label labelCreate;
        private Button buttonSignUp;
        private Label labelPasswordError;
        private Label labelEmailError;
        private TextBox textBoxPassword;
        private Label labelPassword;
        private Label labelEmail;
        private TextBox textBoxName;
    }
}