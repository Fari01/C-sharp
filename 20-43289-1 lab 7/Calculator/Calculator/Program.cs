using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Control e = new Control("Casio", "2001");
            e.Show();
            Console.WriteLine("The sumation is: " + e.sum(2, 3));
            Console.WriteLine("The subtration is: " + e.sub(2, 3));
            Console.WriteLine("The multiplication is: " + e.multiplication(2, 3));
            Console.WriteLine("The division is: " + e.division(2, 3));
           
          




        }
    }
}
