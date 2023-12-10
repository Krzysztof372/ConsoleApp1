using ChallengeApp21;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;


namespace TestEmployee
{

    public class EmployeeTest
    {
        [Test]
        public void TestMin()

        {
            var employee = new Employee("Krzysztof", "Pietrzak");
            employee.AddGrade(1);
            employee.AddGrade(5);
            employee.AddGrade(-2);


            var statistics = employee.GetStatistics();

            Assert.AreEqual(30, statistics.Min);



        }
        [Test]
        public void TestAverage()

        {
            var employee = new Employee("Krzysztof", "Pietrzak");
            employee.AddGrade(7);
            employee.AddGrade(9);
            employee.AddGrade(20);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(30, statistics.Average);

        }

        [Test]
        public void TestMax()

        {
            var employee = new Employee("Krzysztof", "Pietrzak");
            employee.AddGrade(7);
            employee.AddGrade(9);
            employee.AddGrade(20);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(30, statistics.Max);

        }










    }


}