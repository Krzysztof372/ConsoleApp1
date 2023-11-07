using ChallengeApp21;

User user1 = new User("Kuba", "Błaszczykowski", 35);
User user2 = new User("Łukasz", "Piszczek", 38);
User user3 = new User("Robert", "Lewandowski", 37);

user1.AddScore(5);
user1.AddScore(7);
user1.AddScore(9);
user1.AddScore(11);
user1.AddScore(13);

user2.AddScore(2);
user2.AddScore(5);
user2.AddScore(9);
user2.AddScore(2);
user2.AddScore(1);

user3.AddScore(2);
user3.AddScore(4);
user3.AddScore(6);
user3.AddScore(8);
user3.AddScore(10);

List<User> users = new List<User>()
{
    user1, user2, user3
};

int maxResult = -1;
User userWithMaxResult = null;

foreach (var user in users)
{
    if (user.Result > maxResult)
    {
        userWithMaxResult = user;
        maxResult = user.Result;
    }
}

Console.WriteLine($" Najlepszym piłkarzem/pracownikiem został: {userWithMaxResult.Name} {userWithMaxResult.Surname} lat {userWithMaxResult.Age} i zdobył: {userWithMaxResult.Result} punktów");
