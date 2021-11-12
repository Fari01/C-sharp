using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask
{

    abstract class Account
    {
        public string AccNo { get; set; }
        public string AccName { get; set; }
        public double Balance { get; set; }
        public Account() { }
        public Account(string no, string name, double balance)
        {
            this.AccNo = no;
            this.AccName = name;
            this.Balance = balance;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
        /*public virtual void Withdraw(double amount)
        {
        if (amount<Balance)Balance += amount;
        }*/
        abstract public void Withdraw(double amount);
        public virtual void Show()
        {
            Console.WriteLine("Acc No:" + AccNo);
            Console.WriteLine("Acc Name:" + AccName);
            Console.WriteLine("Acc Balance:" + Balance);
        }
    }
}


