using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankExample
{
    public abstract class Account
    {
        public string Owner { get; }

        public decimal Balance { get; set; } = new decimal();            

        public Account(string owner, decimal balance)
        {
            if (string.IsNullOrEmpty(owner)) throw new ArgumentNullException("Owner is required.");
            if (balance < 0) throw new ArgumentOutOfRangeException("Accounts cannot be created with a negative balance.");           

            Owner = owner;
            Balance = balance;           
        }      
    }
}
