





User user1 = new("Krzysztof");








class User



{
    
    private string login;
    private string password;
    private string name;
    private int score;

    public object? Result { get;  set; }


    public User(string login)



    {


        this.login = login;

    }

    public User()
    {
    }

    internal void AddScore()
    {
        score = 0;
        
    }

    public void AddScore(int score) 
    {
        AddScore();

    }
}


