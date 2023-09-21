namespace PersonalBudgetConsole
{
    public interface ITransaction
    {
        string Name { get; }
        string Surname { get; }
        void AddIncome(float amount);
        void AddExpense(float amount);
        void AddIncome(string amount);
        void AddExpense(string amount);

        Statistics GetStatistics();
    }
}
