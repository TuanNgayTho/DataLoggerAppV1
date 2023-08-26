﻿using System;
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
        static Plc plc = new Plc(CpuType.S71200, "192.168.0.2", 0, 1);
        public static bool running=false;
        public static bool runningConnect = true;

        public MainForm()
        {
            InitializeComponent();
            UserNameLabelel = lblUserName;
            instance = this;

            btnDashboard.BackColor = SystemColors.Control;

            //lblNameOfPage.Text = "Dashboard";
            //this.panel5.Controls.Clear();
            //Dashboard Dashboard_Vrb = new Dashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            //Dashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            //this.panel5.Controls.Add(Dashboard_Vrb);
            Dashboard Dashboard_Vrb = new Dashboard();
            Dashboard_Vrb.Show();
            Dashboard.isStay = true;
            Alarm.isStay = false;
            Trend.isStay= false;
            Monitor.isStay = false;
            Setting.isStay = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var accept = Trend.isStay;
            if (accept == false)
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

                Dashboard.isStay = false;
                Alarm.isStay = false;
                Trend.isStay = true;
                Monitor.isStay = false;
                Setting.isStay = false;
            }
        }

        private void btnExport_Leave(object sender, EventArgs e)
        {
            
        }

        private void btnMonitor_Click(object sender, EventArgs e)
        {
            var accept = Monitor.isStay;
            if (accept == false)
            {
                lblNameOfPage.Text = "Monitor";
                this.pnlFormLoader.Controls.Clear();
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

                Dashboard.isStay = false;
                Alarm.isStay = false;
                Trend.isStay = false;
                Monitor.isStay = true;
                Setting.isStay = false;
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            var accept = Dashboard.isStay;
            if (accept==false)
            {
                lblNameOfPage.Text = "Dashboard";
                this.pnlFormLoader.Controls.Clear();
                this.pnlDashBoard.Hide();
                this.pnlAlarm.Show();
                this.pnlAlarm.BringToFront();
                this.pnlAlarm.TabStop=true;
                //Dashboard Dashboard_Vrb = new Dashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                //Dashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
                //this.pnlFormLoader.Controls.Add(Dashboard_Vrb);
                //Dashboard_Vrb.Show();

                btnDashboard.BackColor = SystemColors.Control;
                btnAlarmList.BackColor = SystemColors.ControlLight;
                btnTrend.BackColor = SystemColors.ControlLight;
                btnSettings.BackColor = SystemColors.ControlLight;
                btnMonitor.BackColor = SystemColors.ControlLight;

                Dashboard.isStay = true;
                Alarm.isStay = false;
                Trend.isStay = false;
                Monitor.isStay = false;
                Setting.isStay = false;
            }
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            
        }

        private void btnAlarmList_Click(object sender, EventArgs e)
        {
            var accept = Alarm.isStay;
            if (accept == false)
            {
                lblNameOfPage.Text = "Alarm List";
                this.pnlFormLoader.Show();
                this.pnlFormLoader.Controls.Clear();
                //this.panel5.Hide();
                Alarm Alarm_Vrb = new Alarm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                Alarm_Vrb.FormBorderStyle = FormBorderStyle.None;
                this.pnlFormLoader.Controls.Add(Alarm_Vrb);
                Alarm_Vrb.Show();

                btnDashboard.BackColor = SystemColors.ControlLight;
                btnAlarmList.BackColor = SystemColors.Control;
                btnTrend.BackColor = SystemColors.ControlLight;
                btnSettings.BackColor = SystemColors.ControlLight;
                btnMonitor.BackColor = SystemColors.ControlLight;

                Dashboard.isStay = false;
                Alarm.isStay = true;
                Trend.isStay = false;
                Monitor.isStay = false;
                Setting.isStay = false;
            }
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
                var accept = Setting.isStay;
                if (accept == false)
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

                    Dashboard.isStay = false;
                    Alarm.isStay = false;
                    Trend.isStay = false;
                    Monitor.isStay = false;
                    Setting.isStay = true;
                }
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
