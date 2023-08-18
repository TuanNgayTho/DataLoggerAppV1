using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using S7.Net;
using System.Threading;
using MySql.Data.MySqlClient;

namespace DataLoggerAppV1
{
    public partial class MainForm : Form
    {
        public static MainForm instance;
        public static bool IsLogIn = false;
        public Label UserNameLabelel;
        public static Plc plc = new Plc(CpuType.S71200, "192.168.0.2", 0, 1);
        public double DataAi0;
        public double DataAi1;
        public double DataAi2;
        public double DataAi3;
        public double DataAi4;
        public double DataAi5;
        public double DataAi6;
        public double DataAi7;
        public MainForm()
        {
            InitializeComponent();
            UserNameLabelel = lblUserName;
            instance = this;

            btnDashboard.BackColor = SystemColors.Control;

            lblNameOfPage.Text = "Dashboard";
            this.pnlFormLoader.Controls.Clear();
            Dashboard Dashboard_Vrb = new Dashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Dashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(Dashboard_Vrb);
            Dashboard_Vrb.Show();

            // Creat a new thread and then run method Connect PLC
            Thread t = new Thread(() =>
            {
                WriteSampleToDatabase();
            });
            t.IsBackground = true;
            t.Start();

            Thread t2 = new Thread(() =>
            {
                WriteAlarmToDatabase();
            });
            t2.IsBackground = true;
            t2.Start();
        }

