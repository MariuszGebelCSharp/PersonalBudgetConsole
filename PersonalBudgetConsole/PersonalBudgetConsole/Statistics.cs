namespace PersonalBudgetConsole
{
    public class Statistics
    {
        public float MinIncome {  get; private set; }
        public float MaxIncome { get; private set; }
        public float MinExpense { get; private set; }
        public float MaxExpense { get; private set; }
        public float TotalIncome { get; private set; }
        public float TotalExpenses { get; private set; }
        public float Balance 
        { 
            get
            {
                return this.TotalIncome + this.TotalExpenses;
            }
        }
        public int Count { get; private set; }
        public float TransactionAverage
        {
            get
            {
                return (this.TotalIncome + this.TotalExpenses) / this.Count;
            }
        }

        public Statistics() {
            this.Count = 0;
            this.TotalIncome = 0;
            this.TotalExpenses = 0;
            this.MinIncome = float.MaxValue;
            this.MinExpense = float.MaxValue;
            this.MaxIncome = float.MinValue;
            this.MaxExpense = float.MinValue;
        }
        public void AddTransaction(float amount)
        { 
            this.Count++;
            if (amount > 0)
            {
                this.TotalIncome += amount;
                this.MinIncome = Math.Min(this.MinIncome, amount);
                this.MaxIncome = Math.Max(this.MaxIncome, amount);
            }
            else
            {
                this.TotalExpenses += amount;
                this.MinExpense = Math.Min(this.MinExpense, amount);
                this.MaxExpense = Math.Max(this.MaxExpense, amount);
            }

        }

    }
}
