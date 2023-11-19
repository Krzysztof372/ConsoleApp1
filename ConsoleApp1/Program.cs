using ChallengeApp21;

var Employee = new Employee("Krzysztof", "Pietrzak");
Employee.AddGrade(2);
Employee.AddGrade(2);
Employee.AddGrade(6);
var statistics = Employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");