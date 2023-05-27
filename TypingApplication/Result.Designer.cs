namespace TypingApplication
{
    partial class Result
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Result));
            buttonContinue = new Button();
            labelWPM = new Label();
            labelAccuracy = new Label();
            labelWPMResult = new Label();
            labelAccuracyResult = new Label();
            labelAppName = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonContinue
            // 
            buttonContinue.BackColor = Color.Transparent;
            buttonContinue.Cursor = Cursors.Hand;
            buttonContinue.FlatAppearance.BorderSize = 0;
            buttonContinue.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonContinue.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonContinue.FlatStyle = FlatStyle.Flat;
            buttonContinue.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonContinue.ForeColor = Color.Khaki;
            buttonContinue.Location = new Point(296, 326);
            buttonContinue.Name = "buttonContinue";
            buttonContinue.Size = new Size(197, 55);
            buttonContinue.TabIndex = 0;
            buttonContinue.Text = "Continue Test";
            buttonContinue.UseVisualStyleBackColor = false;
            buttonContinue.Click += buttonContinue_Click;
            // 
            // labelWPM
            // 
            labelWPM.AutoSize = true;
            labelWPM.BackColor = Color.FromArgb(64, 64, 64);
            labelWPM.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelWPM.ForeColor = Color.Khaki;
            labelWPM.Location = new Point(35, 151);
            labelWPM.Name = "labelWPM";
            labelWPM.Size = new Size(109, 50);
            labelWPM.TabIndex = 1;
            labelWPM.Text = "wpm";
            // 
            // labelAccuracy
            // 
            labelAccuracy.AutoSize = true;
            labelAccuracy.BackColor = Color.FromArgb(64, 64, 64);
            labelAccuracy.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelAccuracy.ForeColor = Color.Khaki;
            labelAccuracy.Location = new Point(35, 238);
            labelAccuracy.Name = "labelAccuracy";
            labelAccuracy.Size = new Size(173, 50);
            labelAccuracy.TabIndex = 2;
            labelAccuracy.Text = "accuracy";
            // 
            // labelWPMResult
            // 
            labelWPMResult.AutoSize = true;
            labelWPMResult.BackColor = Color.FromArgb(64, 64, 64);
            labelWPMResult.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelWPMResult.ForeColor = Color.Khaki;
            labelWPMResult.Location = new Point(235, 151);
            labelWPMResult.Name = "labelWPMResult";
            labelWPMResult.Size = new Size(207, 50);
            labelWPMResult.TabIndex = 17;
            labelWPMResult.Text = "wpmresult";
            // 
            // labelAccuracyResult
            // 
            labelAccuracyResult.AutoSize = true;
            labelAccuracyResult.BackColor = Color.FromArgb(64, 64, 64);
            labelAccuracyResult.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelAccuracyResult.ForeColor = Color.Khaki;
            labelAccuracyResult.Location = new Point(235, 238);
            labelAccuracyResult.Name = "labelAccuracyResult";
            labelAccuracyResult.Size = new Size(271, 50);
            labelAccuracyResult.TabIndex = 18;
            labelAccuracyResult.Text = "accuracyresult";
            // 
            // labelAppName
            // 
            labelAppName.AutoSize = true;
            labelAppName.BackColor = Color.Transparent;
            labelAppName.Font = new Font("Snap ITC", 48F, FontStyle.Regular, GraphicsUnit.Point);
            labelAppName.ForeColor = Color.Khaki;
            labelAppName.Location = new Point(12, 9);
            labelAppName.Name = "labelAppName";
            labelAppName.Size = new Size(307, 82);
            labelAppName.TabIndex = 20;
            labelAppName.Text = "Type It";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(64, 64, 64);
            pictureBox1.Location = new Point(12, 123);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(510, 197);
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // Result
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.mainformbg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(534, 421);
            Controls.Add(labelAppName);
            Controls.Add(labelAccuracyResult);
            Controls.Add(labelWPMResult);
            Controls.Add(labelAccuracy);
            Controls.Add(labelWPM);
            Controls.Add(buttonContinue);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Result";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Type It";
            Load += Result_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonContinue;
        private Label labelWPM;
        private Label labelAccuracy;
        private Label labelWPMResult;
        private Label labelAccuracyResult;
        private Label labelAppName;
        private PictureBox pictureBox1;
    }
}