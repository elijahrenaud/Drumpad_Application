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
        public string song;
        int counter, emptycounter;

        public Player()
        {
            song = "";
            counter = 0;
            emptycounter = 0;
            stimer.Elapsed += new ElapsedEventHandler(timer_tick);
        }

        public Player(string _song) {
            song = _song;
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
            song+=s.ToString();
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
                song+="-";
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
