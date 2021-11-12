using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask
{

    class CurrentAccount : Account
    {
        public CurrentAccount() { }
        public CurrentAccount(string no, string name, double balance) : base(no, name, balance)
        {



        }
        public override void Withdraw(double amount)
        {
            Balance -= amount;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("Type: Current");
        }
    }
}

