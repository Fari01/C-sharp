
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask
{
    class Program
    {


        static void Main(string[] args)
        {
            Person tan = new Person();
            Account acc = new CurrentAccount("1001", "Fariha", 9876);
           Account acc2 = new SavingsAccount("1002", "Karim", 8383);
            Account acc3 = new Overdraft(10000);

            tan.AddAccount(acc);
            tan.AddAccount(acc2);
            acc3.Withdraw(10);
            acc3.Deposit(180);
            tan.ShowAccount();
           
        }
    }
}

