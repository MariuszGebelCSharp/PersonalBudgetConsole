namespace PersonalBudgetConsole
{
    public abstract class TransactionBase
    {
        public delegate void TransactionAddedDelegate(object sender, EventArgs args);
        public abstract event TransactionAddedDelegate TransactionAdded;

        public TransactionBase(string name, string surname) 
        {
            this.Name = name;
            this.Surname = surname;
        }    

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public abstract void AddIncome(float amount);

        public void AddIncome(double amount)
        {
            float amountAsFloat = (float)amount;
            this.AddIncome(amountAsFloat);
        }

        public void AddIncome(int amount)
        {
            float amountAsInt = (int)amount;
            this.AddIncome(amountAsInt);
        }

        public abstract void AddExpense(float amount);

        public void AddExpense(double amount)
        {
            float amountAsFloat = (float)amount;
            this.AddExpense(amountAsFloat);
        }

        public void AddExpense(int amount)
        {
            float amountAsInt = (int)amount;
            this.AddExpense(amountAsInt);
        }

        public void AddIncome(string amount)
        {
            if (float.TryParse(amount, out float result))
            {
                this.AddIncome(result);
            }
            else
            {
                throw new Exception("This is not a number!");
            }
        }

        public void AddExpense(string amount)
        {
            if (float.TryParse(amount, out float result))
            {
                this.AddExpense(result);
            }
            else
            {
                throw new Exception("This is not a number!");
            }
        }

        public abstract Statistics GetStatistics();
    }
}
