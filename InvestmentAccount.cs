using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankExample
{
    public class InvestmentAccount : Account
    {
        public AccountType AccountType { get; } = AccountType.Investment;
        public InvestmentType InvestmentType { get; }
        public InvestmentAccount(string owner, decimal balance, InvestmentType investmentType) : base(owner, balance)
        {
            InvestmentType = investmentType;
        }
    }
}
