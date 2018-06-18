using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Clock_dung_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Timer t = new Timer();
        private void Form1_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;  // interval la 1s
            t.Tick += new EventHandler(t_Tick);
            t.Start();  // chay bo timer
        }

        private void t_Tick(object sender, EventArgs e)
        {
            int hh, mm, ss;
            hh = DateTime.Now.Hour;
            mm = DateTime.Now.Minute;
            ss = DateTime.Now.Second;
            string time = "";
            if(hh<10)
            {
                time += "0" + hh.ToString();
            }
            else
            {
                time += hh.ToString();
            }
            time += ":";
            if(mm<10)
            {
                time += "0" + mm.ToString();
            }
            else
            {
                time += mm.ToString();
            }
            time += ":";
            if (ss<10)
            {
                time += "0" + ss.ToString();
            }
            else
            {
                time += ss.ToString();
            }

            lblTime.Text = time;
        }
    }
}
