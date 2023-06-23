

using Banking2.Domain;

namespace Banking2.UnitTests.TestDoubles;

public class DummyBonusCalculator : ICanCalculateBonuses
{
    public decimal CalculateBonusForDepositOn(decimal balance, decimal amountToDeposit)
    {
        return 0;
    }
}
