﻿﻿using ChallengeApp21;

Console.WriteLine("Witamy w naszym programie do oceny pracowników");
Console.WriteLine("=============================================");
Console.WriteLine("Aby zobaczyć wyniki wprowadź q");
Console.WriteLine();

var employee = new Employee();

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    employee.AddGrade(input);
}

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Grade letter: {statistics.AverageLetter}");