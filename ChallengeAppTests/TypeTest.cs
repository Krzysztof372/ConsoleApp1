
using ChallengeApp21;
using System.Runtime.CompilerServices;

namespace ChallengeApp.Tests
{
    public class TypeTest
    {
        public TypeTest()
        {
        }

        [Test]
        public void WhenTwoNumbersGivecorrectresult()

        {

            // arrange

            int number1 = 1;
            int number2 = 2;

            // act

            // assert

            Assert.AreNotEqual(number1, number2);



        }












        [Test]
        public void GetUserShouldReturnDifferentobject()

        {

            // arrange

            var user1 = GetUser("Adam");
            var user2 = GetUser("Adam");

            // act

            // assert

            Assert.AreNotEqual(user1, user2);


        }
        private User GetUser(string name)

        {

            return new User(name);

        }



        
    }



    





}