        private void WriteAlarmToDatabase()
        {
            bool sttLowAlarm = false;
            bool sttHighAlarm = false;

            while (true)
            {
                Thread.Sleep(100);
                var result = plc.Open();
                while (true)
                {
                    try
                    {
                        if (result != ErrorCode.NoError)
                        {
                            MessageBox.Show("Error: abc" + plc.LastErrorCode + "\n" + plc.LastErrorString);
                            break;
                        }
                        else
                        {
                            int SampleCycle = Properties.Settings.Default.CycleTime;
                            Thread.Sleep(SampleCycle);

                            // Read AI Data From PLC
                            var DbAiData = new DbAiData();
                            plc.ReadClass(DbAiData, 4);

                            // Read Bool Status Data From PLC
                            var DbReadBool = new DbReadBool();
                            plc.ReadClass(DbReadBool, 13);

                            DataAi0 = DbAiData.Ai0;
                            DataAi1 = DbAiData.Ai1;
                            DataAi2 = DbAiData.Ai2;
                            DataAi3 = DbAiData.Ai3;
                            DataAi4 = DbAiData.Ai4;
                            DataAi5 = DbAiData.Ai5;
                            DataAi6 = DbAiData.Ai6;
                            DataAi7 = DbAiData.Ai7;

                            //Connect To Mysql
                            string server = "localhost";
                            string database = "datalogger";
                            string uid = "root";
                            string password = "root";
                            string constring = "Server=" + server + "; database=" + database + "; uid=" + uid + "; pwd=" + password;

                            using (MySqlConnection con2 = new MySqlConnection(constring))
                            {
                                con2.Open();
                                // Ai0 write alarm to database
                                if (DbReadBool.LowAlarm0 == true && sttLowAlarm == true)
                                {
                                    var query = "INSERT INTO alarmlist (ainame, aivalue0, aivalue1, aivalue2, aivalue3, aivalue4, aivalue5, aivalue6, aivalue7) " +
                                                "VALUES ('" + Properties.Settings.Default.NameAi0 + ", " + DataAi0 + ", " + DataAi1 + ", " + DataAi2 + ", " + DataAi3 + ", " + DataAi4 + ", " + DataAi5 + ", " + DataAi6 + ", " + DataAi7 + ");";
                                    StringBuilder bu = new StringBuilder();
                                    MySqlCommand cmd = new MySqlCommand(query, con2);
                                    try
                                    {
                                        if (cmd.ExecuteNonQuery() == 1)
                                        {
                                        }
                                    }
                                    catch (Exception e)
                                    {
                                        MessageBox.Show(e.Message);
                                    }
                                }
                                con2.Close();
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        plc.Close();
                        Thread.Sleep(100);
                        result = plc.Open();
                        Thread.Sleep(100);
                    }
                }
            }
        }

        private void WriteSampleToDatabase()
        {
            while (true)
            {
                try
                {
                    //Connect To Mysql
                    Thread.Sleep(Properties.Settings.Default.CycleTime);
                    string server = "localhost";
                    string database = "datalogger";
                    string uid = "root";
                    string password = "root";
                    string constring = "Server=" + server + "; database=" + database + "; uid=" + uid + "; pwd=" + password;
                    using (MySqlConnection con = new MySqlConnection(constring))
                    {
                        con.Open();
                        var query = "INSERT INTO samples (aivalue0, aivalue1, aivalue2, aivalue3, aivalue4, aivalue5, aivalue6, aivalue7) " +
                                    "VALUES (" + DataAi0 + ", " + DataAi1 + ", "+ DataAi2 + "," + DataAi3 + ", " + DataAi4 + ", "+ DataAi5 + ", " + DataAi6 + ", "+ DataAi7 +");";
                        StringBuilder bu = new StringBuilder();
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        try
                        {
                            if (cmd.ExecuteNonQuery() == 1)
                            {
                            }
                        }
                        catch (Exception e)
                        {
                        }
                        con.Close();
                    }
                    
                }
                catch (Exception e)
                {
                    Thread.Sleep(100);
                }
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblNameOfPage.Text = "Trend";
            this.pnlFormLoader.Controls.Clear();
            Trend Trend_Vrb = new Trend() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Trend_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(Trend_Vrb);
            Trend_Vrb.Show();

            btnDashboard.BackColor = SystemColors.ControlLight;
            btnAlarmList.BackColor = SystemColors.ControlLight;
            btnTrend.BackColor = SystemColors.Control;
            btnMonitor.BackColor = SystemColors.ControlLight;
            btnSettings.BackColor = SystemColors.ControlLight;
        }

        private void btnExport_Leave(object sender, EventArgs e)
        {
            
        }

        private void btnMonitor_Click(object sender, EventArgs e)
        {
            lblNameOfPage.Text = "Monitor";
            this.pnlFormLoader.Controls.Clear();
            Monitor Monitor_Vrb = new Monitor() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Monitor_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(Monitor_Vrb);
            Monitor_Vrb.Show();

            btnDashboard.BackColor = SystemColors.ControlLight;
            btnAlarmList.BackColor = SystemColors.ControlLight;
            btnTrend.BackColor = SystemColors.ControlLight;
            btnMonitor.BackColor = SystemColors.Control;
            btnSettings.BackColor = SystemColors.ControlLight;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            lblNameOfPage.Text = "Dashboard";
            this.pnlFormLoader.Controls.Clear();
            Dashboard Dashboard_Vrb = new Dashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Dashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(Dashboard_Vrb);
            Dashboard_Vrb.Show();

            btnDashboard.BackColor = SystemColors.Control;
            btnAlarmList.BackColor = SystemColors.ControlLight;
            btnTrend.BackColor = SystemColors.ControlLight;
            btnSettings.BackColor = SystemColors.ControlLight;
            btnMonitor.BackColor = SystemColors.ControlLight;
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            
        }

        private void btnAlarmList_Click(object sender, EventArgs e)
        {
            lblNameOfPage.Text = "Alarm List";
            this.pnlFormLoader.Controls.Clear();
            Alarm Alarm_Vrb = new Alarm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Alarm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(Alarm_Vrb);
            Alarm_Vrb.Show();

            btnDashboard.BackColor = SystemColors.ControlLight;
            btnAlarmList.BackColor = SystemColors.Control;
            btnTrend.BackColor = SystemColors.ControlLight;
            btnSettings.BackColor = SystemColors.ControlLight;
            btnMonitor.BackColor = SystemColors.ControlLight;
        }

        private void btnAlarmList_Leave(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new LoginPage().ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (IsLogIn == true)
            {
                lblNameOfPage.Text = "Settings";
                this.pnlFormLoader.Controls.Clear();
                Setting Setting_Vrb = new Setting() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                Setting_Vrb.FormBorderStyle = FormBorderStyle.None;
                this.pnlFormLoader.Controls.Add(Setting_Vrb);
                Setting_Vrb.Show();

                btnDashboard.BackColor = SystemColors.ControlLight;
                btnAlarmList.BackColor = SystemColors.ControlLight;
                btnTrend.BackColor = SystemColors.ControlLight;
                btnSettings.BackColor = SystemColors.Control;
                btnMonitor.BackColor = SystemColors.ControlLight;
            }
            else
            {
                new LoginPage().ShowDialog();
            }
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new QuitForm().ShowDialog();
        }

        private void pnlFormLoader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
