using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net;

namespace TypingApplication
{
    public partial class SignUp : Form
    {
        Thread thread;
        public SignUp()
        {
            InitializeComponent();
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
        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            string name = Regex.Replace(textBoxName.Text, @"\s+", " ").Trim();
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;

            if (name == "" || !Regex.IsMatch(name, "^[a-zA-Z0-9 .,']+$"))
            {
                labelNameError.Visible = true;
            }
            if (email.Length < 6 || !Regex.IsMatch(email, "@") || !Regex.IsMatch(email, "\\."))
            {
                labelEmailError.Visible = true;
            }
            if (password.Length < 7 || Regex.IsMatch(password, "^[a-zA-Z0-9]+$") || Regex.IsMatch(password, "^[a-zA-Z]+$") || Regex.IsMatch(password, "^[0-9]+$"))
            {
                labelPasswordError.Text = "Invalid Format";
                labelPasswordError.ForeColor = Color.Red;
            }
            if (labelNameError.Visible is false && labelEmailError.Visible is false && labelPasswordError.Text != "Invalid Format")
            {
                UserCredentials.InsertCredentials(name, email, password);

                if (!UserCredentials.exception)
                {
                    MessageBox.Show("Signed Up Successfully!");
                    this.Close();
                    thread = new Thread(openLogIn);
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();

                    try
                    {
                        SmtpClient client = new SmtpClient();
                        client.Host = "smtp.gmail.com";
                        client.Port = 587;
                        client.EnableSsl = true;
                        client.Credentials = new NetworkCredential("typeit.click@gmail.com", "vmagvhbnowdrcqmo");

                        MailMessage mailMessage = new MailMessage();
                        mailMessage.From = new MailAddress("typeit.click@gmail.com");
                        mailMessage.To.Add(email);
                        mailMessage.Subject = $"Welcome {name} to Type It";
                        mailMessage.Body = "Thank you for registering :3";

                        client.Send(mailMessage);
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                    }
                }
            }
        }
        private void textBoxName_MouseClick(object sender, MouseEventArgs e)
        {
            labelNameError.Visible = false;
        }
        private void textBoxEmail_MouseClick(object sender, MouseEventArgs e)
        {
            labelEmailError.Visible = false;
        }
        private void textBoxPassword_MouseClick(object sender, MouseEventArgs e)
        {
            labelPasswordError.Text = "Use 8 or more characters with a mix of letters, numbers and symbols";
            labelPasswordError.ForeColor = SystemColors.ControlText;
        }
        public void openLogIn(object obj)
        {
            Application.Run(new LogIn());
        }
        private void buttonLogInInstead_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(openLogIn);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}
