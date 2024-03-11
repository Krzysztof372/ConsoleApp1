
namespace ChallengeApp21
{
    public abstract class Person
    {
        public Person(string name)
        {
            this.name = name;
           

        }

      
        public string name { get; set; }

        public char Gender { get; set; }


    }
}
