using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataLoggerAppV1
{
    public partial class splashscreen : Form
    {
        int c = 0;
        public splashscreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            c++;
            materialProgressBar1.Value = c;
            if (c == 300)
            {
                this.Close();
            }
        }
    }
}
