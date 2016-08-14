using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Drumpad_Application
{
    class Sounds
    {
        //Objects
        SoundPlayer sound1;
        SoundPlayer sound2;

        //Constructor
        public Sounds()
        {
            //Initialize Sounds
            Stream sFile1 = Properties.Resources.Kick1;
            sound1 = new SoundPlayer(sFile1);
            sound1.Load();

            Stream sFile2 = Properties.Resources.Snare1;
            sound2 = new SoundPlayer(sFile2);
            sound2.Load();
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
            }
        }
    }
}
