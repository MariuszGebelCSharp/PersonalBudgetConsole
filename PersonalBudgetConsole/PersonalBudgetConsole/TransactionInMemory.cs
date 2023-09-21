using System.Diagnostics;

namespace PersonalBudgetConsole
{
    public class TransactionInMemory : TransactionBase
    {
        private List<float> amounts = new List<float>();
        public TransactionInMemory(string name, string surname) 
            : base(name, surname) 
        {
        }

        public override void AddIncome(float amount)
        {
            if (amount > 0 && amount <= 1000000)
            {
                this.amounts.Add(amount);
                Console.WriteLine($"Wpłacono: {amount:N2} zł");
            }
            else
            {
                if(amount > 1000000)
                {
                    throw new Exception($"{amount:N2} is too much. The highest amount is PLN 1,000,000");
                }
                else 
                { 
                    throw new Exception($"{amount:N2} is not correct value"); 
                }
            }
        }
        public override void AddExpense(float amount)
        {
            if (amount > -1000000 && amount < 0)
            {
                this.amounts.Add(amount);
                Console.WriteLine($"Wypłacono: {amount:N2} zł");
            }
            else
            {
                if (amount < -1000000)
                {
                    throw new Exception($"{amount:N2} is too much. The highest expense is PLN -1,000,000");
                }
                else
                {
                    throw new Exception($"{amount:N2} is not correct value");
                }
            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

            foreach (var amount in this.amounts)
            {
                statistics.AddTransaction(amount);
            }
            return statistics;
        }
    }
}
