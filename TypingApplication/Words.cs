using System;
using System.Collections.Generic;
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
    }
}
