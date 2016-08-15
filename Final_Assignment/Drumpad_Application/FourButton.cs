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
        Sounds samples; // object to hold the sounds
        Player p; // main player
        Timer utimer = new Timer(); // updating timer

        public FourButton()
        {
            InitializeComponent();
            //initialize objects
            samples = new Sounds(); 
            p = new Player();
            //set the timer effects
            utimer.Interval = 50;
            utimer.Tick += new EventHandler(upd);
            this.Focus();
        }
        /// <summary>
        /// update textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void upd(object sender, EventArgs e) {
            textBox1.Text = p.song;
            textBox1.Update();
        }
        /// <summary>
        /// a list of functions to record the sound
        /// </summary>
        
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

        /// <summary>
        /// play the song that us currently in the player
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        //open and save file dialogs
        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofdImport.Title = "Open Song File";
            ofdImport.Filter = "txt song files|*.txt";
            try
            {
                if (ofdImport.ShowDialog() == DialogResult.OK)
                {
                    string data = File.ReadAllText(ofdImport.FileName);
                    //check if the file is proper file
                    foreach (char c in data)
                    {
                        if (!(c.Equals('-') || char.IsDigit(c)))
                        {
                            MessageBox.Show("This file is not a song. Please try other file");
                            return;
                        }
                        else
                        {
                            p = new Player(data);
                        }
                    }
                }
            }
            catch {
                MessageBox.Show("Error during file opening");
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfdexport.Title = "Save as text file";
            sfdexport.Filter = "txt song files|*.txt";
            try
            {
                if (sfdexport.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfdexport.FileName, p.song);
                }
            }
            catch {
                MessageBox.Show("Error during file closing");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void form_KeyDown(object sender, KeyEventArgs e)
        {
          //bind to keyboard
            switch (e.KeyCode)
            {
                case Keys.Q:
                   
                    e.Handled = true;
                    button1.PerformClick();
                    break;
                case Keys.W:
                    e.Handled = true;
                    button2.PerformClick();
                    break;
                case Keys.A:
                    e.Handled = true;
                    button3.PerformClick();
                    break;
                case Keys.S:
                    e.Handled = true;
                    button4.PerformClick();
                    break;

            }
        }

        private void padToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open other form
            NineButton swap = new NineButton();
            this.Hide();
            swap.Focus();
            swap.Show();
        }

        //help and about box

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string helpString = String.Format(Properties.Resources.Instructions, Environment.NewLine + Environment.NewLine);

            MessageBox.Show(
                helpString,
                "Help",
                MessageBoxButtons.OK,
                MessageBoxIcon.Question
            );
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string aboutString = String.Format(Properties.Resources.About, Environment.NewLine);

            MessageBox.Show(
                aboutString,
                "About",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
