




namespace TestProject9;



    public class Tests
    {


    [Test]
    public void WhenUserCollectTwoScores_ShouldCorrectResult()
        {

        //arrange

        var user = new User();
        user.AddScore(5);
        user.AddScore(5);



        //act

            
        var result = user.Result;



        //assert

        Assert.AreEqual(10, result);

           
        }
    }

