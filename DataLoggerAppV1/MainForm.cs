using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DataLoggerAppV1
{
    public partial class MainForm : Form
    {
        public static MainForm instance;
        public static bool IsLogIn = false;
        public Label UserNameLabelel;
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void button3_Click(object sender, EventArgs e)
        {
            lblNameOfPage.Text = "Export";
            this.pnlFormLoader.Controls.Clear();
            Export Export_Vrb = new Export() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Export_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(Export_Vrb);
            Export_Vrb.Show();

            btnDashboard.BackColor = SystemColors.ControlLight;
            btnAlarmList.BackColor = SystemColors.ControlLight;
            btnExport.BackColor = SystemColors.Control;
            btnSettings.BackColor = SystemColors.ControlLight;
        }

        private void btnExport_Leave(object sender, EventArgs e)
        {
            
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
            btnExport.BackColor = SystemColors.ControlLight;
            btnSettings.BackColor = SystemColors.ControlLight;
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
            btnExport.BackColor = SystemColors.ControlLight;
            btnSettings.BackColor = SystemColors.ControlLight;
        }

        private void btnAlarmList_Leave(object sender, EventArgs e)
        {
            
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new LoginPage().Show();
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
                btnExport.BackColor = SystemColors.ControlLight;
                btnSettings.BackColor = SystemColors.Control;
            }
            else
            {
                new LoginPage().Show();
            }
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
