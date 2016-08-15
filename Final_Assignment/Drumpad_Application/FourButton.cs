using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drumpad_Application
{
    public partial class FourButton : Form
    {
        //Objects
        Sounds samples;
        Player p;

        public FourButton()
        {
            InitializeComponent();
            samples = new Sounds();
            p = new Player();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.push(1);
            samples.play(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p.push(2);
            samples.play(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            p.push(3);
            samples.play(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            p.push(4);
            samples.play(4);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            foreach (char s in p.song)
                textBox1.Text += s;
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

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofdImport.Title = "Open Song File";
            ofdImport.Filter = "txt song files|*.txt";
            if (ofdImport.ShowDialog() == DialogResult.OK) {
                string data = File.ReadAllText(ofdImport.FileName);
                foreach (char c in data) {
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
            if (sfdexport.ShowDialog() == DialogResult.OK) {
                File.WriteAllText(sfdexport.FileName, p.song);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
