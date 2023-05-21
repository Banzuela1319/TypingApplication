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
            buttonContinue = new Button();
            labelWPM = new Label();
            labelAccuracy = new Label();
            labelAppName = new Label();
            labelWPMResult = new Label();
            labelAccuracyResult = new Label();
            SuspendLayout();
            // 
            // buttonContinue
            // 
            buttonContinue.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonContinue.Location = new Point(296, 326);
            buttonContinue.Name = "buttonContinue";
            buttonContinue.Size = new Size(197, 55);
            buttonContinue.TabIndex = 0;
            buttonContinue.Text = "Continue Test";
            buttonContinue.UseVisualStyleBackColor = true;
            buttonContinue.Click += buttonContinue_Click;
            // 
            // labelWPM
            // 
            labelWPM.AutoSize = true;
            labelWPM.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelWPM.Location = new Point(35, 151);
            labelWPM.Name = "labelWPM";
            labelWPM.Size = new Size(109, 50);
            labelWPM.TabIndex = 1;
            labelWPM.Text = "wpm";
            // 
            // labelAccuracy
            // 
            labelAccuracy.AutoSize = true;
            labelAccuracy.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelAccuracy.Location = new Point(35, 238);
            labelAccuracy.Name = "labelAccuracy";
            labelAccuracy.Size = new Size(173, 50);
            labelAccuracy.TabIndex = 2;
            labelAccuracy.Text = "accuracy";
            // 
            // labelAppName
            // 
            labelAppName.AutoSize = true;
            labelAppName.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            labelAppName.Location = new Point(12, 9);
            labelAppName.Name = "labelAppName";
            labelAppName.Size = new Size(244, 86);
            labelAppName.TabIndex = 16;
            labelAppName.Text = "TYPE IT";
            // 
            // labelWPMResult
            // 
            labelWPMResult.AutoSize = true;
            labelWPMResult.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelWPMResult.Location = new Point(235, 151);
            labelWPMResult.Name = "labelWPMResult";
            labelWPMResult.Size = new Size(207, 50);
            labelWPMResult.TabIndex = 17;
            labelWPMResult.Text = "wpmresult";
            // 
            // labelAccuracyResult
            // 
            labelAccuracyResult.AutoSize = true;
            labelAccuracyResult.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelAccuracyResult.Location = new Point(235, 238);
            labelAccuracyResult.Name = "labelAccuracyResult";
            labelAccuracyResult.Size = new Size(271, 50);
            labelAccuracyResult.TabIndex = 18;
            labelAccuracyResult.Text = "accuracyresult";
            // 
            // Result
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 421);
            Controls.Add(labelAccuracyResult);
            Controls.Add(labelWPMResult);
            Controls.Add(labelAppName);
            Controls.Add(labelAccuracy);
            Controls.Add(labelWPM);
            Controls.Add(buttonContinue);
            Name = "Result";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Result";
            Load += Result_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonContinue;
        private Label labelWPM;
        private Label labelAccuracy;
        private Label labelAppName;
        private Label labelWPMResult;
        private Label labelAccuracyResult;
    }
}