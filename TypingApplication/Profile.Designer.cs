namespace TypingApplication
{
    partial class Profile
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
            label10Words = new Label();
            label30Words = new Label();
            label60Words = new Label();
            labelName = new Label();
            labelAverageAccuracy = new Label();
            labelHighestAccuracy = new Label();
            labelAverageWPM = new Label();
            labelHighestWPM = new Label();
            label10AA = new Label();
            label30AA = new Label();
            label60AA = new Label();
            label10HA = new Label();
            label30HA = new Label();
            label60HA = new Label();
            label10AW = new Label();
            label30AW = new Label();
            label60AW = new Label();
            label60HW = new Label();
            label30HW = new Label();
            label10HW = new Label();
            buttonContinue = new Button();
            listViewHistory = new ListView();
            firstColumn = new ColumnHeader();
            mode = new ColumnHeader();
            wpm = new ColumnHeader();
            accuracy = new ColumnHeader();
            labelPadding = new Label();
            SuspendLayout();
            // 
            // label10Words
            // 
            label10Words.AutoSize = true;
            label10Words.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label10Words.Location = new Point(400, 100);
            label10Words.Name = "label10Words";
            label10Words.Size = new Size(195, 54);
            label10Words.TabIndex = 0;
            label10Words.Text = "10 words";
            // 
            // label30Words
            // 
            label30Words.AutoSize = true;
            label30Words.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label30Words.Location = new Point(650, 100);
            label30Words.Name = "label30Words";
            label30Words.Size = new Size(195, 54);
            label30Words.TabIndex = 1;
            label30Words.Text = "30 words";
            // 
            // label60Words
            // 
            label60Words.AutoSize = true;
            label60Words.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label60Words.Location = new Point(900, 100);
            label60Words.Name = "label60Words";
            label60Words.Size = new Size(195, 54);
            label60Words.TabIndex = 2;
            label60Words.Text = "60 words";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 39.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.Location = new Point(55, -14);
            labelName.Name = "labelName";
            labelName.Size = new Size(306, 71);
            labelName.TabIndex = 3;
            labelName.Text = "Your Name";
            // 
            // labelAverageAccuracy
            // 
            labelAverageAccuracy.AutoSize = true;
            labelAverageAccuracy.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelAverageAccuracy.Location = new Point(55, 210);
            labelAverageAccuracy.Name = "labelAverageAccuracy";
            labelAverageAccuracy.Size = new Size(275, 45);
            labelAverageAccuracy.TabIndex = 6;
            labelAverageAccuracy.Text = "average accuracy";
            // 
            // labelHighestAccuracy
            // 
            labelHighestAccuracy.AutoSize = true;
            labelHighestAccuracy.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelHighestAccuracy.Location = new Point(55, 290);
            labelHighestAccuracy.Name = "labelHighestAccuracy";
            labelHighestAccuracy.Size = new Size(267, 45);
            labelHighestAccuracy.TabIndex = 17;
            labelHighestAccuracy.Text = "highest accuracy";
            // 
            // labelAverageWPM
            // 
            labelAverageWPM.AutoSize = true;
            labelAverageWPM.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelAverageWPM.Location = new Point(55, 370);
            labelAverageWPM.Name = "labelAverageWPM";
            labelAverageWPM.Size = new Size(222, 45);
            labelAverageWPM.TabIndex = 18;
            labelAverageWPM.Text = "average wpm";
            // 
            // labelHighestWPM
            // 
            labelHighestWPM.AutoSize = true;
            labelHighestWPM.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelHighestWPM.Location = new Point(55, 450);
            labelHighestWPM.Name = "labelHighestWPM";
            labelHighestWPM.Size = new Size(214, 45);
            labelHighestWPM.TabIndex = 19;
            labelHighestWPM.Text = "highest wpm";
            // 
            // label10AA
            // 
            label10AA.AutoSize = true;
            label10AA.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label10AA.Location = new Point(457, 210);
            label10AA.Name = "label10AA";
            label10AA.Size = new Size(102, 45);
            label10AA.TabIndex = 20;
            label10AA.Text = "100%";
            // 
            // label30AA
            // 
            label30AA.AutoSize = true;
            label30AA.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label30AA.Location = new Point(707, 210);
            label30AA.Name = "label30AA";
            label30AA.Size = new Size(102, 45);
            label30AA.TabIndex = 21;
            label30AA.Text = "100%";
            // 
            // label60AA
            // 
            label60AA.AutoSize = true;
            label60AA.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label60AA.Location = new Point(957, 210);
            label60AA.Name = "label60AA";
            label60AA.Size = new Size(102, 45);
            label60AA.TabIndex = 22;
            label60AA.Text = "100%";
            // 
            // label10HA
            // 
            label10HA.AutoSize = true;
            label10HA.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label10HA.Location = new Point(457, 290);
            label10HA.Name = "label10HA";
            label10HA.Size = new Size(102, 45);
            label10HA.TabIndex = 23;
            label10HA.Text = "100%";
            // 
            // label30HA
            // 
            label30HA.AutoSize = true;
            label30HA.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label30HA.Location = new Point(707, 290);
            label30HA.Name = "label30HA";
            label30HA.Size = new Size(102, 45);
            label30HA.TabIndex = 24;
            label30HA.Text = "100%";
            // 
            // label60HA
            // 
            label60HA.AutoSize = true;
            label60HA.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label60HA.Location = new Point(957, 290);
            label60HA.Name = "label60HA";
            label60HA.Size = new Size(102, 45);
            label60HA.TabIndex = 25;
            label60HA.Text = "100%";
            // 
            // label10AW
            // 
            label10AW.AutoSize = true;
            label10AW.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label10AW.Location = new Point(457, 370);
            label10AW.Name = "label10AW";
            label10AW.Size = new Size(74, 45);
            label10AW.TabIndex = 26;
            label10AW.Text = "100";
            // 
            // label30AW
            // 
            label30AW.AutoSize = true;
            label30AW.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label30AW.Location = new Point(707, 370);
            label30AW.Name = "label30AW";
            label30AW.Size = new Size(74, 45);
            label30AW.TabIndex = 27;
            label30AW.Text = "100";
            // 
            // label60AW
            // 
            label60AW.AutoSize = true;
            label60AW.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label60AW.Location = new Point(957, 370);
            label60AW.Name = "label60AW";
            label60AW.Size = new Size(74, 45);
            label60AW.TabIndex = 28;
            label60AW.Text = "100";
            // 
            // label60HW
            // 
            label60HW.AutoSize = true;
            label60HW.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label60HW.Location = new Point(957, 450);
            label60HW.Name = "label60HW";
            label60HW.Size = new Size(74, 45);
            label60HW.TabIndex = 29;
            label60HW.Text = "100";
            // 
            // label30HW
            // 
            label30HW.AutoSize = true;
            label30HW.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label30HW.Location = new Point(707, 450);
            label30HW.Name = "label30HW";
            label30HW.Size = new Size(74, 45);
            label30HW.TabIndex = 30;
            label30HW.Text = "100";
            // 
            // label10HW
            // 
            label10HW.AutoSize = true;
            label10HW.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label10HW.Location = new Point(457, 450);
            label10HW.Name = "label10HW";
            label10HW.Size = new Size(74, 45);
            label10HW.TabIndex = 31;
            label10HW.Text = "100";
            // 
            // buttonContinue
            // 
            buttonContinue.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonContinue.Location = new Point(940, 576);
            buttonContinue.Name = "buttonContinue";
            buttonContinue.Size = new Size(176, 55);
            buttonContinue.TabIndex = 32;
            buttonContinue.TabStop = false;
            buttonContinue.Text = "Continue Test";
            buttonContinue.UseVisualStyleBackColor = true;
            buttonContinue.Click += buttonContinue_Click;
            // 
            // listViewHistory
            // 
            listViewHistory.Columns.AddRange(new ColumnHeader[] { firstColumn, mode, wpm, accuracy });
            listViewHistory.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            listViewHistory.Location = new Point(266, 673);
            listViewHistory.Name = "listViewHistory";
            listViewHistory.Size = new Size(621, 600);
            listViewHistory.TabIndex = 33;
            listViewHistory.TabStop = false;
            listViewHistory.UseCompatibleStateImageBehavior = false;
            listViewHistory.View = View.Details;
            // 
            // firstColumn
            // 
            firstColumn.Text = "";
            firstColumn.Width = 0;
            // 
            // mode
            // 
            mode.Text = "mode";
            mode.TextAlign = HorizontalAlignment.Center;
            mode.Width = 200;
            // 
            // wpm
            // 
            wpm.Text = "wpm";
            wpm.TextAlign = HorizontalAlignment.Center;
            wpm.Width = 200;
            // 
            // accuracy
            // 
            accuracy.Text = "accuracy";
            accuracy.TextAlign = HorizontalAlignment.Center;
            accuracy.Width = 200;
            // 
            // labelPadding
            // 
            labelPadding.AutoSize = true;
            labelPadding.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            labelPadding.Location = new Point(451, 1276);
            labelPadding.Name = "labelPadding";
            labelPadding.Size = new Size(0, 65);
            labelPadding.TabIndex = 34;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1149, 655);
            Controls.Add(labelPadding);
            Controls.Add(listViewHistory);
            Controls.Add(buttonContinue);
            Controls.Add(label10HW);
            Controls.Add(label30HW);
            Controls.Add(label60HW);
            Controls.Add(label60AW);
            Controls.Add(label30AW);
            Controls.Add(label10AW);
            Controls.Add(label60HA);
            Controls.Add(label30HA);
            Controls.Add(label10HA);
            Controls.Add(label60AA);
            Controls.Add(label30AA);
            Controls.Add(label10AA);
            Controls.Add(labelHighestWPM);
            Controls.Add(labelAverageWPM);
            Controls.Add(labelHighestAccuracy);
            Controls.Add(labelAverageAccuracy);
            Controls.Add(labelName);
            Controls.Add(label60Words);
            Controls.Add(label30Words);
            Controls.Add(label10Words);
            MaximizeBox = false;
            Name = "Profile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Type It";
            Load += Profile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10Words;
        private Label label30Words;
        private Label label60Words;
        private Label labelName;
        private Label labelAverageAccuracy;
        private Label labelHighestAccuracy;
        private Label labelAverageWPM;
        private Label labelHighestWPM;
        private Label label10AA;
        private Label label30AA;
        private Label label60AA;
        private Label label10HA;
        private Label label30HA;
        private Label label60HA;
        private Label label10AW;
        private Label label30AW;
        private Label label60AW;
        private Label label60HW;
        private Label label30HW;
        private Label label10HW;
        private Button buttonContinue;
        private ListView listViewHistory;
        private ColumnHeader firstColumn;
        private ColumnHeader wpm;
        private ColumnHeader accuracy;
        private ColumnHeader mode;
        private Label labelPadding;
    }
}