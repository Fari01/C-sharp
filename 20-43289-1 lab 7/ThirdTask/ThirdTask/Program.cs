using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask
{
    class Program
    {
        static void Main(string[] args)
        {
            MusicFiles m = new MusicFiles("Shiver", "1", "pop");
            MusicFiles m1 = new MusicFiles("Dynamite", "2", "kpop");
            MusicFiles m2 = new MusicFiles("Lovely", "3", "pop");
            m.Show();
            m1.Show();
            m2.Show();
            Phone p = new Phone("dope", "bts", 2014, 3);
            p.AddSong(m);
            p.AddSong(m1);
            p.AddSong(m2);
            Console.WriteLine("---------------");
            p.ChangeTitle("Blood sweat and tear");
            Ipod i = new Ipod();
          
            i.changeChannel();
            Console.WriteLine("---------------");
            i.play(true);
            Console.WriteLine("---------------");
            i.retune(12.4);
            Console.WriteLine("---------------");
            i.setVolume(10);
            Console.WriteLine("---------------");
            i.playNext();
            Console.WriteLine("---------------");
            i.playPrevious();


        }
    }
}
