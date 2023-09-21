using PersonalBudgetConsole;

Console.WriteLine("Witaj w Programie PersonalBudget do prowadzenia rejestracji przychodów i wydatków!");
Console.WriteLine("==================================================================================");
Console.WriteLine();
Console.WriteLine("Podaj kwotę wpłaty lub wypłaty (z minusem) w zakresie od -1.000.000 do +1.000.000!");
Console.WriteLine("(q spowoduje wyświetlenie salda i innych statystyk)!");
var transaction = new TransactionInMemory("Jan", "Kowalski");

while (true)
{
    var input = Console.ReadLine();
    if(input == "q")
    {
        Console.WriteLine();
        Console.WriteLine("==================================================================================");
        break;
    }

    try
    {
        if (input.Contains("-"))
        {
            transaction.AddExpense(input);
        } 
        else
        {
            transaction.AddIncome(input);
        }
    }
    catch (Exception e) 
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
    Console.WriteLine("Podaj kolejną transakcję!");
}

var statistics = transaction.GetStatistics();
Console.WriteLine($"PODSUMOWANIE");
Console.WriteLine("==================================================================================");
Console.WriteLine($"Liczba transakcji: {statistics.Count}");
Console.WriteLine("----------------------------------------------------------------------------------");
Console.WriteLine($"Razem wpłaty: {statistics.TotalIncome:N2} zł");
Console.WriteLine($"Razem wydatki: {statistics.TotalExpenses:N2} zł");
Console.WriteLine($"Saldo: {statistics.Balance:N2} zł");
Console.WriteLine("----------------------------------------------------------------------------------"); ;
Console.WriteLine($"Najmniejsza wpłata: {statistics.MinIncome:N2} zł");
Console.WriteLine($"Największa wpłata: {statistics.MaxIncome:N2} zł");
Console.WriteLine($"Najmniejszy wydatek: {statistics.MaxExpense:N2} zł");
Console.WriteLine($"Największy wydatek: {statistics.MinExpense:N2} zł");
Console.WriteLine("----------------------------------------------------------------------------------");
