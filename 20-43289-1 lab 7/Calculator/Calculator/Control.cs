using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Control:Implementation, IBasicCalculator
    {
        public Control(string name, string ed) : base(name,ed)
        {

        }
        
        public int sum(int x, int y)
        {
            int result = x + y;
            return result;
        }
       public int sub(int x, int y)
        {
            int result2 = x - y;
            return result2;
        }
       public int multiplication(int x, int y)
        {
            int result3 = x * y;
            return result3;
        }
        public int division(int x, int y)
        {
            int result4 = x / y;
            return result4;
        }
        /*int XtoY(int x, int y)
        {

        }*/
       
        public new void Show()
        {
            base.Show();
            Console.WriteLine(".............") ;
        }
    }
}
