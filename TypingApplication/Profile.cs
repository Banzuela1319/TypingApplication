using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
    public partial class Profile : Form
    {
        Thread thread;
        public Profile()
        {
            InitializeComponent();
        }
        private void Profile_Load(object sender, EventArgs e)
        {
            double totalWPM10 = 0;
            double totalAccuracy10 = 0;
            int resultCount10 = 0;
            double averageWPM10 = 0;
            double averageAccuracy10 = 0;
            int highestWPM10 = 0;
            int highestAccuracy10 = 0;

            double totalWPM30 = 0;
            double totalAccuracy30 = 0;
            int resultCount30 = 0;
            double averageWPM30 = 0;
            double averageAccuracy30 = 0;
            int highestWPM30 = 0;
            int highestAccuracy30 = 0;

            double totalWPM60 = 0;
            double totalAccuracy60 = 0;
            int resultCount60 = 0;
            double averageWPM60 = 0;
            double averageAccuracy60 = 0;
            int highestWPM60 = 0;
            int highestAccuracy60 = 0;
            try
            {
                using (MySqlConnection connection = new MySqlConnection(UserCredentials.connectionStr))
                {
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "SELECT * FROM wpmaccuracy";

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader.GetString("email") == Properties.Settings.Default.email && reader.GetString("mode") == "10 words")
                            {
                                resultCount10++;
                                totalWPM10 += reader.GetInt32("wpm");
                                totalAccuracy10 += reader.GetInt32("accuracy");

                                averageWPM10 = Math.Round(totalWPM10 / resultCount10);
                                averageAccuracy10 = Math.Round(totalAccuracy10 / resultCount10);

                                if (reader.GetInt32("wpm") > highestWPM10)
                                {
                                    highestWPM10 = reader.GetInt32("wpm");
                                }
                                if (reader.GetInt32("accuracy") > highestAccuracy10)
                                {
                                    highestAccuracy10 = reader.GetInt32("accuracy");
                                }
                            }
                            if (reader.GetString("email") == Properties.Settings.Default.email && reader.GetString("mode") == "30 words")
                            {
                                resultCount30++;
                                totalWPM30 += reader.GetInt32("wpm");
                                totalAccuracy30 += reader.GetInt32("accuracy");

                                averageWPM30 = Math.Round(totalWPM30 / resultCount30);
                                averageAccuracy30 = Math.Round(totalAccuracy30 / resultCount30);

                                if (reader.GetInt32("wpm") > highestWPM30)
                                {
                                    highestWPM30 = reader.GetInt32("wpm");
                                }
                                if (reader.GetInt32("accuracy") > highestAccuracy30)
                                {
                                    highestAccuracy30 = reader.GetInt32("accuracy");
                                }
                            }
                            if (reader.GetString("email") == Properties.Settings.Default.email && reader.GetString("mode") == "60 words")
                            {
                                resultCount60++;
                                totalWPM60 += reader.GetInt32("wpm");
                                totalAccuracy60 += reader.GetInt32("accuracy");

                                averageWPM60 = Math.Round(totalWPM60 / resultCount60);
                                averageAccuracy60 = Math.Round(totalAccuracy60 / resultCount60);

                                if (reader.GetInt32("wpm") > highestWPM60)
                                {
                                    highestWPM60 = reader.GetInt32("wpm");
                                }
                                if (reader.GetInt32("accuracy") > highestAccuracy60)
                                {
                                    highestAccuracy60 = reader.GetInt32("accuracy");
                                }
                            }

                            if (reader.GetString("email") == Properties.Settings.Default.email)
                            {
                                ListViewItem item = new ListViewItem();
                                item.SubItems.Add(reader.GetString("mode"));
                                item.SubItems.Add(reader.GetString("wpm"));
                                item.SubItems.Add(reader.GetString("accuracy") + "%");
                                listViewHistory.Items.Insert(0, item);
                            }
                        }
                        label10AA.Text = averageAccuracy10.ToString() + "%";
                        label30AA.Text = averageAccuracy30.ToString() + "%";
                        label60AA.Text = averageAccuracy60.ToString() + "%";

                        label10HA.Text = highestAccuracy10.ToString() + "%";
                        label30HA.Text = highestAccuracy30.ToString() + "%";
                        label60HA.Text = highestAccuracy60.ToString() + "%";

                        label10AW.Text = averageWPM10.ToString();
                        label30AW.Text = averageWPM30.ToString();
                        label60AW.Text = averageWPM60.ToString();

                        label10HW.Text = highestWPM10.ToString();
                        label30HW.Text = highestWPM30.ToString();
                        label60HW.Text = highestWPM60.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(UserCredentials.connectionStr))
                {
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "SELECT * FROM usercredentials";

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader.GetString("email") == Properties.Settings.Default.email)
                            {
                                labelName.Text = reader.GetString("name") + "'s profile";
                                break;
                            }

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
        public void openMain()
        {
            Application.Run(new Main());
        }
        private void buttonContinue_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(openMain);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}
