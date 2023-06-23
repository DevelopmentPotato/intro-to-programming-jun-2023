using Banking2.Domain;
using Banking2.UnitTests.TestDoubles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking2.UnitTests.BankAccount;

public class WithdrawalGuards
{
    [Fact]
    public void OverdraftNotAllowed()
    {
        var account = new Account(new DummyBonusCalculator());
        var openingBalance = account.GetBalance();

        try
        {
            account.Withdraw(openingBalance + .01M);
        }
        catch (OverdraftException)
        {

            // ignore any exceptions
        }

        Assert.Equal(openingBalance, account.GetBalance());
    }

    [Fact]
    public void OverdraftThrowsException()
    {
        var account = new Account(new DummyBonusCalculator());
        var openingBalance = account.GetBalance();

        Assert.Throws<OverdraftException>(
            () => account.Withdraw(openingBalance + .01M));


    }


}