namespace PersonalBudgetConsole
{
    public class TransactionInFile :TransactionBase
    {
        public override event TransactionAddedDelegate TransactionAdded;
        private const string fileName = "transactions.txt";

        public TransactionInFile(string name, string surname) 
            : base(name, surname) 
        {
        }

        public override void AddIncome(float amount)
        {
            if (amount > 0 && amount <= 1000000)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(amount);
                }
                if (TransactionAdded != null)
                {
                    TransactionAdded(this, new EventArgs());
                }
            }
            else
            {
                if (amount > 1000000)
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
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(amount);
                }
                if (TransactionAdded != null)
                {
                    TransactionAdded(this, new EventArgs());
                }
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

            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var amount = float.Parse(line);
                        statistics.AddTransaction(amount);
                        line = reader.ReadLine();
                    }
                }
            }
            return statistics;
        }
    }
}
