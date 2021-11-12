using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask
{
    class Person
    {

        public string Name { get; set; }
        Account[] account;
        int count;
        public Person() {
            account = new Account[100];
               
        }
        public void AddAccount(Account a)
        {
            account[count++] = a;
        }
        public void ShowAccount()
        {
            for (int i = 0; i < count; i++)
            {
                account[i].Show();



            }
        }
    }
}
