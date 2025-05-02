using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEM
{
    public class Budget
    {
        public decimal RemainingBudget { get; private set; }

        public Budget(decimal startingAmount)
        {
            RemainingBudget = startingAmount;
        }

        public void DeductFromBudget(decimal amount)
        {
            RemainingBudget -= amount;
        }

        public void AddToBudget(decimal amount)
        {
            RemainingBudget += amount;
        }
    }
}
