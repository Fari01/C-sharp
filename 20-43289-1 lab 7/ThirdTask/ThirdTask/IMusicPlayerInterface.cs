using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask
{
    interface IMusicPlayerInterface
    { 
      //void switch(bool o); 
            void play(bool on); 
 void setVolume(int loudness); 
 void playNext(); 
 void playPrevious();
    }
}
