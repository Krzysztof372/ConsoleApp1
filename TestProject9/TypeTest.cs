


namespace TestProject9
{


    public class TypeTest

    {
        [Test]
        public void TEST()
        {

            //arrange

            var user1 = new User("Krzystof");
            var user2 = new User("Mariusz");




            //act




            //assert

            Assert.AreNotEqual(user1, user2);
        }
        private User GetUser(string name)


        {
            return new User(name);

        }


        [Test]
        public void TEST2()
        {

            //arrange

            int user1 = 1;
            int user2 = 2;




            //act




            //assert

            double result = 0;
            Assert.AreEqual(result, user1, user2);
        }


        [Test]
        public void TEST3()
        {

            //arrange

            float user1 = (0.5f);
            float user2 = (15.5f);


            //act


            Assert.AreEqual(user1, user2);
            ;
            //assert


             User GetUser(float user1)

            {
                return GetUser(user1);
            }


            User GetUser2(float user2)

            {
                return GetUser(user2);
            }

        }

    }

}
