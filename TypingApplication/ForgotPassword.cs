using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Text.RegularExpressions;

namespace TypingApplication
{
    public partial class ForgotPassword : Form
    {
        Random random = new Random();
        private int timeout;
        private string code = "";
        private string email;
        public ForgotPassword()
        {
            InitializeComponent();
        }
        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "")
            {
                buttonVerificationCode.Enabled = false;
            }
            else if (textBoxEmail.Text != "" && timeout == 0)
            {
                buttonVerificationCode.Enabled = true;
            }
        }
        private void buttonVerificationCode_Click(object sender, EventArgs e)
        {
            code = "";
            email = textBoxEmail.Text;
            timeout = 15;
            buttonVerificationCode.Enabled = false;
            timerGetCode.Start();

            for (int i = 0; i < 6; i++)
            {
                code += random.Next(10).ToString();
            }
            try
            {
                SmtpClient client = new SmtpClient();
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential("typeit.click@gmail.com", "vmagvhbnowdrcqmo");

                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("typeit.click@gmail.com");
                mailMessage.To.Add(textBoxEmail.Text);
                mailMessage.Subject = "Reset Password";
                mailMessage.Body = $"Verification Code is {code}";

                client.Send(mailMessage);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            MessageBox.Show("Verification Code Sent");

            labelCode.Visible = true;
            textBoxCode.Visible = true;
            buttonSubmit.Visible = true;
            //MessageBox.Show(code); //for debugging
        }

        private void timerGetCode_Tick(object sender, EventArgs e)
        {
            if (timeout != 0)
            {
                labeltimeout.Text = $"Didn't receive it? Try again in {timeout} seconds";
                timeout--;
                labeltimeout.Visible = true;
            }
            else
            {
                timerGetCode.Stop();
                labeltimeout.Visible = false;
                if (textBoxEmail.Text != "")
                {
                    buttonVerificationCode.Enabled = true;
                }
            }
        }
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (code == textBoxCode.Text)
            {
                labelEmail.Visible = false;
                textBoxEmail.Visible = false;
                buttonVerificationCode.Visible = false;
                labelCode.Visible = false;
                textBoxCode.Visible = false;
                buttonSubmit.Visible = false;
                labelPlease.Visible = false;
                timerGetCode.Stop();
                labeltimeout.Visible = false;

                labelPassword.Visible = true;
                textBoxPassword.Visible = true;
                buttonSaveChanges.Visible = true;
                labelPasswordError.Visible = true;
            }
            else
            {
                labelCodeError.Visible = true;
            }
        }

        private void textBoxCode_MouseClick(object sender, MouseEventArgs e)
        {
            labelCodeError.Visible = false;
        }

        private void textBoxCode_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCode.Text == "")
            {
                buttonSubmit.Enabled = false;
            }
            else if (textBoxCode.Text != "")
            {
                buttonSubmit.Enabled = true;
            }
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            string password = textBoxPassword.Text;
            if (password.Length < 7 || Regex.IsMatch(password, "^[a-zA-Z0-9]+$") || Regex.IsMatch(password, "^[a-zA-Z]+$") || Regex.IsMatch(password, "^[0-9]+$"))
            {
                labelPasswordError.Text = "Invalid Format";
                labelPasswordError.ForeColor = Color.Red;
            }
            if (labelPasswordError.Text != "Invalid Format")
            {
                UserCredentials.ResetPassword(email, password);
                MessageBox.Show("Successfully updated your password");
                this.Close();
            }
        }
        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                buttonSaveChanges.Enabled = false;
            }
            else if (textBoxPassword.Text != "")
            {
                buttonSaveChanges.Enabled = true;
            }
        }
        private void textBoxPassword_MouseClick(object sender, MouseEventArgs e)
        {
            labelPasswordError.Text = "Use 8 or more characters with a mix of letters, numbers and symbols";
            labelPasswordError.ForeColor = Color.White;
        }
    }
}
