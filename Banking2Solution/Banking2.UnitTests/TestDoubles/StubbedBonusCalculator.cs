using Banking2.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking2.UnitTests.TestDoubles;

public class StubbedBonusCalculator : ICanCalculateBonuses
{
    public decimal CalculateBonusForDepositOn(decimal balance, decimal amountToDeposit)
    {
        return (balance <= 500M && amountToDeposit == 112M) ? 42 : 0;
    }
}
