using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking2.Domain;

public class StandardBonusCalculator : ICanCalculateBonuses
{

    public decimal CalculateBonusForDepositOn(decimal balance, decimal amountOfDeposit)
    {
        if (balance > 500M)
        {
            return amountOfDeposit * .10M;

        }
        else
        {
            return 0;
        }
    }
}