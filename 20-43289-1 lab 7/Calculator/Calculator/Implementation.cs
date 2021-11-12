using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
  abstract  class Implementation
    {
        public string CalName { get; set; }
        public string Edition { get; set; }
       public Implementation(string name, string ed)
        {
            CalName = name;
            Edition = ed;
        }

        public virtual void Show() {
            {
                Console.WriteLine("You're using Calculator: " + CalName);
                Console.WriteLine("You're using Calculator edition: " + Edition);
            }
        }






    }
}
