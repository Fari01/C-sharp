using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask
{
    class Overdraft : Account , IBasicBankingInterface
    {
        public Overdraft(int l)
        {
            limit = l;

        }
        public int limit=10000;
        public bool deposit(int amount)
        {if (amount < Balance )
            {

                Balance += amount;
                return true;
                Console.WriteLine("Amount deposited" + Balance);
            }
            else return false;
        }

        public bool withdraw(int amount)
        {
            if (amount < Balance + limit)
            {

                Balance -= amount;
                return true;
                Console.WriteLine("Amount withdrawn" + Balance );
            }
            else return false;
        }
       
        public override void Withdraw(double amount)
        {
           
        }
    }
}




