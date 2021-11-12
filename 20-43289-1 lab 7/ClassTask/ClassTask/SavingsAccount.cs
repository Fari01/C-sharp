using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ClassTask
{
    class SavingsAccount : Account
    {
        public SavingsAccount() { }
        public SavingsAccount(string name, string no, double balance) : base(name, no, balance)
        {



        }
        public override void Withdraw(double amount)
        {
            if (amount<= (80/100) *Balance)
            {
                Balance -= amount;
            }
            Console.WriteLine("Minimum Balance 500 not maintained");
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("Type: Savings");
        }
    }
}