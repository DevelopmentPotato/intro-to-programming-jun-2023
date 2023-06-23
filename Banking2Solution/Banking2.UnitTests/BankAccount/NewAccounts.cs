using Banking2.Domain;
using Banking2.UnitTests.TestDoubles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking2.UnitTests.BankAccount;

public class NewAccounts
{
    [Fact]
    public void NewAccountsHaveCorrectBalance()
    {
        // Given
        Account account = new Account(new DummyBonusCalculator());

        // When
        decimal balance = account.GetBalance();

        // Then
        Assert.Equal(5000, balance);
    }
}