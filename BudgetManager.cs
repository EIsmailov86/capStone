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
            RemainingBudget -= amount;
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
