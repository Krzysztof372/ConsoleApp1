
class Employee
{
    public string FullName { get; set; }
    public int Age { get; set; }
    private List<int> ratings;

    public Employee(string fullName, int age)
    {
        FullName = fullName;
        Age = age;
        ratings = new List<int>();
    }

    public void AddRating(int rating)
    {
        ratings.Add(rating);
    }

    public int GetAverageRating()
    {
        int sum = 0;
        foreach (int rating in ratings)
        {
            sum += rating;
        }
        return sum / ratings.Count;


    }
}
    
