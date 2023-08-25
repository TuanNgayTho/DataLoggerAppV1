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
using System.Timers;

namespace DataLoggerAppV1
{
    public partial class MainForm : Form
    {
        public static MainForm instance;
        public static bool IsLogIn = false;
        public Label UserNameLabelel;
        public static Plc plc = new Plc(CpuType.S71200, "192.168.0.2", 0, 1);
        public static double DataAi0;
        public static double DataAi1;
        public static double DataAi2;
        public static double DataAi3;
        public static double DataAi4;
        public static double DataAi5;
        public static double DataAi6;
        public static double DataAi7;
        
        public static bool boolInletStream1;
        public static bool boolInletStream2;
        public static bool boolInletStream3;

        public static bool boolBypassStream1;
        public static bool boolBypassStream2;
        public static bool boolBypassStream3;
        public static bool isConnect;

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
            bool sttLowAlarm0 = false;
            bool sttLowAlarm1 = false;
            bool sttLowAlarm2 = false;
            bool sttLowAlarm3 = false;
            bool sttLowAlarm4 = false;
            bool sttLowAlarm5 = false;
            bool sttLowAlarm6 = false;
            bool sttLowAlarm7 = false;

            bool sttHighAlarm0 = false;
            bool sttHighAlarm1 = false;
            bool sttHighAlarm2 = false;
            bool sttHighAlarm3 = false;
            bool sttHighAlarm4 = false;
            bool sttHighAlarm5 = false;
            bool sttHighAlarm6 = false;
            bool sttHighAlarm7 = false;

