using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask
{
    class MusicFiles
    {
        public string SongName { get; set; }
        public string SongNo{ get; set; }
        public string SongCatagory { get; set; }
        public MusicFiles(string sname, string sno, string scata )
        {
            SongName = sname;
            SongNo = sno;
            SongCatagory = scata;
        }
        public void Show()
        {
            Console.WriteLine("------Playlist---------" );
            Console.WriteLine("  ");
            Console.WriteLine("Song Name: "+ SongName);
            Console.WriteLine("Song Name: " + SongNo);
            Console.WriteLine("Song Name: " + SongCatagory);
            Console.WriteLine("---------------------------------" );
        }
    }
}
