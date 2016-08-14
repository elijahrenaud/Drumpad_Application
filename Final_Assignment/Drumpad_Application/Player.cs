using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Drumpad_Application
{
    class Player
    {
        Timer stimer = new Timer(100);
        public List<string> song;
        int counter, emptycounter;

        public Player()
        {
            song = new List<string>();
            counter = 0;
            emptycounter = 0;
            stimer.Elapsed += new ElapsedEventHandler(timer_tick);
        }
        public void start()
        {           
            stimer.Start();

        }

        public void push(int s)
        {
            song.Add(s.ToString());
            ++counter;          
        }
        public void pause()
        {
            stimer.Stop();
        }

        public void stop()
        {
            stimer.Stop();          
            counter = 0;
            emptycounter = 0;
        }
        public void timer_tick(object sender, EventArgs e)
        {
            if (emptycounter == counter)
            {
                song.Add("-");
                ++counter;
                ++emptycounter;
               
            }
            else
            {
                ++counter;
                ++emptycounter;
                ++emptycounter;
            }


        }



    }
}