            while (true)
            {
                while (true)
                {
                    //Thread.Sleep(100);
                    plc.Close(); plc.Close();
                    var result = plc.Open();

                    try
                    {
                        if (result != ErrorCode.NoError)
                        {
                            MessageBox.Show("Error: abc" + plc.LastErrorCode + "\n" + plc.LastErrorString);
                            isConnect = false;
                            break;
                        }
                        else
                        {
                            isConnect = true;
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

                            boolInletStream1 = DbReadBool.InletStream1;
                            boolInletStream2 = DbReadBool.InletStream2;
                            boolInletStream3 = DbReadBool.InletStream3;

                            boolBypassStream1 = DbReadBool.BypassStream1;
                            boolBypassStream2 = DbReadBool.BypassStream2;
                            boolBypassStream3 = DbReadBool.BypassStream3;

                            // Ai0 write LowAlarm to database
                            if (DbReadBool.LowAlarm0 == true && sttLowAlarm0 == false)
                            {
                                try
                                {
                                    writeAlarm(false, false, Properties.Settings.Default.NameAi0, 0);
                                    sttLowAlarm0 = true;
                                }
                                catch (Exception e)
                                {
                                    MessageBox.Show(e.Message);
                                }
                            }

                            if (DbReadBool.LowAlarm0 == false && DbReadBool.HighAlarm0 == false && sttLowAlarm0 == true  )
                            {
                                try
                                {
                                    writeAlarm(false, true, Properties.Settings.Default.NameAi0, 0);
                                    sttLowAlarm0 = false;
                                }
                                catch (Exception e)
                                {
                                    MessageBox.Show(e.Message);
                                }
                            }

                            // Ai0 write HighAlarm to database
                            if (DbReadBool.HighAlarm0 == true && sttHighAlarm0 == false)
                            {
                                try
                                {
                                    writeAlarm(true, false, Properties.Settings.Default.NameAi0, 0);
                                    sttHighAlarm0 = true;
                                }
                                catch (Exception e)
                                {
                                    MessageBox.Show(e.Message);
                                }
                            }

                            if (DbReadBool.HighAlarm0 == false && sttHighAlarm0 == true)
                            {
                                try
                                {
                                    writeAlarm(true, true, Properties.Settings.Default.NameAi0, 0);
                                    sttHighAlarm0 = false;
                                }
                                catch (Exception e)
                                {
                                    MessageBox.Show(e.Message);
                                }
                            }

                            // Ai1 write LowAlarm to database
                            if (DbReadBool.LowAlarm1 == true && sttLowAlarm1 == false)
                            {
                                try
                                {
                                    writeAlarm(false, false, Properties.Settings.Default.NameAi1, 1);
                                    sttLowAlarm1 = true;
                                }
                                catch (Exception e)
                                {
                                    MessageBox.Show(e.Message);
                                }
                            }

                            if (DbReadBool.LowAlarm1 == false && DbReadBool.HighAlarm1 == false && sttLowAlarm1 == true)
                            {
                                try
                                {
                                    writeAlarm(false, true, Properties.Settings.Default.NameAi1, 1);
                                    sttLowAlarm1 = false;
                                }
                                catch (Exception e)
                                {
                                    MessageBox.Show(e.Message);
                                }
                            }

                            // Ai1 write HighAlarm to database
                            if (DbReadBool.HighAlarm1 == true && sttHighAlarm1 == false)
                            {
                                try
                                {
                                    writeAlarm(true, false, Properties.Settings.Default.NameAi1, 1);
                                    sttHighAlarm1 = true;
                                }
                                catch (Exception e)
                                {
                                    MessageBox.Show(e.Message);
                                }
                            }

                            if (DbReadBool.HighAlarm1 == false && sttHighAlarm1 == true)
                            {
                                try
                                {
                                    writeAlarm(true, true, Properties.Settings.Default.NameAi1, 1);
                                    sttHighAlarm1 = false;
                                }
                                catch (Exception e)
                                {
                                    MessageBox.Show(e.Message);
                                }
                            }

                            // Ai2 write LowAlarm to database
                            if (DbReadBool.LowAlarm2 == true && sttLowAlarm2 == false)
                            {
                                try
                                {
                                    writeAlarm(false, false, Properties.Settings.Default.NameAi2, 2);
                                    sttLowAlarm2 = true;
                                }
                                catch (Exception e)
                                {
                                    MessageBox.Show(e.Message);
                                }
                            }

                            if (DbReadBool.LowAlarm2 == false && DbReadBool.HighAlarm2 == false && sttLowAlarm2 == true)
                            {
                                try
                                {
                                    writeAlarm(false, true, Properties.Settings.Default.NameAi2, 2);
                                    sttLowAlarm2 = false;
                                }
                                catch (Exception e)
                                {
                                    MessageBox.Show(e.Message);
                                }
                            }

                            // Ai2 write HighAlarm to database
                            if (DbReadBool.HighAlarm2 == true && sttHighAlarm2 == false)
                            {
                                try
                                {
                                    writeAlarm(true, false, Properties.Settings.Default.NameAi2, 2);
                                    sttHighAlarm2 = true;
                                }
                                catch (Exception e)
                                {
                                    MessageBox.Show(e.Message);
                                }
                            }

                            if (DbReadBool.HighAlarm2 == false && sttHighAlarm2 == true)
                            {
                                try
                                {
                                    writeAlarm(true, true, Properties.Settings.Default.NameAi2, 2);
                                    sttHighAlarm2 = false;
                                }
                                catch (Exception e)
                                {
                                    MessageBox.Show(e.Message);
                                }
                            }

                            // Ai3 write LowAlarm to database
                            if (DbReadBool.LowAlarm3 == true && sttLowAlarm3 == false)
                            {
                                try
                                {
                                    writeAlarm(false, false, Properties.Settings.Default.NameAi3, 3);
                                    sttLowAlarm3 = true;
                                }
                                catch (Exception e)
                                {
                                    MessageBox.Show(e.Message);
                                }
                            }

                            if (DbReadBool.LowAlarm3 == false && DbReadBool.HighAlarm3 == false && sttLowAlarm3 == true)
                            {
                                try
                                {
                                    writeAlarm(false, true, Properties.Settings.Default.NameAi3, 3);
                                    sttLowAlarm3 = false;
                                }
                                catch (Exception e)
                                {
                                    MessageBox.Show(e.Message);
                                }
                            }

                            // Ai3 write HighAlarm to database
                            if (DbReadBool.HighAlarm3 == true && sttHighAlarm3 == false)
                            {
                                try
                                {
                                    writeAlarm(true, false, Properties.Settings.Default.NameAi3, 3);
                                    sttHighAlarm3 = true;
                                }
                                catch (Exception e)
                                {
                                    MessageBox.Show(e.Message);
                                }
                            }

                            if (DbReadBool.HighAlarm3 == false && sttHighAlarm3== true)
                            {
                                try
                                {
                                    writeAlarm(true, true, Properties.Settings.Default.NameAi3, 3);
                                    sttHighAlarm3 = false;
                                }
                                catch (Exception e)
                                {
                                    MessageBox.Show(e.Message);
                                }
                            }

                            // Ai4 write LowAlarm to database
                            if (DbReadBool.LowAlarm4 == true && sttLowAlarm4 == false)
                            {
                                try
                                {
                                    writeAlarm(false, false, Properties.Settings.Default.NameAi4, 4);
                                    sttLowAlarm4 = true;
                                }
                                catch (Exception e)
                                {
                                    MessageBox.Show(e.Message);
                                }
                            }

                            if (DbReadBool.LowAlarm4 == false && DbReadBool.HighAlarm4 == false && sttLowAlarm4 == true)
                            {
                                try
                                {
                                    writeAlarm(false, true, Properties.Settings.Default.NameAi4, 4);
                                    sttLowAlarm4 = false;
                                }
                                catch (Exception e)
                                {
                                    MessageBox.Show(e.Message);
                                }
                            }

                            // Ai4 write HighAlarm to database
                            if (DbReadBool.HighAlarm4 == true && sttHighAlarm4 == false)
                            {
                                try
                                {
                                    writeAlarm(true, false, Properties.Settings.Default.NameAi4, 4);
                                    sttHighAlarm4 = true;
                                }
                                catch (Exception e)
                                {
                                    MessageBox.Show(e.Message);
                                }
                            }

                            if (DbReadBool.HighAlarm4 == false && sttHighAlarm4 == true)
                            {
                                try
                                {
                                    writeAlarm(true, true, Properties.Settings.Default.NameAi4, 4);
                                    sttHighAlarm4 = false;
                                }
                                catch (Exception e)
                                {
                                    MessageBox.Show(e.Message);
                                }
                            }

                            // Ai5 write LowAlarm to database
                            if (DbReadBool.LowAlarm5 == true && sttLowAlarm5 == false)
                            {
                                try
                                {
                                    writeAlarm(false, false, Properties.Settings.Default.NameAi5, 5);
                                    sttLowAlarm5 = true;
                                }
                                catch (Exception e)
                                {
                                    MessageBox.Show(e.Message);
                                }
                            }

                            if (DbReadBool.LowAlarm5 == false && DbReadBool.HighAlarm5 == false && sttLowAlarm5 == true)
                            {
                                try
                                {
                                    writeAlarm(false, true, Properties.Settings.Default.NameAi5, 5);
                                    sttLowAlarm5 = false;
                                }
                                catch (Exception e)
                                {
                                    MessageBox.Show(e.Message);
                                }
                            }

                            // Ai5 write HighAlarm to database
                            if (DbReadBool.HighAlarm5 == true && sttHighAlarm5 == false)
                            {
                                try
                                {
                                    writeAlarm(true, false, Properties.Settings.Default.NameAi5, 5);
                                    sttHighAlarm5 = true;
                                }
                                catch (Exception e)
                                {
                                    MessageBox.Show(e.Message);
                                }
                            }

                            if (DbReadBool.HighAlarm5 == false && sttHighAlarm5 == true)
                            {
                                try
                                {
                                    writeAlarm(true, true, Properties.Settings.Default.NameAi5, 5);
                                    sttHighAlarm5 = false;
                                }
                                catch (Exception e)
                                {
                                    MessageBox.Show(e.Message);
                                }
                            }

                            // Ai6 write LowAlarm to database
                            if (DbReadBool.LowAlarm6 == true && sttLowAlarm6 == false)
                            {
                                try
                                {
                                    writeAlarm(false, false, Properties.Settings.Default.NameAi6, 6);
                                    sttLowAlarm6 = true;
                                }
                                catch (Exception e)
                                {
                                    MessageBox.Show(e.Message);
                                }
                            }

                            if (DbReadBool.LowAlarm6 == false && DbReadBool.HighAlarm6 == false && sttLowAlarm6 == true)
                            {
                                try
                                {
                                    writeAlarm(false, true, Properties.Settings.Default.NameAi6, 6);
                                    sttLowAlarm6 = false;
                                }
                                catch (Exception e)
                                {
                                    MessageBox.Show(e.Message);
                                }
                            }

                            // Ai6 write HighAlarm to database
                            if (DbReadBool.HighAlarm6 == true && sttHighAlarm6 == false)
                            {
                                try
                                {
                                    writeAlarm(true, false, Properties.Settings.Default.NameAi6, 6);
                                    sttHighAlarm6 = true;
                                }
                                catch (Exception e)
                                {
                                    MessageBox.Show(e.Message);
                                }
                            }

                            if (DbReadBool.HighAlarm6 == false && sttHighAlarm6 == true)
                            {
                                try
                                {
                                    writeAlarm(true, true, Properties.Settings.Default.NameAi6, 6);
                                    sttHighAlarm6 = false;
                                }
                                catch (Exception e)
                                {
                                    MessageBox.Show(e.Message);
                                }
                            }

                            // Ai7 write LowAlarm to database
                            if (DbReadBool.LowAlarm7 == true && sttLowAlarm7 == false)
                            {
                                try
                                {
                                    writeAlarm(false, false, Properties.Settings.Default.NameAi7, 7);
                                    sttLowAlarm7 = true;
                                }
                                catch (Exception e)
                                {
                                    MessageBox.Show(e.Message);
                                }
                            }

                            if (DbReadBool.LowAlarm7 == false && DbReadBool.HighAlarm7 == false && sttLowAlarm7 == true)
                            {
                                try
                                {
                                    writeAlarm(false, true, Properties.Settings.Default.NameAi7, 7);
                                    sttLowAlarm7 = false;
                                }
                                catch (Exception e)
                                {
                                    MessageBox.Show(e.Message);
                                }
                            }

                            // Ai7 write HighAlarm to database
                            if (DbReadBool.HighAlarm7 == true && sttHighAlarm7 == false)
                            {
                                try
                                {
                                    writeAlarm(true, false, Properties.Settings.Default.NameAi7, 7);
                                    sttHighAlarm7 = true;
                                }
                                catch (Exception e)
                                {
                                    MessageBox.Show(e.Message);
                                }
                            }

                            if (DbReadBool.HighAlarm7 == false && sttHighAlarm7 == true)
                            {
                                try
                                {
                                    writeAlarm(true, true, Properties.Settings.Default.NameAi7, 7);
                                    sttHighAlarm7 = false;
                                }
                                catch (Exception e)
                                {
                                    MessageBox.Show(e.Message);
                                }
                            }
                        }
                        plc.Close();
                    }
                    catch (Exception e)
                    {
                        plc.Close();
                        Thread.Sleep(100);
                        result = plc.Open();
                        Thread.Sleep(100);
                        break;
                    }
                }
            }
            // Function write alarm
            void writeAlarm(bool alarmStatusColor, bool alarmStatus, string aiName, int aiChannel)
            {
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
                    var query = "INSERT INTO alarmlist (ainame, aichannel, aivalue0, aivalue1, aivalue2, aivalue3, aivalue4, aivalue5, aivalue6, aivalue7, alarmstatuscolor, alarmstatus)" +
                                " VALUES ('" + aiName + "', " + aiChannel + ", " + DataAi0 + ", " + DataAi1 + ", " + DataAi2 + ", " + DataAi3 +
                                ", " + DataAi4 + ", " + DataAi5 + ", " + DataAi6 + ", " + DataAi7 + ", " + alarmStatusColor + ", " + alarmStatus + ");";

                    // Database write CMD
                    MySqlCommand cmd = new MySqlCommand(query, con2);
                    cmd.ExecuteNonQuery();
                    con2.Close();
                }
            }
        }

        private void WriteSampleToDatabase()
        {
            while (true)
            {
                if (isConnect==true)
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
                                       "VALUES (" + DataAi0 + ", " + DataAi1 + ", " + DataAi2 + "," + DataAi3 + ", " + DataAi4 + ", " + DataAi5 + ", " + DataAi6 + ", " + DataAi7 + ");";

                            // Database write CMD
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
