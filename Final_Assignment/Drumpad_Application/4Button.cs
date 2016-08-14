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
    public partial class Form1 : Form
    {
        Player p;
        public Form1()
        {
            InitializeComponent();
            p = new Player();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.push(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p.push(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            p.push(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            p.push(4);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
             foreach (string s in p.song)
                textBox1.Text += s;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            p.pause();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            p.stop();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            p.start();
        }
    }
}
