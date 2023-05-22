using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TypingApplication
{
    internal class StoreWPMAccuracy
    {
        public static void StoringData(int wpm, int accuracy) 
        {
            using (MySqlConnection connection = new MySqlConnection(UserCredentials.connectionStr))
            {
                try
                {
                    string query = $"INSERT INTO wpmaccuracy (email, mode, wpm, accuracy) VALUES ('{Properties.Settings.Default.email}', '{Properties.Settings.Default.wordsPreference }', '{wpm}', '{accuracy}')";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader;
                    connection.Open();
                    reader = command.ExecuteReader();
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message );
                }
            }
        }
    }
}
