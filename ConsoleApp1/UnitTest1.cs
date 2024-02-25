

using ChallengeApp;
namespace ChallengeApp21;
public class Tests
 {


    [Test]
    public void When_AllratingsHaveAdividedAverage()
    {
        var employee = new Employee();

        employee.AddGrade(40);
        employee.AddGrade(60);
        employee.AddGrade(100);

        var statistics = employee.GetStatistics();

        Assert.AreEqual(66.6666641f, statistics.Average);
        Assert.AreEqual(100, statistics.Max);
        Assert.AreEqual(40, statistics.Min);
        Assert.AreEqual('B', statistics.AverageLetter);


    }


    

}



public class Tests2
{


    [Test]
    public void When_allswitchesgotaverage()
    {
        var employee = new Employee();

        employee.AddGrade("C");
        employee.AddGrade("B");
        employee.AddGrade("A");


        var statistics = employee.GetStatistics();

        Assert.AreEqual(80, statistics.Average);
        Assert.AreEqual(100, statistics.Max);
        Assert.AreEqual(60, statistics.Min);
        Assert.AreEqual('A', statistics.AverageLetter);


    }




}