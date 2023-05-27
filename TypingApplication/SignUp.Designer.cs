namespace TypingApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
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
            labelNameError.BackColor = Color.Transparent;
            labelNameError.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            labelNameError.ForeColor = Color.Red;
            labelNameError.Location = new Point(190, 192);
            labelNameError.Name = "labelNameError";
            labelNameError.Size = new Size(88, 17);
            labelNameError.TabIndex = 26;
            labelNameError.Text = "Invalid Format";
            labelNameError.Visible = false;
            // 
            // buttonLogInInstead
            // 
            buttonLogInInstead.BackColor = Color.Transparent;
            buttonLogInInstead.Cursor = Cursors.Hand;
            buttonLogInInstead.FlatAppearance.BorderSize = 0;
            buttonLogInInstead.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonLogInInstead.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonLogInInstead.FlatStyle = FlatStyle.Flat;
            buttonLogInInstead.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogInInstead.ForeColor = Color.White;
            buttonLogInInstead.Location = new Point(37, 471);
            buttonLogInInstead.Name = "buttonLogInInstead";
            buttonLogInInstead.Size = new Size(129, 39);
            buttonLogInInstead.TabIndex = 25;
            buttonLogInInstead.Text = "Log In Instead";
            buttonLogInInstead.UseVisualStyleBackColor = false;
            buttonLogInInstead.Click += buttonLogInInstead_Click;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.FromArgb(64, 64, 64);
            textBoxEmail.BorderStyle = BorderStyle.None;
            textBoxEmail.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.ForeColor = Color.White;
            textBoxEmail.Location = new Point(190, 222);
            textBoxEmail.MaxLength = 30;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(392, 36);
            textBoxEmail.TabIndex = 15;
            textBoxEmail.MouseClick += textBoxEmail_MouseClick;
            textBoxEmail.KeyDown += textBoxEmail_KeyDown;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.BackColor = Color.Transparent;
            labelName.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.ForeColor = Color.White;
            labelName.Location = new Point(46, 149);
            labelName.Name = "labelName";
            labelName.Size = new Size(85, 37);
            labelName.TabIndex = 24;
            labelName.Text = "Name";
            // 
            // checkBoxShowPassword
            // 
            checkBoxShowPassword.AutoSize = true;
            checkBoxShowPassword.BackColor = Color.Transparent;
            checkBoxShowPassword.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxShowPassword.ForeColor = Color.White;
            checkBoxShowPassword.Location = new Point(190, 364);
            checkBoxShowPassword.Name = "checkBoxShowPassword";
            checkBoxShowPassword.Size = new Size(161, 29);
            checkBoxShowPassword.TabIndex = 23;
            checkBoxShowPassword.Text = "Show Password";
            checkBoxShowPassword.UseVisualStyleBackColor = false;
            checkBoxShowPassword.CheckedChanged += checkBoxShowPassword_CheckedChanged;
            // 
            // labelCreate
            // 
            labelCreate.AutoSize = true;
            labelCreate.BackColor = Color.Transparent;
            labelCreate.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelCreate.ForeColor = Color.White;
            labelCreate.Location = new Point(230, 45);
            labelCreate.Name = "labelCreate";
            labelCreate.Size = new Size(257, 40);
            labelCreate.TabIndex = 22;
            labelCreate.Text = "Create an Account";
            // 
            // buttonSignUp
            // 
            buttonSignUp.BackColor = Color.Transparent;
            buttonSignUp.Cursor = Cursors.Hand;
            buttonSignUp.FlatAppearance.BorderSize = 0;
            buttonSignUp.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonSignUp.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonSignUp.FlatStyle = FlatStyle.Flat;
            buttonSignUp.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSignUp.ForeColor = Color.White;
            buttonSignUp.Location = new Point(294, 413);
            buttonSignUp.Name = "buttonSignUp";
            buttonSignUp.Size = new Size(136, 59);
            buttonSignUp.TabIndex = 19;
            buttonSignUp.Text = "Sign Up";
            buttonSignUp.UseVisualStyleBackColor = false;
            buttonSignUp.Click += buttonSignUp_Click;
            // 
            // labelPasswordError
            // 
            labelPasswordError.AutoSize = true;
            labelPasswordError.BackColor = Color.Transparent;
            labelPasswordError.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            labelPasswordError.ForeColor = Color.White;
            labelPasswordError.Location = new Point(190, 344);
            labelPasswordError.Name = "labelPasswordError";
            labelPasswordError.Size = new Size(392, 17);
            labelPasswordError.TabIndex = 21;
            labelPasswordError.Text = "Use 8 or more characters with a mix of letters, numbers and symbols";
            // 
            // labelEmailError
            // 
            labelEmailError.AutoSize = true;
            labelEmailError.BackColor = Color.Transparent;
            labelEmailError.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            labelEmailError.ForeColor = Color.Red;
            labelEmailError.Location = new Point(190, 268);
            labelEmailError.Name = "labelEmailError";
            labelEmailError.Size = new Size(88, 17);
            labelEmailError.TabIndex = 20;
            labelEmailError.Text = "Invalid Format";
            labelEmailError.Visible = false;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.FromArgb(64, 64, 64);
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.ForeColor = Color.White;
            textBoxPassword.Location = new Point(190, 298);
            textBoxPassword.MaxLength = 30;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(392, 36);
            textBoxPassword.TabIndex = 17;
            textBoxPassword.MouseClick += textBoxPassword_MouseClick;
            textBoxPassword.KeyDown += textBoxPassword_KeyDown;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.BackColor = Color.Transparent;
            labelPassword.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.ForeColor = Color.White;
            labelPassword.Location = new Point(46, 301);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(120, 37);
            labelPassword.TabIndex = 18;
            labelPassword.Text = "Password";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.BackColor = Color.Transparent;
            labelEmail.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmail.ForeColor = Color.White;
            labelEmail.Location = new Point(46, 225);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(78, 37);
            labelEmail.TabIndex = 16;
            labelEmail.Text = "Email";
            // 
            // textBoxName
            // 
            textBoxName.BackColor = Color.FromArgb(64, 64, 64);
            textBoxName.BorderStyle = BorderStyle.None;
            textBoxName.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.ForeColor = Color.White;
            textBoxName.Location = new Point(190, 149);
            textBoxName.MaxLength = 50;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(392, 36);
            textBoxName.TabIndex = 14;
            textBoxName.MouseClick += textBoxName_MouseClick;
            textBoxName.KeyDown += textBoxName_KeyDown;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.kbbg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(699, 551);
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
            DoubleBuffered = true;
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Type It";
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