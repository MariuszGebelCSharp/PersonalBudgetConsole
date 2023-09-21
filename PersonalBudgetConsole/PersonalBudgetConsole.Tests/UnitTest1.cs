namespace PersonalBudgetConsole.Tests
{
    public class Tests
    {
        [Test]
        public void CheckIfTotalIncomeIsCorrect()
        {

            // arrange
            var transaction = new TransactionInMemory("Jan", "Nowak");
            transaction.AddIncome(20.18);
            transaction.AddIncome(40.2);
            transaction.AddIncome(2);

          // act
            var statistics = transaction.GetStatistics();

          // assert
          Assert.AreEqual(Math.Round(62.38, 2), Math.Round(statistics.TotalIncome, 2));
        }

        [Test]
        public void CheckIfTotalExpensesIsCorrect()
        {

            // arrange
            var transaction = new TransactionInMemory("Jan", "Nowak");
            transaction.AddExpense(-20.18);
            transaction.AddExpense(-40.2);
            transaction.AddExpense(-2);

            // act
            var statistics = transaction.GetStatistics();

            // assert
            Assert.AreEqual(Math.Round(-62.38, 2), Math.Round(statistics.TotalExpenses, 2));
        }

        [Test]
        public void CheckIfMinIncomeIsCorrect()
        {

            // arrange
            var transaction = new TransactionInMemory("Jan", "Nowak");
            transaction.AddIncome(20.18);
            transaction.AddIncome(40.2);
            transaction.AddIncome(2);

            // act
            var statistics = transaction.GetStatistics();

            // assert
            Assert.AreEqual(Math.Round(2.0, 2), Math.Round(statistics.MinIncome, 2));
        }

        [Test]
        public void CheckIfMaxIncomeIsCorrect()
        {

            // arrange
            var transaction = new TransactionInMemory("Jan", "Nowak");
            transaction.AddIncome(20.18);
            transaction.AddIncome(40.2);
            transaction.AddIncome(2);

            // act
            var statistics = transaction.GetStatistics();

            // assert
            Assert.AreEqual(Math.Round(40.2, 2), Math.Round(statistics.MaxIncome, 2));
        }

        [Test]
        public void CheckIfMaxExpenseIsCorrect()
        {

            // arrange
            var transaction = new TransactionInMemory("Jan", "Nowak");
            transaction.AddExpense(-20.18);
            transaction.AddExpense(-40.2);
            transaction.AddExpense(-2.8);

            // act
            var statistics = transaction.GetStatistics();

            // assert
            Assert.AreEqual(Math.Round(-40.2, 2), Math.Round(statistics.MinExpense, 2));
        }

        [Test]
        public void CheckIfMinExpenseIsCorrect()
        {

            // arrange
            var transaction = new TransactionInMemory("Jan", "Nowak");
            transaction.AddExpense(-20.18);
            transaction.AddExpense(-40.2);
            transaction.AddExpense(-2.8);

            // act
            var statistics = transaction.GetStatistics();

            // assert
            Assert.AreEqual(Math.Round(-2.8, 2), Math.Round(statistics.MaxExpense, 2));
        }

        [Test]
        public void CheckIfPlusBalanceIsCorrect()
        {

            // arrange
            var transaction = new TransactionInMemory("Jan", "Nowak");
            transaction.AddExpense(-20.18);
            transaction.AddExpense(-40.2);
            transaction.AddExpense(-2.8);
            transaction.AddIncome(60.18);
            transaction.AddIncome(80.2);
            transaction.AddIncome(2);

            // act
            var statistics = transaction.GetStatistics();

            // assert
            Assert.AreEqual(Math.Round(79.2, 2), Math.Round(statistics.Balance, 2));
        }

        [Test]
        public void CheckIfMinusBalanceIsCorrect()
        {

            // arrange
            var transaction = new TransactionInMemory("Jan", "Nowak");
            transaction.AddExpense(-60.18);
            transaction.AddExpense(-80.2);
            transaction.AddExpense(-2.8);
            transaction.AddIncome(20.18);
            transaction.AddIncome(40.2);
            transaction.AddIncome(2);

            // act
            var statistics = transaction.GetStatistics();

            // assert
            Assert.AreEqual(Math.Round(-80.8, 2), Math.Round(statistics.Balance, 2));
        }          
    }
}