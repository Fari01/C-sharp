using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask
{
    class Phone
    {
        public int count=0;
        MusicFiles[] m;
       public string Title { get; set; }
        public string Artist { get; set; }
       public int YearOfRelease { get; set; }
        public int DurationInSeconds { get; set; }


        public void ChangeTitle(string title)
        {
            Console.WriteLine("One of the song tittle is changed");
            Console.WriteLine("The new title is: " + title);
            Console.WriteLine("---------------");
        }

       public Phone()
        {
            m = new MusicFiles[500];
        }


        public Phone(string title, string artist, int yearOfRelease, int durationInSeconds)
        {
            Title = title;
            Artist = artist;
            YearOfRelease = yearOfRelease;
            DurationInSeconds = durationInSeconds;
            m = new MusicFiles[500];
        }
        public void AddSong(MusicFiles v)
        {
            
               m[count++] = v;
            Console.WriteLine("--Add songs--");
            Console.WriteLine("The number of songs added is: " + count);


        }











    }
}
