using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask
{
    interface IRadioPlayerInterface
    {
       // void switch(bool on); 
 void retune(double frequency); 
 void setVolume(int loudness); 
 void changeChannel();

    }
}
