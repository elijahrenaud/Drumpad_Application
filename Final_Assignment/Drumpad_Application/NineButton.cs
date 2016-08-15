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
        Timer utimer = new Timer();

        public NineButton()
        {
            InitializeComponent();
            samples = new Sounds();
            p = new Player();
            utimer.Interval = 50;
            utimer.Tick += new EventHandler(upd);
        }
        private void upd(object sender, EventArgs e)
        {
            textBox1.Text = p.song;
            textBox1.Update();
        }

        //Functions Buttons
        private void btnPlay_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            foreach (char s in p.song)
                textBox1.Text += s;
            textBox1.Refresh();
            if (String.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("The song is empty");
            }
            else
            {
                p.play();
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            p.pause();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnPause.Enabled = false;
            btnPlay.Enabled = true;
            btnRecord.Enabled = true;
            btnStop.Enabled = false;
            p.stop();
            utimer.Stop();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            btnPause.Enabled = true;
            btnPlay.Enabled = false;
            btnRecord.Enabled = false;
            btnStop.Enabled = true;
            p.start();
            utimer.Start();
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

        private void button5_Click(object sender, EventArgs e)
        {
            p.push(5);
            samples.play(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            p.push(6);
            samples.play(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            p.push(7);
            samples.play(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            p.push(8);
            samples.play(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            p.push(9);
            samples.play(9);
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

        private void padToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FourButton swap = new FourButton();
            this.Hide();
            swap.Focus();
            swap.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string helpString = String.Format(Properties.Resources.Instructions, Environment.NewLine + Environment.NewLine);

            MessageBox.Show(
                helpString,
                "How To",
                MessageBoxButtons.OK,
                MessageBoxIcon.Question
            );
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
