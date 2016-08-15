using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Drumpad_Application
{
    public partial class NineButton : Form
    {
        //Objects
        Sounds samples;
        Player p;

        public NineButton()
        {
            InitializeComponent();
            samples = new Sounds();
            p = new Player();
        }

        //Functions Buttons
        private void btnPlay_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            foreach (char s in p.song)
                textBox1.Text += s;
            textBox1.Refresh();
            p.play();
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


        //Sample Buttons
        private void button1_Click(object sender, EventArgs e)
        {
            p.push(1);
            samples.play(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p.push(2);
            samples.play(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            p.push(3);
            samples.play(1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            p.push(4);
            samples.play(1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //p.push(1);
            samples.play(1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //p.push(1);
            samples.play(1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //p.push(1);
            samples.play(1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //p.push(1);
            samples.play(1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //p.push(1);
            samples.play(1);
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofdImport.Title = "Open Song File";
            ofdImport.Filter = "txt song files|*.txt";
            if (ofdImport.ShowDialog() == DialogResult.OK)
            {
                string data = File.ReadAllText(ofdImport.FileName);
                foreach (char c in data)
                {
                    if (!(c.Equals('-') || char.IsDigit(c)))
                    {
                        MessageBox.Show("This file is not a song. Please try other file");
                        return;
                    }
                    else {
                        p = new Player(data);
                    }
                }
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfdexport.Title = "Save as text file";
            sfdexport.Filter = "txt song files|*.txt";
            if (sfdexport.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfdexport.FileName, p.song);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
