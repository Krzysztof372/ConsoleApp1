using ChallengeApp21;

namespace TestProject8
{
    public class Tests
    {
        [SetUp]
        public void When_Two_Ratings_Are_Added()
        {
            var employee = new EmployeeInFile("Krzysztof", "Pietrzak");
            employee.AddGrade(0.5f);
            employee.AddGrade(15.5f);

            var result = employee.Result;

            Assert.AreEqual(result, 16f);

        }


    }
}