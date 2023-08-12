using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataLoggerAppV1
{
    public partial class CreaCertificate : Form
    {
        public static CreaCertificate instance;
        public CreaCertificate()
        {
            InitializeComponent();
            instance = this;
        }


        private void CreaCertificate_Load(object sender, EventArgs e)
        {
            lblUnitAi0.Text = Properties.Settings.Default.UnitAi0;
            lblUnitAi1.Text = Properties.Settings.Default.UnitAi1;
            lblUnitAi2.Text = Properties.Settings.Default.UnitAi2;
            lblUnitAi3.Text = Properties.Settings.Default.UnitAi3;
            lblUnitAi4.Text = Properties.Settings.Default.UnitAi4;
            lblUnitAi5.Text = Properties.Settings.Default.UnitAi5;
            lblUnitAi6.Text = Properties.Settings.Default.UnitAi6;
            lblUnitAi7.Text = Properties.Settings.Default.UnitAi7;

            lblNameAi0.Text = Properties.Settings.Default.NameAi0;
            lblNameAi1.Text = Properties.Settings.Default.NameAi1;
            lblNameAi2.Text = Properties.Settings.Default.NameAi2;
            lblNameAi3.Text = Properties.Settings.Default.NameAi3;
            lblNameAi4.Text = Properties.Settings.Default.NameAi4;
            lblNameAi5.Text = Properties.Settings.Default.NameAi5;
            lblNameAi6.Text = Properties.Settings.Default.NameAi6;
            lblNameAi7.Text = Properties.Settings.Default.NameAi7;

            lblAiDataCh0.Text = Dashboard.instance.AiDataCh0.Text;
            lblAiDataCh1.Text = Dashboard.instance.AiDataCh1.Text;
            lblAiDataCh2.Text = Dashboard.instance.AiDataCh2.Text;
            lblAiDataCh3.Text = Dashboard.instance.AiDataCh3.Text;
            lblAiDataCh4.Text = Dashboard.instance.AiDataCh4.Text;
            lblAiDataCh5.Text = Dashboard.instance.AiDataCh5.Text;
            lblAiDataCh6.Text = Dashboard.instance.AiDataCh6.Text;
            lblAiDataCh7.Text = Dashboard.instance.AiDataCh7.Text;

            tbxCustomerName.Text = Properties.Settings.Default.CustomerName;
            tbxCustomerID.Text = Properties.Settings.Default.CustomerID;

            cbxAi0.Checked = Properties.Settings.Default.SlectAi0;
            cbxAi1.Checked = Properties.Settings.Default.SlectAi1;
            cbxAi2.Checked = Properties.Settings.Default.SlectAi2;
            cbxAi3.Checked = Properties.Settings.Default.SlectAi3;
            cbxAi4.Checked = Properties.Settings.Default.SlectAi4;
            cbxAi5.Checked = Properties.Settings.Default.SlectAi5;
            cbxAi6.Checked = Properties.Settings.Default.SlectAi6;
            cbxAi7.Checked = Properties.Settings.Default.SlectAi7;

        }

        private void dateTimePicker2_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
