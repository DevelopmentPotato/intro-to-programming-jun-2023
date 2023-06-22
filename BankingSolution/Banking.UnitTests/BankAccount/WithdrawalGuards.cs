
using Banking.Domain;

namespace Banking.UnitTests.BankAccount;

public class WithdrawalGuards
{
    [Fact]
    public void OverdraftNotAllowed()
    {
        var account = new Account();



        Assert.Throws<OverdraftException>(() => account.Withdraw(account.GetBalance() + .01M));
    }

}
