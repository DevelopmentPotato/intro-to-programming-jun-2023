using Banking2.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking2.UnitTests.BonusCalculations;

public class CalculatingStandardBonuses
{
    [Theory]
    [InlineData(100, 10)]
    [InlineData(200, 20)]
    public void AccountsThatHaveBalanceThresholdGetBonus(decimal amountToDeposit, decimal expectedBonus)
    {
        var bonusCalculator = new StandardBonusCalculator();

        decimal bonus = bonusCalculator.CalculateBonusForDepositOn(5000.01M, amountToDeposit);

        Assert.Equal(expectedBonus, bonus);
    }

    [Theory]
    [InlineData(100, 0)]
    [InlineData(200, 0)]
    public void AccountsThatHaveBalanceBelowThresholdGetNoBonus(decimal amountToDeposit, decimal expectedBonus)
    {
        var bonusCalculator = new StandardBonusCalculator();

        decimal bonus = bonusCalculator.CalculateBonusForDepositOn(5000.00M, amountToDeposit);

        Assert.Equal(expectedBonus, bonus);
    }
}