using Banking2.Domain;
using Banking2.UnitTests.TestDoubles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking2.UnitTests.BankAccount;

public class MakingWithdrawals
{
    [Theory]
    [InlineData(100)]
    [InlineData(125.23)]

    public void MakingAWithdrawlDecreasesTheBalance(decimal amountToWithdraw)
    {
        var account = new Account(new DummyBonusCalculator());
        var openingBalance = account.GetBalance();


        account.Withdraw(amountToWithdraw);

        Assert.Equal(openingBalance - amountToWithdraw, account.GetBalance());
    }

    [Fact]
    public void CanTakeFullBalance()
    {
        var account = new Account(new DummyBonusCalculator());
        var openingBalance = account.GetBalance();

        account.Withdraw(openingBalance);

        Assert.Equal(0, account.GetBalance());
    }
}