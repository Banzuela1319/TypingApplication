using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using System.Diagnostics;
using System.Threading;

namespace TypingApplication
{
    public partial class LogIn : Form
    {
        Thread thread;
        public static string validEmail;
        public static string validPassword;
        public LogIn()
        {
            InitializeComponent();
        }
        private void LogIn_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.email != "" && Properties.Settings.Default.password != "")
            {
                this.Close();
                thread = new Thread(openMain);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
        }
        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked == true)
            {
                textBoxPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '*';
            }
        }
        public void openSignUp(object obj)
        {
            Application.Run(new SignUp());
        }
        public void openMain(object obj)
        {
            Application.Run(new Main());
        }
        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(openSignUp);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;
            UserCredentials.LoggingIn(email, password);
            if (validEmail == email)
            {
                this.Close();
                thread = new Thread(openMain);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();

                Properties.Settings.Default.email = validEmail;
                Properties.Settings.Default.password = validPassword;
                Properties.Settings.Default.Save();
            }
        }
        private void textBoxEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogIn.PerformClick();
            }
        }
        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogIn.PerformClick();
            }
        }
    }
}