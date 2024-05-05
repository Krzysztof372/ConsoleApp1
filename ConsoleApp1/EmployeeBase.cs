
using ChallengeApp21;
namespace ChallengeApp21
{
    public abstract class EmployeeBase : IEmployee
    {
        public string Name { get;  set; }

        public string Surname { get; private set; }

        public EmployeeBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;


        }

        public abstract void AddGrade(float grade);


        public abstract void AddGrade(double grade);



        public abstract void AddGrade(long grade);


        public abstract void AddGrade(char grade);

        public abstract void AddGrade(string grade);

        public abstract Statistics GetStatistics();

        public Statistics ReadGradesFromFile()
        {
            throw new NotImplementedException();
        }
    }
}
