using static PersonalBudgetConsole.TransactionBase;

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

        event TransactionAddedDelegate TransactionAdded;

        Statistics GetStatistics();
    }
}
