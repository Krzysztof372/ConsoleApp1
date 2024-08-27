
namespace ChallengeApp21
{
    public abstract class Person
    {
        public Person(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
            
        }

      
        public string Name { get; set; }

        public string Surname { get; set; } 

        


    }
}
