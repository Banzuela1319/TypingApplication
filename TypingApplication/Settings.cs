using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TypingApplication
{
    public partial class Settings : Form
    {
        Thread thread;
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            Size backImageSize = buttonBack.Size;
            Image resizeBackImage = buttonBack.Image.GetThumbnailImage(backImageSize.Width - 20, backImageSize.Height - 20, null, IntPtr.Zero);
            buttonBack.Image = resizeBackImage;
        }
        public void openMain(object obj)
        {
            Application.Run(new Main());
        }
        public void openLogIn(object obj)
        {
            Application.Run(new LogIn());
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(openMain);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void buttonResetAccount_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to RESET your account?", "Reset Account", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                ResetAccount();
                MessageBox.Show("Account has been reset.");
            }
        }
        private void buttonDeleteAccount_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to DELETE your account?", "Delete Account", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                ResetAccount();
                DeleteAccount();
                MessageBox.Show("Account has been deleted.");

                LogIn.validEmail = "";
                LogIn.validPassword = "";
                Properties.Settings.Default.email = "";
                Properties.Settings.Default.password = "";
                Properties.Settings.Default.Save();

                this.Close();
                thread = new Thread(openLogIn);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
        }
        public void ResetAccount()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(UserCredentials.connectionStr))
                {
                    connection.Open();
                    string query = "DELETE FROM wpmaccuracy WHERE email = @email";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@email", Properties.Settings.Default.email);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
        public void DeleteAccount()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(UserCredentials.connectionStr))
                {
                    connection.Open();
                    string query = "DELETE FROM usercredentials WHERE email = @email";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@email", Properties.Settings.Default.email);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
