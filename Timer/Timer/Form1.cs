using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class window : Form
    {
        public window()
        {
            InitializeComponent();
        }

        //default time 1min
        int timeleft = 60;

        private void timerlabel_Click(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void restart_Click(object sender, EventArgs e)
        {
            timeleft = 60;
            timer.Stop();
        }

        private void pause_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeleft > 0)
            {
                timeleft--;
                timerlabel.Text = "00:" + timeleft;
            }

            else
            {
                timerlabel.Text = "Finish";
            }
        }

        private void setting_Click(object sender, EventArgs e)
        {
            //open new window
        }
    }
}
