

namespace Banking.UnitTests.BankAccount;

public class MakingWithdrawals
{
    [Theory]
    [InlineData(100)]
    [InlineData(300)]
    public void MakingWithdrawlDecreasesTheBalance(decimal amountToWithdraw)
    {

        Account account = new Account();
        decimal openingBalance = account.GetBalance();

        account.Withdraw(amountToWithdraw);

        Assert.Equal(openingBalance - amountToWithdraw, account.GetBalance());
    }
}
