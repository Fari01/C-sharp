using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ClassTask
{
    class TermDepositAccount : Account
    {


        public int tenureyear;
        public DateTime creationTime;
        public TermDepositAccount()
        {





        }
        public TermDepositAccount(string no, string name, double balance, int tenureyear, DateTime ct)
        {
            this.tenureyear = tenureyear;
            creationTime = ct;





        }
        public override void Withdraw(double amount)
        {
            DateTime now = DateTime.Now;
            int c_year = now.Year;
            int acop_year = creationTime.Year;
            if (c_year - acop_year >= tenureyear)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("your acc is not matured yet");
            }
        }





        public override void Show()
        {
            base.Show();
            Console.WriteLine("Type: Savings {0} years", tenureyear);
            Console.WriteLine("Creation year: " + creationTime.Year);
            Console.WriteLine("Tenure year: " + tenureyear);
        }





    }



}