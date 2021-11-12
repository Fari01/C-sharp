using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask
{
    interface IBasicBankingInterface
    {
        bool deposit(int amount);
         bool withdraw(int amount);
    }
}
