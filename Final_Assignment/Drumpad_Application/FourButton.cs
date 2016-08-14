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
    public partial class FourButton : Form
    {
        //Objects
        Sounds samples;

        public FourButton()
        {
            InitializeComponent();
            samples = new Sounds();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            samples.play(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            samples.play(2);
        }
    }
}
