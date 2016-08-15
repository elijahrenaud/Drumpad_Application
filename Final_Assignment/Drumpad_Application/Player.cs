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
        Timer stimer = new Timer(50); // read timer
        public string song; // the holding string for the data of the song 
        int counter, emptycounter, playercounter; // 3 counters to handle clicks and navigate the song
        Timer ptimer = new Timer(50);// play sound timer
        Sounds music = new Sounds();//our sound object



        //Default
        public Player()
        {
            song = "";
            counter = 0;
            emptycounter = 0;
            //bind timer events
            stimer.Elapsed += new ElapsedEventHandler(timer_tick);
            ptimer.Elapsed += new ElapsedEventHandler(player_timer);
        }
        /// <summary>
        /// play the song
        /// </summary>
        public void play() {
            playercounter = 0;
            counter = 0;
            stimer.Stop();            
            ptimer.Start();
        }
        /// <summary>
        /// trigger the event of timer elapsed while playing the song
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        /// <summary>
        /// Constructor for the existing song
        /// </summary>
        /// <param name="_song">song string will go here</param>
        public Player(string _song) {
            song = _song;
            counter = 0;
            emptycounter = 0;
            //bind timer events
            stimer.Elapsed += new ElapsedEventHandler(timer_tick);
            ptimer.Elapsed += new ElapsedEventHandler(player_timer);
        }
        /// <summary>
        /// start the timer -- record the song
        /// </summary>
        public void start()
        {
            song = "";
            stimer.Start();

        }

        /// <summary>
        /// when the button is pushed it will write the char in the song string
        /// </summary>
        /// <param name="s">button number</param>
        public void push(int s)
        {
            song += s.ToString();
            ++counter;
        }
        /// <summary>
        /// pause/continue button for the timer pause
        /// </summary>
        public void pause()
        {
            if (stimer.Enabled)
                stimer.Stop();
            else
                stimer.Start();
        }

        /// <summary>
        /// stop writing the song, final point
        /// </summary>
        public void stop()
        {
            stimer.Stop();
            counter = 0;
            emptycounter = 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

