using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask
{
    class Ipod : IMusicPlayerInterface, IRadioPlayerInterface
    {
        public int musicFileCount;
        MusicFiles[] musicFiles;

       public Ipod()
        {
            musicFiles = new MusicFiles[10];
        }
        public void changeChannel()
        {
            Console.WriteLine("Changing The Radio Channel.");
        }

        public void play(bool on)
        {
            bool start = true;
            bool stop = false;
            if (on == true)
            {
                Console.WriteLine("The Music Player Is Playing Music On The Phone");
            }
            else
            {
                Console.WriteLine("The Music Player Is Not Playing Music On The Phone");
            }
        }

        public void playNext()
        {
            Console.WriteLine("Next Music In The PlayList Of The MusicPlayer.");
            for (int i = 1; i < musicFileCount; i++)
            {
                this.musicFiles[i + 1].Show();
                break;
            }
        }

        public void playPrevious()
        {
            Console.WriteLine("Previous Music In The PlayList Of The MusicPlayer.");
            for (int i = 0; i < musicFileCount; i++)
            {
                this.musicFiles[i].Show();
                break;
            }
        }
        public void retune(double frequencyLevel)
        {
            Console.WriteLine("The Radio Player Cuurent Frequency Number : " + frequencyLevel);
        }

        public void setVolume(int loudnessLevel)
        {

            if (loudnessLevel >= 0)
            {
                Console.WriteLine("The Music Player Music Loudness Level Is Now : " + loudnessLevel);
            }
            else
            {
                Console.WriteLine("Volume Is Set Now On ''0'' ");
                Console.WriteLine("The Music Player Music Loudness Level In Negative Level That Why " + loudnessLevel + "Considered As 0 Level Loudness.");
            }
        }
    }
}

