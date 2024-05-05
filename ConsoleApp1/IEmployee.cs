
namespace ChallengeApp21
{
    public interface IEmployee
    {

        string Name  { get; }

        string Surname { get; }
        public Statistics GetStatistics();

        public void AddGrade(float grade);

        public void AddGrade(double grade);

        public void AddGrade(long grade);

        public void AddGrade(char grade);

        void AddGrade(string grade);
        Statistics ReadGradesFromFile();
    }
}
