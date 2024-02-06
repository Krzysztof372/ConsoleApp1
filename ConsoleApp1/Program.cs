using ChallengeApp21;


Console.WriteLine("Witamy w Programie XYZ Pracowników");
Console.WriteLine("===================================");
Console.WriteLine("Oceny Od 0 Do 100"); 

var employee = new Employee();

while (true)

{
    Console.WriteLine("Podaj ocenę pracownika");
    var input = Console.ReadLine();
    if (input == "q") 

    {
        break;
    }

    employee.AddGrade(input);
}




var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");



