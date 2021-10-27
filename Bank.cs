using System;
using System.Collections.Generic;

namespace BankExample
{
    public class Bank
    {
        public string Name { get; private set; }

        public Bank(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException("Name is required.");
            Name = name;
        }

        public List<Account> Accounts { get; private set; } = new List<Account>();

        public bool Transfer(ref Account sender, ref Account reciever, decimal amount)
        {
            if (amount <= 0) return false;
            if (!Withdraw(ref sender, amount)) return false; 
            Deposit(ref reciever, amount);
            return true;
        }

        public bool Deposit(ref Account account, decimal amount)
        {
            if (amount <= 0) return false;
            account.Balance += amount;
            return true;
        }

        public bool Withdraw(ref Account account, decimal amount)
        {
            if (amount <= 0 || amount > account.Balance) return false;

            if (account is InvestmentAccount
                && ((InvestmentAccount)account).InvestmentType == InvestmentType.Individual
                && amount > 500) return false;

            account.Balance -= amount;
            return true;
        }

        public CheckingAccount CreateCheckingAccount(string owner, decimal balance)
        {
            var result = new CheckingAccount(owner, balance);
            Accounts.Add(result);
            return result;
        }

        public InvestmentAccount CreateInvestmentAccount(string owner, decimal balance, InvestmentType investmentType)
        {
            var result = new InvestmentAccount(owner, balance, investmentType);
            Accounts.Add(result);
            return result;
        }
    }
}
