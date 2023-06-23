namespace Banking2.Domain;

public interface ICanCalculateBonuses
{
    decimal CalculateBonusForDepositOn(decimal balance, decimal amountToDeposit);
}