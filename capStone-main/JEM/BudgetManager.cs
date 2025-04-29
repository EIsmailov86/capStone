using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEM
{
    public class BudgetManager
    {
        public decimal TotalBudget { get; set; }
        public decimal RemainingBudget { get; set; }

        public BudgetManager(decimal totalBudget)
        {
            TotalBudget = totalBudget;
            RemainingBudget = totalBudget;
        }

        public void DeductFromBudget(decimal amount)
        {
            if (RemainingBudget - amount >= 0)
            {
                RemainingBudget -= amount;
            }
            else
            {
                RemainingBudget = 0;
            }
        }

        public void AddToBudget(decimal amount)
        {
            RemainingBudget += amount;
        }

        public int CalculateProgress()
        {
            if (TotalBudget == 0)
                return 0;

            return (int)((RemainingBudget / TotalBudget) * 100);
        }
    }
}
