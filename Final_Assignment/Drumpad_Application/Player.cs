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
        Timer stimer = new Timer(50);
        public string song;
        int counter, emptycounter, playercounter;
        Timer ptimer = new Timer(50);
        Sounds music = new Sounds();



        //Default
        public Player()
        {
            song = "";
            counter = 0;
            emptycounter = 0;
            stimer.Elapsed += new ElapsedEventHandler(timer_tick);
            ptimer.Elapsed += new ElapsedEventHandler(player_timer);
        }

        public void play() {
            playercounter = 0;
            counter = 0;
            stimer.Stop();            
            ptimer.Start();
        }

        public void player_timer(object sender, EventArgs e)
        {
            if (playercounter < song.Length)
            {
                char c = song[playercounter];
                if (!c.Equals('-'))
                {
                    if (Char.IsDigit(c))
                        music.play((int)Char.GetNumericValue(c));
                }
                playercounter++;
            }
            else
                ptimer.Stop();
        }


        //With File
        public Player(string _song) {
            song = _song;
            counter = 0;
            emptycounter = 0;
            stimer.Elapsed += new ElapsedEventHandler(timer_tick);
            ptimer.Elapsed += new ElapsedEventHandler(player_timer);
        }

        public void start()
        {
            song = "";
            stimer.Start();

        }

        public void push(int s)
        {
            song += s.ToString();
            ++counter;
        }
        public void pause()
        {
            if (stimer.Enabled)
                stimer.Stop();
            else
                stimer.Start();
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
                song += "-";
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

