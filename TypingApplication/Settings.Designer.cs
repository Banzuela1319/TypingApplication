namespace TypingApplication
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            buttonBack = new Button();
            labelResetAccount1 = new Label();
            labelResetAccount2 = new Label();
            labelResetAccountWarning = new Label();
            buttonResetAccount = new Button();
            buttonDeleteAccount = new Button();
            labelDeleteAccountWarning = new Label();
            labelDeleteAccount2 = new Label();
            labelDeleteAccount1 = new Label();
            SuspendLayout();
            // 
            // buttonBack
            // 
            buttonBack.Cursor = Cursors.Hand;
            buttonBack.FlatAppearance.BorderSize = 0;
            buttonBack.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonBack.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Image = Properties.Resources.back;
            buttonBack.Location = new Point(12, 12);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(40, 40);
            buttonBack.TabIndex = 0;
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // labelResetAccount1
            // 
            labelResetAccount1.AutoSize = true;
            labelResetAccount1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelResetAccount1.ForeColor = Color.White;
            labelResetAccount1.Location = new Point(50, 98);
            labelResetAccount1.Name = "labelResetAccount1";
            labelResetAccount1.Size = new Size(199, 37);
            labelResetAccount1.TabIndex = 1;
            labelResetAccount1.Text = "Reset Account";
            // 
            // labelResetAccount2
            // 
            labelResetAccount2.AutoSize = true;
            labelResetAccount2.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelResetAccount2.ForeColor = Color.Khaki;
            labelResetAccount2.Location = new Point(50, 150);
            labelResetAccount2.Name = "labelResetAccount2";
            labelResetAccount2.Size = new Size(602, 37);
            labelResetAccount2.TabIndex = 2;
            labelResetAccount2.Text = "Completely resets the progress of your account.";
            // 
            // labelResetAccountWarning
            // 
            labelResetAccountWarning.AutoSize = true;
            labelResetAccountWarning.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelResetAccountWarning.ForeColor = Color.Red;
            labelResetAccountWarning.Location = new Point(60, 202);
            labelResetAccountWarning.Name = "labelResetAccountWarning";
            labelResetAccountWarning.Size = new Size(321, 30);
            labelResetAccountWarning.TabIndex = 3;
            labelResetAccountWarning.Text = "This action cannot be undone.";
            // 
            // buttonResetAccount
            // 
            buttonResetAccount.Cursor = Cursors.Hand;
            buttonResetAccount.FlatAppearance.BorderColor = Color.Red;
            buttonResetAccount.FlatAppearance.BorderSize = 2;
            buttonResetAccount.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonResetAccount.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonResetAccount.FlatStyle = FlatStyle.Flat;
            buttonResetAccount.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonResetAccount.ForeColor = Color.Khaki;
            buttonResetAccount.Location = new Point(819, 187);
            buttonResetAccount.Name = "buttonResetAccount";
            buttonResetAccount.Size = new Size(221, 55);
            buttonResetAccount.TabIndex = 4;
            buttonResetAccount.Text = "Reset Account";
            buttonResetAccount.UseVisualStyleBackColor = true;
            buttonResetAccount.Click += buttonResetAccount_Click;
            // 
            // buttonDeleteAccount
            // 
            buttonDeleteAccount.Cursor = Cursors.Hand;
            buttonDeleteAccount.FlatAppearance.BorderColor = Color.Red;
            buttonDeleteAccount.FlatAppearance.BorderSize = 2;
            buttonDeleteAccount.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonDeleteAccount.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonDeleteAccount.FlatStyle = FlatStyle.Flat;
            buttonDeleteAccount.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDeleteAccount.ForeColor = Color.Khaki;
            buttonDeleteAccount.Location = new Point(819, 374);
            buttonDeleteAccount.Name = "buttonDeleteAccount";
            buttonDeleteAccount.Size = new Size(221, 55);
            buttonDeleteAccount.TabIndex = 8;
            buttonDeleteAccount.Text = "Delete Account";
            buttonDeleteAccount.UseVisualStyleBackColor = true;
            buttonDeleteAccount.Click += buttonDeleteAccount_Click;
            // 
            // labelDeleteAccountWarning
            // 
            labelDeleteAccountWarning.AutoSize = true;
            labelDeleteAccountWarning.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelDeleteAccountWarning.ForeColor = Color.Red;
            labelDeleteAccountWarning.Location = new Point(60, 389);
            labelDeleteAccountWarning.Name = "labelDeleteAccountWarning";
            labelDeleteAccountWarning.Size = new Size(321, 30);
            labelDeleteAccountWarning.TabIndex = 7;
            labelDeleteAccountWarning.Text = "This action cannot be undone.";
            // 
            // labelDeleteAccount2
            // 
            labelDeleteAccount2.AutoSize = true;
            labelDeleteAccount2.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelDeleteAccount2.ForeColor = Color.Khaki;
            labelDeleteAccount2.Location = new Point(50, 337);
            labelDeleteAccount2.Name = "labelDeleteAccount2";
            labelDeleteAccount2.Size = new Size(670, 37);
            labelDeleteAccount2.TabIndex = 6;
            labelDeleteAccount2.Text = "Deletes your account and all the data connected to it.";
            // 
            // labelDeleteAccount1
            // 
            labelDeleteAccount1.AutoSize = true;
            labelDeleteAccount1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelDeleteAccount1.ForeColor = Color.White;
            labelDeleteAccount1.Location = new Point(50, 285);
            labelDeleteAccount1.Name = "labelDeleteAccount1";
            labelDeleteAccount1.Size = new Size(213, 37);
            labelDeleteAccount1.TabIndex = 5;
            labelDeleteAccount1.Text = "Delete Account";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1149, 655);
            Controls.Add(buttonDeleteAccount);
            Controls.Add(labelDeleteAccountWarning);
            Controls.Add(labelDeleteAccount2);
            Controls.Add(labelDeleteAccount1);
            Controls.Add(buttonResetAccount);
            Controls.Add(labelResetAccountWarning);
            Controls.Add(labelResetAccount2);
            Controls.Add(labelResetAccount1);
            Controls.Add(buttonBack);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Type It";
            Load += Settings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBack;
        private Label labelResetAccount1;
        private Label labelResetAccount2;
        private Label labelResetAccountWarning;
        private Button buttonResetAccount;
        private Button buttonDeleteAccount;
        private Label labelDeleteAccountWarning;
        private Label labelDeleteAccount2;
        private Label labelDeleteAccount1;
    }
}