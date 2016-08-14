using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drumpad_Application
{
    public partial class Test_timings : Form
    {
        Timer stimer = new Timer();
        List<string> song;
        int counter, emptycounter;
        public Test_timings()
        {
            InitializeComponent();
            song = new List<string>();
            counter = 0;
            emptycounter = 0;

            stimer.Tick += new EventHandler(nothing);
        }

        private void start_Click(object sender, EventArgs e)
        {
            stimer.Interval = 250;
            stimer.Start();

        }

        private void pushme_Click(object sender, EventArgs e)
        {
            song.Add("+");
            ++counter;
            lbl_output.Text += "+";
        }

        private void stop_Click(object sender, EventArgs e)
        {
            stimer.Stop();
            time.Text = counter.ToString() + " " + emptycounter.ToString();
            counter = 0;
            emptycounter = 0;           
        }
        private void nothing(object sender, EventArgs e)
        {
            if (emptycounter == counter)
            {
                song.Add("0");
                ++counter;
                ++emptycounter;
                lbl_output.Text += "0";
            }
            else {
                ++counter;
                ++emptycounter;
                ++emptycounter;
            }
            
            
        }
    }
}
