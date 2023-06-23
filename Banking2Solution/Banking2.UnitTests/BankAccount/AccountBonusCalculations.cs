using Banking2.Domain;
using Banking2.UnitTests.TestDoubles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking2.UnitTests.BankAccount;

public class AccountBonusCalculations
{
    [Fact]
    public void DepositUsesTheBonusCalculator()
    {
        var account = new Account(new StubbedBonusCalculator());
        var openingBalance = account.GetBalance();

        account.Deposit(112);

        Assert.Equal(openingBalance + 112M + 42M, account.GetBalance());
    }
}
