using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TypingApplication
{
    internal class Words
    {
        public static List<string> listOfWords = new List<string>();

        public static void ReadingRandomWords()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(UserCredentials.connectionStr))
                {
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "SELECT words FROM randomwords";

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listOfWords.Add(reader.GetString(0));
                        }
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
