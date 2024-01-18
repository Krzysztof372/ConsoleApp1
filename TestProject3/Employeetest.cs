


using ChallengeApp21;
using NUnit.Framework;




[Test]



 void MinTest()

{

    var employee = new Employee("Krzysztof Pietrzak");

    employee.AddGrade(5);
    employee.AddGrade(6);
    employee.AddGrade(8);

    var statistics = employee.GetStatistics();

    Assert.AreEqual(5, statistics.Min);








}


[Test]



 void MaxTest()

{

    var employee = new Employee("Krzysztof Pietrzak");

    employee.AddGrade(10);
    employee.AddGrade(6);
    employee.AddGrade(7);

    var statistics = employee.GetStatistics();

    Assert.AreEqual(10, statistics.Max);








}

[Test]



 void AverageTest()

{

    var employee = new Employee("Krzysztof Pietrzak");

    employee.AddGrade(5);
    employee.AddGrade(3);
    employee.AddGrade(10);

    var statistics = employee.GetStatistics();

    Assert.AreEqual(6, statistics.Average);








}