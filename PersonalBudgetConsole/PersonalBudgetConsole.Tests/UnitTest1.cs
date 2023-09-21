namespace PersonalBudgetConsole.Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
          // arrange
          int age1 = 10;
          int age2 = 20;

          // act
          int result = age1 + age2;

          // assert
          Assert.AreEqual(30, result);
        }
    }
}