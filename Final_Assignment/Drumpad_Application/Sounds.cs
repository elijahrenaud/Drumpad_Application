using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drumpad_Application
{
    class Sounds
    {
        //Objects
        SoundPlayer sound1;
        SoundPlayer sound2;
        SoundPlayer sound3;
        SoundPlayer sound4;
        SoundPlayer sound5;
        SoundPlayer sound6;
        SoundPlayer sound7;
        SoundPlayer sound8;
        SoundPlayer sound9;

        //Constructor
        public Sounds()
        {
            try {
                //Initialize Sounds
                Stream sFile1 = Properties.Resources.Kick1;
                sound1 = new SoundPlayer(sFile1);
                sound1.Load();

                Stream sFile2 = Properties.Resources.Snare1;
                sound2 = new SoundPlayer(sFile2);
                sound2.Load();

                Stream sFile3 = Properties.Resources.HiHat1;
                sound3 = new SoundPlayer(sFile3);
                sound3.Load();

                Stream sFile4 = Properties.Resources.Piano1;
                sound4 = new SoundPlayer(sFile4);
                sound4.Load();

                Stream sFile5 = Properties.Resources.Laser2;
                sound5 = new SoundPlayer(sFile5);
                sound5.Load();

                Stream sFile6 = Properties.Resources.Pop1;
                sound6 = new SoundPlayer(sFile6);
                sound6.Load();

                Stream sFile7 = Properties.Resources.DoorBell1;
                sound7 = new SoundPlayer(sFile7);
                sound7.Load();

                Stream sFile8 = Properties.Resources.Slap1;
                sound8 = new SoundPlayer(sFile8);
                sound8.Load();

                Stream sFile9 = Properties.Resources.Robot1;
                sound9 = new SoundPlayer(sFile9);
                sound9.Load();
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Sounds did not load Correctly!",
                    "Oops!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk   
                );
            }

        }

        public void play(int sample)
        {
            switch (sample)
            {
                case 1:
                    sound1.Play();
                    break;
                case 2:
                    sound2.Play();
                    break;
                case 3:
                    sound3.Play();
                    break;
                case 4:
                    sound4.Play();
                    break;
                case 5:
                    sound5.Play();
                    break;
                case 6:
                    sound6.Play();
                    break;
                case 7:
                    sound7.Play();
                    break;
                case 8:
                    sound8.Play();
                    break;
                case 9:
                    sound9.Play();
                    break;
            }
        }
    }
}
