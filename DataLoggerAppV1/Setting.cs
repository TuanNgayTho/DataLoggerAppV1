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
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Setting_Load(object sender, EventArgs e)
        {
            txbUnitAi0.Text = Properties.Settings.Default.UnitAi0;
            txbUnitAi1.Text = Properties.Settings.Default.UnitAi1;
            txbUnitAi2.Text = Properties.Settings.Default.UnitAi2;
            txbUnitAi3.Text = Properties.Settings.Default.UnitAi3;
            txbUnitAi4.Text = Properties.Settings.Default.UnitAi4;
            txbUnitAi5.Text = Properties.Settings.Default.UnitAi5;
            txbUnitAi6.Text = Properties.Settings.Default.UnitAi6;
            txbUnitAi7.Text = Properties.Settings.Default.UnitAi7;

            txbNameAi0.Text = Properties.Settings.Default.NameAi0;
            txbNameAi1.Text = Properties.Settings.Default.NameAi1;
            txbNameAi2.Text = Properties.Settings.Default.NameAi2;
            txbNameAi3.Text = Properties.Settings.Default.NameAi3;
            txbNameAi4.Text = Properties.Settings.Default.NameAi4;
            txbNameAi5.Text = Properties.Settings.Default.NameAi5;
            txbNameAi6.Text = Properties.Settings.Default.NameAi6;
            txbNameAi7.Text = Properties.Settings.Default.NameAi7;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
