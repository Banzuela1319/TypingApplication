namespace TypingApplication
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            button60Words = new Button();
            button30Words = new Button();
            buttonSettings = new Button();
            buttonProfile = new Button();
            button10Words = new Button();
            richTextBoxWords = new RichTextBox();
            buttonLogOut = new Button();
            labelCapsOn = new Label();
            labelAppName = new Label();
            SuspendLayout();
            // 
            // button60Words
            // 
            button60Words.BackColor = Color.FromArgb(64, 64, 64);
            button60Words.Cursor = Cursors.Hand;
            button60Words.FlatAppearance.BorderColor = Color.Khaki;
            button60Words.FlatAppearance.BorderSize = 2;
            button60Words.FlatAppearance.MouseDownBackColor = Color.Black;
            button60Words.FlatStyle = FlatStyle.Flat;
            button60Words.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button60Words.ForeColor = Color.Khaki;
            button60Words.Location = new Point(740, 58);
            button60Words.Name = "button60Words";
            button60Words.Size = new Size(107, 50);
            button60Words.TabIndex = 14;
            button60Words.TabStop = false;
            button60Words.Text = "60 Words";
            button60Words.UseVisualStyleBackColor = false;
            button60Words.Click += button60Words_Click;
            // 
            // button30Words
            // 
            button30Words.BackColor = Color.FromArgb(64, 64, 64);
            button30Words.Cursor = Cursors.Hand;
            button30Words.FlatAppearance.BorderColor = Color.Khaki;
            button30Words.FlatAppearance.BorderSize = 2;
            button30Words.FlatAppearance.MouseDownBackColor = Color.Black;
            button30Words.FlatStyle = FlatStyle.Flat;
            button30Words.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button30Words.ForeColor = Color.Khaki;
            button30Words.Location = new Point(606, 58);
            button30Words.Name = "button30Words";
            button30Words.Size = new Size(107, 50);
            button30Words.TabIndex = 13;
            button30Words.TabStop = false;
            button30Words.Text = "30 Words";
            button30Words.UseVisualStyleBackColor = false;
            button30Words.Click += button30Words_Click;
            // 
            // buttonSettings
            // 
            buttonSettings.BackColor = Color.Transparent;
            buttonSettings.Cursor = Cursors.Hand;
            buttonSettings.FlatAppearance.BorderSize = 0;
            buttonSettings.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonSettings.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonSettings.FlatStyle = FlatStyle.Flat;
            buttonSettings.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSettings.Image = Properties.Resources.settings;
            buttonSettings.Location = new Point(966, 58);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(40, 40);
            buttonSettings.TabIndex = 12;
            buttonSettings.TabStop = false;
            buttonSettings.UseVisualStyleBackColor = false;
            buttonSettings.Click += buttonSettings_Click;
            // 
            // buttonProfile
            // 
            buttonProfile.BackColor = Color.Transparent;
            buttonProfile.Cursor = Cursors.Hand;
            buttonProfile.FlatAppearance.BorderSize = 0;
            buttonProfile.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonProfile.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonProfile.FlatStyle = FlatStyle.Flat;
            buttonProfile.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonProfile.Image = Properties.Resources.profile;
            buttonProfile.Location = new Point(1023, 58);
            buttonProfile.Name = "buttonProfile";
            buttonProfile.Size = new Size(40, 40);
            buttonProfile.TabIndex = 11;
            buttonProfile.TabStop = false;
            buttonProfile.UseVisualStyleBackColor = false;
            buttonProfile.Click += buttonProfile_Click;
            // 
            // button10Words
            // 
            button10Words.BackColor = Color.FromArgb(64, 64, 64);
            button10Words.Cursor = Cursors.Hand;
            button10Words.FlatAppearance.BorderColor = Color.Khaki;
            button10Words.FlatAppearance.BorderSize = 2;
            button10Words.FlatAppearance.MouseDownBackColor = Color.Black;
            button10Words.FlatStyle = FlatStyle.Flat;
            button10Words.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button10Words.ForeColor = Color.Khaki;
            button10Words.Location = new Point(472, 58);
            button10Words.Name = "button10Words";
            button10Words.Size = new Size(107, 50);
            button10Words.TabIndex = 10;
            button10Words.TabStop = false;
            button10Words.Text = "10 Words";
            button10Words.UseVisualStyleBackColor = false;
            button10Words.Click += button10Words_Click;
            // 
            // richTextBoxWords
            // 
            richTextBoxWords.BackColor = Color.FromArgb(64, 64, 64);
            richTextBoxWords.BorderStyle = BorderStyle.None;
            richTextBoxWords.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxWords.ForeColor = Color.White;
            richTextBoxWords.Location = new Point(86, 162);
            richTextBoxWords.Name = "richTextBoxWords";
            richTextBoxWords.ReadOnly = true;
            richTextBoxWords.Size = new Size(977, 407);
            richTextBoxWords.TabIndex = 1;
            richTextBoxWords.TabStop = false;
            richTextBoxWords.Text = "";
            richTextBoxWords.KeyDown += richTextBoxWords_KeyDown;
            richTextBoxWords.KeyPress += richTextBoxWords_KeyPress;
            // 
            // buttonLogOut
            // 
            buttonLogOut.BackColor = Color.Transparent;
            buttonLogOut.Cursor = Cursors.Hand;
            buttonLogOut.FlatAppearance.BorderSize = 0;
            buttonLogOut.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonLogOut.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonLogOut.FlatStyle = FlatStyle.Flat;
            buttonLogOut.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLogOut.Image = Properties.Resources.logout;
            buttonLogOut.Location = new Point(1097, 12);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(40, 40);
            buttonLogOut.TabIndex = 9;
            buttonLogOut.TabStop = false;
            buttonLogOut.UseVisualStyleBackColor = false;
            buttonLogOut.Click += buttonLogOut_Click;
            // 
            // labelCapsOn
            // 
            labelCapsOn.AutoSize = true;
            labelCapsOn.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelCapsOn.ForeColor = Color.Khaki;
            labelCapsOn.Location = new Point(459, 585);
            labelCapsOn.Name = "labelCapsOn";
            labelCapsOn.Size = new Size(232, 45);
            labelCapsOn.TabIndex = 16;
            labelCapsOn.Text = "Capslock is on";
            labelCapsOn.Visible = false;
            // 
            // labelAppName
            // 
            labelAppName.AutoSize = true;
            labelAppName.BackColor = Color.Transparent;
            labelAppName.Font = new Font("Snap ITC", 48F, FontStyle.Regular, GraphicsUnit.Point);
            labelAppName.ForeColor = Color.Khaki;
            labelAppName.Location = new Point(56, 40);
            labelAppName.Name = "labelAppName";
            labelAppName.Size = new Size(307, 82);
            labelAppName.TabIndex = 19;
            labelAppName.Text = "Type It";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImage = Properties.Resources.mainformbg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1149, 655);
            Controls.Add(labelAppName);
            Controls.Add(labelCapsOn);
            Controls.Add(button60Words);
            Controls.Add(button30Words);
            Controls.Add(buttonSettings);
            Controls.Add(buttonProfile);
            Controls.Add(button10Words);
            Controls.Add(richTextBoxWords);
            Controls.Add(buttonLogOut);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Type It";
            Load += Main_Load;
            KeyDown += Main_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button60Words;
        private Button button30Words;
        private Button buttonSettings;
        private Button buttonProfile;
        private Button button10Words;
        private RichTextBox richTextBoxWords;
        private Button buttonLogOut;
        private Label labelCapsOn;
        private Label labelAppName;
    }
}