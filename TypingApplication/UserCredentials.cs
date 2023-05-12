using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using TypingApplication;

namespace TypingApplication
{
    internal class UserCredentials
    {
        public static bool exception;
        public static string connectionStr = "server=sql12.freesqldatabase.com;username=sql12616544;password=Vlz63zZcrr;database=sql12616544";
        public static void InsertCredentials(string name, string email, string password)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionStr))
            {
                exception = false;
                try
                {
                    string query = $"INSERT INTO usercredentials (name, email, password) VALUES ('{name}', '{email}', '{password}')";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader;
                    connection.Open();
                    reader = command.ExecuteReader();
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    exception = true;
                }
            }
        }
        public static void LoggingIn(string email, string password)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionStr))
            {
                try
                {
                    string query = $"SELECT email, password FROM usercredentials WHERE email = @email AND password = @password";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader;
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@password", password);
                    connection.Open();
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        LogIn.validEmail = email;
                        LogIn.validPassword = password;
                    }
                    else if (email == "" && password == "")
                    {
                        MessageBox.Show("Email and Password Empty!", "Account Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (email == "")
                    {
                        MessageBox.Show("Email Empty!", "Account Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (password == "")
                    {
                        MessageBox.Show("Password Empty!", "Account Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Email or Password!", "Account Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
        }
    }
}
