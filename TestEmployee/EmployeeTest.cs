using System.Net.NetworkInformation;

namespace TestEmployee
{
    
    
        [TestMethod]
        public void MaxRating()
        {
            var employee = new employee("Krzysztof", "Pietrzak", 23);


            Employee.AddGrade(5);
            Employee.AddGrade(7);
            Employee.AddGrade(8);


            var Statistics = GetStatistics();

            Assert.AreEqual(Statistics);
            


          

        }

        
    }