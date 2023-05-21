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
            labelAppName = new Label();
            button60Words = new Button();
            button30Words = new Button();
            buttonSettings = new Button();
            buttonProfile = new Button();
            button10Words = new Button();
            richTextBoxWords = new RichTextBox();
            buttonLogOut = new Button();
            labelCapsOn = new Label();
            SuspendLayout();
            // 
            // labelAppName
            // 
            labelAppName.AutoSize = true;
            labelAppName.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            labelAppName.Location = new Point(55, 36);
            labelAppName.Name = "labelAppName";
            labelAppName.Size = new Size(244, 86);
            labelAppName.TabIndex = 15;
            labelAppName.Text = "TYPE IT";
            // 
            // button60Words
            // 
            button60Words.Cursor = Cursors.Hand;
            button60Words.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button60Words.Location = new Point(700, 58);
            button60Words.Name = "button60Words";
            button60Words.Size = new Size(100, 50);
            button60Words.TabIndex = 14;
            button60Words.TabStop = false;
            button60Words.Text = "60 Words";
            button60Words.UseVisualStyleBackColor = true;
            button60Words.Click += button60Words_Click;
            // 
            // button30Words
            // 
            button30Words.Cursor = Cursors.Hand;
            button30Words.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button30Words.Location = new Point(574, 58);
            button30Words.Name = "button30Words";
            button30Words.Size = new Size(100, 50);
            button30Words.TabIndex = 13;
            button30Words.TabStop = false;
            button30Words.Text = "30 Words";
            button30Words.UseVisualStyleBackColor = true;
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
            // 
            // button10Words
            // 
            button10Words.Cursor = Cursors.Hand;
            button10Words.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button10Words.Location = new Point(447, 58);
            button10Words.Name = "button10Words";
            button10Words.Size = new Size(100, 50);
            button10Words.TabIndex = 10;
            button10Words.TabStop = false;
            button10Words.Text = "10 Words";
            button10Words.UseVisualStyleBackColor = true;
            button10Words.Click += button10Words_Click;
            // 
            // richTextBoxWords
            // 
            richTextBoxWords.BorderStyle = BorderStyle.None;
            richTextBoxWords.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxWords.ForeColor = SystemColors.WindowText;
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
            labelCapsOn.Location = new Point(459, 585);
            labelCapsOn.Name = "labelCapsOn";
            labelCapsOn.Size = new Size(232, 45);
            labelCapsOn.TabIndex = 16;
            labelCapsOn.Text = "Capslock is on";
            labelCapsOn.Visible = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1149, 655);
            Controls.Add(labelCapsOn);
            Controls.Add(labelAppName);
            Controls.Add(button60Words);
            Controls.Add(button30Words);
            Controls.Add(buttonSettings);
            Controls.Add(buttonProfile);
            Controls.Add(button10Words);
            Controls.Add(richTextBoxWords);
            Controls.Add(buttonLogOut);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Main_Load;
            KeyDown += Main_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAppName;
        private Button button60Words;
        private Button button30Words;
        private Button buttonSettings;
        private Button buttonProfile;
        private Button button10Words;
        private RichTextBox richTextBoxWords;
        private Button buttonLogOut;
        private Label labelCapsOn;
    }
}