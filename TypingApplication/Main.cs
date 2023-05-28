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
using System.Diagnostics;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Timers;

namespace TypingApplication
{
    public partial class Main : Form
    {
        Thread thread;
        Random random = new Random();

        private int index = 0;
        private Color correct = Color.Khaki;
        private Color wrong = Color.Red;
        private Color wrongExtra = Color.FromArgb(192, 0, 0);

        public static List<string> selectedWords = new List<string>();
        public static double charactersTyped = 0;
        public static double correctTyped = 0;
        public static string typedLetters = "";
        public static double time = 0;
        public static string startingWords;
        Stopwatch stopwatch = new Stopwatch();

        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            Words.ReadingRandomWords();
            richTextBoxWords.Select();

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
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                labelCapsOn.Visible = true;
                richTextBoxWords.Enabled = false;
                this.Focus();
            }
        }
        public void openLogIn(object obj)
        {
            Application.Run(new LogIn());
        }
        public void openResult(object obj)
        {
            Application.Run(new Result());
        }
        public void openProfile(object obj)
        {
            Application.Run(new Profile());
        }
        public void openSettings(object obj)
        {
            Application.Run(new Settings());
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
            index = 0;
            charactersTyped = 0;
            correctTyped = 0;
            typedLetters = "";
            richTextBoxWords.Select();
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
            startingWords = richTextBoxWords.Text;

            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                labelCapsOn.Visible = true;
                richTextBoxWords.Enabled = false;
                this.Focus();
            }
        }

        private void button30Words_Click(object sender, EventArgs e)
        {
            index = 0;
            charactersTyped = 0;
            correctTyped = 0;
            typedLetters = "";
            richTextBoxWords.Select();
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
            startingWords = richTextBoxWords.Text;

            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                labelCapsOn.Visible = true;
                richTextBoxWords.Enabled = false;
                this.Focus();
            }
        }

        private void button60Words_Click(object sender, EventArgs e)
        {
            index = 0;
            charactersTyped = 0;
            correctTyped = 0;
            typedLetters = "";
            richTextBoxWords.Select();
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
            startingWords = richTextBoxWords.Text;

            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                labelCapsOn.Visible = true;
                richTextBoxWords.Enabled = false;
                this.Focus();
            }
        }
        private void RestartTest()
        {
            stopwatch.Reset();
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
        private void richTextBoxWords_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && index == 0)
            {
                stopwatch.Start();
            }
            if (char.IsLetter(e.KeyChar) || (e.KeyChar == ' ' && index != 0 && typedLetters[typedLetters.Length - 1] != ' '))
            {
                typedLetters += e.KeyChar;
            }
            e.Handled = true;
            if (index < richTextBoxWords.Text.Length)
            {
                if ((char.IsLetter(e.KeyChar) && char.IsLetter(richTextBoxWords.Text[index])) || ((e.KeyChar == ' ') && richTextBoxWords.Text[index] == ' '))
                {
                    charactersTyped++;
                    richTextBoxWords.Select(index, 1);
                    if (richTextBoxWords.Text[index] == e.KeyChar)
                    {
                        richTextBoxWords.SelectionColor = correct;
                        correctTyped++;
                    }
                    else
                    {
                        richTextBoxWords.SelectionColor = wrong;
                    }
                    index++;
                    richTextBoxWords.Select(index, 0);
                }
                else if (char.IsLetter(e.KeyChar) && richTextBoxWords.Text[index] == ' ')
                {
                    charactersTyped++;
                    richTextBoxWords.Select(index, 0);
                    richTextBoxWords.SelectionColor = wrongExtra;
                    richTextBoxWords.SelectedText += e.KeyChar;
                    index++;
                }
                else if (e.KeyChar == ' ' && char.IsLetter(richTextBoxWords.Text[index]))
                {
                    charactersTyped++;
                    if (index != 0)
                    {
                        richTextBoxWords.Select(index, -1);
                    }
                    Color letterColor = richTextBoxWords.SelectionColor;
                    if (letterColor == correct || letterColor == wrong)
                    {
                        while (richTextBoxWords.Text[index - 1] != ' ')
                        {
                            if (index == richTextBoxWords.Text.Length)
                            {
                                break;
                            }
                            index++;
                        }
                        richTextBoxWords.Select(index, 0);
                    }
                }
            }
            if (index == richTextBoxWords.Text.Length)
            {
                time = (double)stopwatch.Elapsed.TotalSeconds;
                stopwatch.Reset();
                this.Close();
                thread = new Thread(openResult);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
        }
        private void richTextBoxWords_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                labelCapsOn.Visible = true;
                richTextBoxWords.Enabled = false;
                this.Focus();
            }
            if (e.KeyCode == Keys.Tab)
            {
                stopwatch.Stop();
                DialogResult result = MessageBox.Show("Restart Test?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    RestartTest();
                }
                else
                {
                    stopwatch.Start();
                }
            }
            if (e.KeyCode == Keys.Back && typedLetters.Length != 0)
            {
                typedLetters = typedLetters.Remove(typedLetters.Length - 1);
            }
            e.Handled = true;
            if (index != 0 && e.KeyCode == Keys.Back)
            {
                richTextBoxWords.Select(index, -1);
                Color letterColor = richTextBoxWords.SelectionColor;
                if (e.KeyCode == Keys.Back && index != 0 && (letterColor == wrong || letterColor == correct))
                {
                    richTextBoxWords.SelectionColor = Color.White;
                    index--;
                    richTextBoxWords.Select(index, 0);
                }
                else if (e.KeyCode == Keys.Back && index != 0 && letterColor == wrongExtra)
                {
                    richTextBoxWords.ReadOnly = false;
                    richTextBoxWords.SelectedText = "";
                    richTextBoxWords.ReadOnly = true;
                    index--;
                }
                else if (e.KeyCode == Keys.Back && (letterColor == Color.White || richTextBoxWords.SelectedText == " "))
                {
                    letterColor = richTextBoxWords.SelectionColor;
                    while (letterColor == Color.White)
                    {
                        index--;
                        richTextBoxWords.Select(index, -1);
                        letterColor = richTextBoxWords.SelectionColor;
                    }
                    richTextBoxWords.Select(index, 0);
                }
            }
        }
        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (!Control.IsKeyLocked(Keys.CapsLock))
            {
                labelCapsOn.Visible = false;
                richTextBoxWords.Enabled = true;
                richTextBoxWords.Focus();
            }
        }
        private void buttonProfile_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(openProfile);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void buttonSettings_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(openSettings);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}
