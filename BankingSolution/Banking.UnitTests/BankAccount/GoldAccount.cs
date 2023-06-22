namespace Banking.UnitTests.BankAccount;

public class GoldAccount : Account
{
    public GoldAccount()
    {
    }

    public override void Deposit(decimal amoutToDeposit)
    {
        base.Deposit(amoutToDeposit * 1.1M);
    }
}