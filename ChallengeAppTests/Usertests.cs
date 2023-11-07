

namespace ChallengeApp21;

public class Tests
{
    [Test]
    public void WhenThreeNumbersGiveGoodResult()
    {
        





        var Employee = new User("Mikołaj", "Kopernik", 90);
        Employee.AddScore(6);
        Employee.AddScore(5);
        Employee.AddScore(-2);

        var result = Employee.Result;

        Assert.AreEqual(9, result);





    }

}