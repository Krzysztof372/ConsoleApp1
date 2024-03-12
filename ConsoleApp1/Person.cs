
namespace ChallengeApp21
{
    public abstract class Person
    {
        public Person(string name)
        {
            this.Name = name;
           

        }

      
        public string Name { get; set; }

        public char Gender { get; set; }


    }
}
