

namespace TypeTest;

public class TypeTests
{
    [SetUp]
    public void TEST()
    {

        var user1 = GetUser("Krzysztof");
        var user2 = GetUser("Krzysztof");



        Assert.AreEqual(user1, user2); 
    }


   

    private User GetUser(string name)
        
    {
        return new User(name);

    }

}