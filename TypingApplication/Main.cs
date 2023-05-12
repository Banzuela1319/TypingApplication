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
    public partial class Main : Form
    {
        Thread thread;
        Random random = new Random();
        List<string> selectedWords = new List<string>();
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            Words.ReadingRandomWords();

            Size logOutImageSize = buttonLogOut.Size;
            Image resizeLogOutImage = buttonLogOut.Image.GetThumbnailImage(logOutImageSize.Width - 20, logOutImageSize.Height - 20, null, IntPtr.Zero);
            buttonLogOut.Image = resizeLogOutImage;

            Size profileImageSize = buttonProfile.Size;
            Image resizeProfileImage = buttonProfile.Image.GetThumbnailImage(profileImageSize.Width - 10, profileImageSize.Height - 10, null, IntPtr.Zero);
            buttonProfile.Image = resizeProfileImage;

            Size settingsImageSize = buttonSettings.Size;
            Image resizeSettingsImage = buttonSettings.Image.GetThumbnailImage(settingsImageSize.Width - 10, settingsImageSize.Height - 10, null, IntPtr.Zero);
            buttonSettings.Image = resizeSettingsImage;

            if (Properties.Settings.Default.wordsPreference == "10 words")
            {
                button10Words.PerformClick();
            }
            else if (Properties.Settings.Default.wordsPreference == "30 words")
            {
                button30Words.PerformClick();
            }
            else if (Properties.Settings.Default.wordsPreference == "60 words")
            {
                button60Words.PerformClick();
            }
        }
        public void openLogIn(object obj)
        {
            Application.Run(new LogIn());
        }
        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.email = "";
            Properties.Settings.Default.password = "";
            Properties.Settings.Default.Save();
            this.Close();
            thread = new Thread(openLogIn);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void button10Words_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.wordsPreference = "10 words";
            Properties.Settings.Default.Save();
            if (selectedWords.Count != 0)
            {
                selectedWords.Clear();
            }
            while (selectedWords.Count < 10)
            {
                int index = random.Next(Words.listOfWords.Count);
                selectedWords.Add(Words.listOfWords[index]);
            }
            richTextBoxWords.Text = string.Join(" ", selectedWords);
        }

        private void button30Words_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.wordsPreference = "30 words";
            Properties.Settings.Default.Save();
            if (selectedWords.Count != 0)
            {
                selectedWords.Clear();
            }
            while (selectedWords.Count < 30)
            {
                int index = random.Next(Words.listOfWords.Count);
                selectedWords.Add(Words.listOfWords[index]);
            }
            richTextBoxWords.Text = string.Join(" ", selectedWords);
        }

        private void button60Words_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.wordsPreference = "60 words";
            Properties.Settings.Default.Save();
            if (selectedWords.Count != 0)
            {
                selectedWords.Clear();
            }
            while (selectedWords.Count < 60)
            {
                int index = random.Next(Words.listOfWords.Count);
                selectedWords.Add(Words.listOfWords[index]);
            }
            richTextBoxWords.Text = string.Join(" ", selectedWords);
        }
    }
}
