using ChallengeApp21;
using TestEmployee;


namespace TestEmployee
{
    
    public class Employeetest()
    {
        [TEST]
        public void TESTMin()
            
        {
            var employee = new Employee("Krzysztof", "Pietrzak");
            employee.AddGrade(1);
            employee.AddGrade(5);
            employee.AddGrade(-2);


            var statistics = employee.GetStatistics();

            Assert.AreEqual(30, statistics.Min);



        }
        [TEST]
        public void TESTAverage()

        {
            var employee = new Employee("Krzysztof", "Pietrzak");
            employee.AddGrade(7);
            employee.AddGrade(9);
            employee.AddGrade(20);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(30, statistics.Average);

        }

        [TEST]
        public void TESTMax()

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