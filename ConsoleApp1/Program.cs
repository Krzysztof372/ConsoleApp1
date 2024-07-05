﻿using ChallengeApp21;


Console.WriteLine("Witamy w naszym programie do oceny pracowników i supervisor");
Console.WriteLine("=============================================");
Console.WriteLine("Aby zobaczyć wyniki wprowadź q");
Console.WriteLine();

var employee = new EmployeeInFile("Krzysztof", "Pietrzak");


employee.AddGrade(0.5f);
employee.AddGrade(15.5f);
employee.AddGrade(30.5f);
employee.AddGrade(10f);
employee.AddGrade(155f);




while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    try
    {

        var floatInput = float.Parse(input);
        employee.AddGrade(floatInput);
    }

    catch (Exception ex)

    {
        Console.WriteLine($"Exception catched: {ex.Message}");

    }

}

var statistics = employee.GetStatistics();

Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Grade letter: {statistics.AverageLetter}");



