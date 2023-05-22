using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TypingApplication
{
    public partial class Result : Form
    {
        Thread thread;
        public Result()
        {
            InitializeComponent();
        }
        private void Result_Load(object sender, EventArgs e)
        {

            string[] start = Main.startingWords.Split(' ');
            string[] final = Main.typedLetters.Split(' ');
            int rightSyllables = 0;
            int spaces = 0;

            for (int i = 0; i < start.Length; i++)
            {
                if (start[i] == final[i])
                {
                    rightSyllables += start[i].Length;
                    if (i != start.Length - 1)
                    {
                        spaces++;
                    }
                }
            }

            double wpmResult = 60 / Main.time * (rightSyllables + spaces) * Main.selectedWords.Count / (Main.selectedWords.Count * 5);
            if (double.IsNaN(wpmResult))
            {
                labelWPMResult.Text = "0";
            }
            else
            {
                labelWPMResult.Text = Math.Round(wpmResult).ToString();
            }
            double accuracy = Main.correctTyped / Main.charactersTyped * 100;
            labelAccuracyResult.Text = Math.Floor(accuracy).ToString() + "%";

            StoreWPMAccuracy.StoringData(int.Parse(labelWPMResult.Text), int.Parse(labelAccuracyResult.Text.Substring(0, labelAccuracyResult.Text.Length - 1)));
        }
        public void openMain()
        {
            Application.Run(new Main());
        }
        private void buttonContinue_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(openMain);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}
