namespace TypingApplication
{
    partial class ForgotPassword
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
            components = new System.ComponentModel.Container();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            labelPlease = new Label();
            labelCode = new Label();
            textBoxCode = new TextBox();
            buttonVerificationCode = new Button();
            timerGetCode = new System.Windows.Forms.Timer(components);
            labeltimeout = new Label();
            buttonSubmit = new Button();
            labelCodeError = new Label();
            textBoxPassword = new TextBox();
            labelPassword = new Label();
            buttonSaveChanges = new Button();
            labelPasswordError = new Label();
            SuspendLayout();
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.Location = new Point(100, 81);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(322, 43);
            textBoxEmail.TabIndex = 0;
            textBoxEmail.TextChanged += textBoxEmail_TextChanged;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmail.Location = new Point(12, 87);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(82, 37);
            labelEmail.TabIndex = 1;
            labelEmail.Text = "Email";
            // 
            // labelPlease
            // 
            labelPlease.AutoSize = true;
            labelPlease.Font = new Font("Segoe UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelPlease.Location = new Point(100, 127);
            labelPlease.Name = "labelPlease";
            labelPlease.Size = new Size(269, 17);
            labelPlease.TabIndex = 2;
            labelPlease.Text = "Please enter your email to reset your password";
            // 
            // labelCode
            // 
            labelCode.AutoSize = true;
            labelCode.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelCode.Location = new Point(12, 238);
            labelCode.Name = "labelCode";
            labelCode.Size = new Size(80, 37);
            labelCode.TabIndex = 3;
            labelCode.Text = "Code";
            labelCode.Visible = false;
            // 
            // textBoxCode
            // 
            textBoxCode.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCode.Location = new Point(98, 235);
            textBoxCode.Name = "textBoxCode";
            textBoxCode.Size = new Size(322, 43);
            textBoxCode.TabIndex = 4;
            textBoxCode.Visible = false;
            textBoxCode.MouseClick += textBoxCode_MouseClick;
            textBoxCode.TextChanged += textBoxCode_TextChanged;
            // 
            // buttonVerificationCode
            // 
            buttonVerificationCode.Enabled = false;
            buttonVerificationCode.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonVerificationCode.Location = new Point(100, 147);
            buttonVerificationCode.Name = "buttonVerificationCode";
            buttonVerificationCode.Size = new Size(225, 38);
            buttonVerificationCode.TabIndex = 5;
            buttonVerificationCode.Text = "Get Verification Code";
            buttonVerificationCode.UseVisualStyleBackColor = true;
            buttonVerificationCode.Click += buttonVerificationCode_Click;
            // 
            // timerGetCode
            // 
            timerGetCode.Interval = 1000;
            timerGetCode.Tick += timerGetCode_Tick;
            // 
            // labeltimeout
            // 
            labeltimeout.AutoSize = true;
            labeltimeout.Font = new Font("Segoe UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labeltimeout.Location = new Point(100, 188);
            labeltimeout.Name = "labeltimeout";
            labeltimeout.Size = new Size(37, 17);
            labeltimeout.TabIndex = 6;
            labeltimeout.Text = "timer";
            labeltimeout.Visible = false;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Enabled = false;
            buttonSubmit.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSubmit.Location = new Point(98, 301);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(93, 38);
            buttonSubmit.TabIndex = 7;
            buttonSubmit.Text = "Sumbit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Visible = false;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // labelCodeError
            // 
            labelCodeError.AutoSize = true;
            labelCodeError.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            labelCodeError.ForeColor = Color.Red;
            labelCodeError.Location = new Point(100, 281);
            labelCodeError.Name = "labelCodeError";
            labelCodeError.Size = new Size(109, 17);
            labelCodeError.TabIndex = 8;
            labelCodeError.Text = "Code didn't match";
            labelCodeError.Visible = false;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(56, 142);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(322, 43);
            textBoxPassword.TabIndex = 9;
            textBoxPassword.Visible = false;
            textBoxPassword.MouseClick += textBoxPassword_MouseClick;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.Location = new Point(89, 81);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(257, 37);
            labelPassword.TabIndex = 10;
            labelPassword.Text = "Enter New Password";
            labelPassword.Visible = false;
            // 
            // buttonSaveChanges
            // 
            buttonSaveChanges.Enabled = false;
            buttonSaveChanges.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSaveChanges.Location = new Point(136, 208);
            buttonSaveChanges.Name = "buttonSaveChanges";
            buttonSaveChanges.Size = new Size(159, 38);
            buttonSaveChanges.TabIndex = 11;
            buttonSaveChanges.Text = "Save Changes";
            buttonSaveChanges.UseVisualStyleBackColor = true;
            buttonSaveChanges.Visible = false;
            buttonSaveChanges.Click += buttonSaveChanges_Click;
            // 
            // labelPasswordError
            // 
            labelPasswordError.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            labelPasswordError.ForeColor = SystemColors.ControlText;
            labelPasswordError.Location = new Point(24, 188);
            labelPasswordError.Name = "labelPasswordError";
            labelPasswordError.Size = new Size(382, 17);
            labelPasswordError.TabIndex = 12;
            labelPasswordError.Text = "Use 8 or more characters with a mix of letters, numbers and symbols";
            labelPasswordError.TextAlign = ContentAlignment.MiddleCenter;
            labelPasswordError.Visible = false;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 361);
            Controls.Add(labelPasswordError);
            Controls.Add(buttonSaveChanges);
            Controls.Add(labelPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(labelCodeError);
            Controls.Add(buttonSubmit);
            Controls.Add(labeltimeout);
            Controls.Add(buttonVerificationCode);
            Controls.Add(textBoxCode);
            Controls.Add(labelCode);
            Controls.Add(labelPlease);
            Controls.Add(labelEmail);
            Controls.Add(textBoxEmail);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "ForgotPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forgot Password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxEmail;
        private Label labelEmail;
        private Label labelPlease;
        private Label labelCode;
        private TextBox textBoxCode;
        private Button buttonVerificationCode;
        private System.Windows.Forms.Timer timerGetCode;
        private Label labeltimeout;
        private Button buttonSubmit;
        private Label labelCodeError;
        private TextBox textBoxPassword;
        private Label labelPassword;
        private Button buttonSaveChanges;
        private Label labelPasswordError;
    }
}