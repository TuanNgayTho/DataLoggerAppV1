using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Windows.Forms;

namespace DataLoggerAppV1
{
    public partial class Alarm : Form
    {
        public Alarm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReadAlarmFromDatabase();
        }

        void ReadAlarmFromDatabase()
        {
            // Clear data grid view
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();

            //Connect To Mysql
            string server = "localhost";
            string database = "datalogger";
            string uid = "root";
            string password = "root";
            string constring = "Server=" + server + "; database=" + database + "; uid=" + uid + "; pwd=" + password;
            using (MySqlConnection con2 = new MySqlConnection(constring))
            {
                con2.Open();
                // write alarm to database
                var query = "SELECT * FROM datalogger.alarmlist WHERE 1=1 ORDER BY alarmlist.ts DESC LIMIT 200";
                // Database read CMD
                using (MySqlCommand cmd = new MySqlCommand(query, con2))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int currentRow = dataGridView1.Rows.Count - 1;
                        int sttErrorValue = reader.GetInt32(2) +3;
                        string message = "Status Error";
                        if (reader.GetBoolean(12))
                        {
                            message = "Outgoing";
                        }
                        else if (reader.GetBoolean(12) == false)
                        {
                            message = "Incoming";
                        }

                        dataGridView1.Rows.Add(reader.GetString(1), message, reader.GetValue(sttErrorValue), reader.GetString(13));
                        if (reader.GetBoolean(11))
                        {
                            dataGridView1.Rows[currentRow].DefaultCellStyle.BackColor = Color.LightCoral;
                        }
                        else if (reader.GetBoolean(11) == false)
                        {
                            dataGridView1.Rows[currentRow].DefaultCellStyle.BackColor = Color.Gold;
                        }
                    }
                }
                con2.Close();
            }
        }
    }
}
