using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankExample
{
    public class CheckingAccount : Account
    {
        public AccountType AccountType { get; } = AccountType.Checking;

        public CheckingAccount(string owner, decimal balance) : base(owner, balance)
        {
        }
    }
}
