using Banking2.Domain;
using Banking2.UnitTests.TestDoubles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking2.UnitTests.BankAccount;

public class MakingDeposits
{
    [Fact]
    public void DepositIncreasesBalance()
    {
        // Given 
        // If I have an account and I want to deposit 100
        Account account = new Account(new DummyBonusCalculator());
        decimal openingBalance = account.GetBalance(); // Query
        decimal amountToDeposit = 100M;

        // When - I do the deposit
        account.Deposit(amountToDeposit); // "Command"

        // Then - I can verify it worked if the new balance is 100 more than the balance
        //        was before.
        Assert.Equal(openingBalance + amountToDeposit, account.GetBalance());

    }
}