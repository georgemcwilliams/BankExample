using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BankExample
{
    [TestClass]
    public class BankTest
    {
        [TestMethod]
        public void CheckingAccountCanDepositAndWithdrawl()
        {
            Bank bank = new Bank("TestBank");
            Account account = bank.CreateCheckingAccount("Fred", 1000);
            Assert.IsTrue(bank.Withdraw(ref account, 100));
            Assert.IsTrue(bank.Withdraw(ref account, 501));
            Assert.IsTrue(bank.Deposit(ref account, 100));
            Assert.IsTrue(account.Balance == 499);
        }

        [TestMethod]
        public void IndividualInvestmentAccountCanDepositAndWithdrawl()
        {
            Bank bank = new Bank("TestBank");
            Account account = bank.CreateInvestmentAccount("Fred", 1000, InvestmentType.Individual);
            Assert.IsTrue(bank.Withdraw(ref account, 100));
            Assert.IsFalse(bank.Withdraw(ref account, 501));
            Assert.IsTrue(bank.Deposit(ref account, 100));
            Assert.IsTrue(account.Balance == 1000);
        }

        [TestMethod]
        public void CorporateInvestmentAccountCanDepositAndWithdrawl()
        {
            Bank bank = new Bank("TestBank");
            Account account = bank.CreateInvestmentAccount("Fred", 1000, InvestmentType.Corporate);
            Assert.IsTrue(bank.Withdraw(ref account, 100));
            Assert.IsTrue(bank.Withdraw(ref account, 501));
            Assert.IsTrue(bank.Deposit(ref account, 100));
            Assert.IsTrue(account.Balance == 499);            
        }

        [TestMethod]
        public void AccountsCanTransfer()
        {
            Bank bank = new Bank("TestBank");
            Account sender = bank.CreateInvestmentAccount("Fred", 1000, InvestmentType.Corporate);
            Account receiver = bank.CreateCheckingAccount("Jane", 1000);
            
            Assert.IsTrue(bank.Transfer(ref sender, ref receiver,  100));
            Assert.IsTrue(sender.Balance == 900);
            Assert.IsTrue(receiver.Balance == 1100);

            Assert.IsFalse(bank.Transfer(ref sender, ref receiver, 100000));
            Assert.IsTrue(sender.Balance == 900);
            Assert.IsTrue(receiver.Balance == 1100);

        }
    }
}
