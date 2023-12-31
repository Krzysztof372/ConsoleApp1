



using ChallengeApp21;

namespace ChallengeApp21
{ }
public class Employee

{

    private List<float> grades = new List<float>();

    public Employee(string name)
    {
        this.Name = name;

    }

    public Employee(string name, string surname)
    {
        this.Name = name;
        this.Surname = surname;
    }

    public string Name { get; private set; }

    public string Surname { get; private set; }


    public void AddGrade(float grade)

    {
        if (grade >= 0 && grade <= 100)


        {

            this.grades.Add(grade);

        }

        else

        {

            Console.WriteLine("Invalid code value");
        }


    }
    public void AddGrade( string grade)

    {

        if

            (float.TryParse(grade, out float result))

        {

            this.AddGrade(result);
        }

        else

        {
            Console.WriteLine("String is not float");

        }
    }

    public void AddGrade(int grade)
    {
        if (grade < 0 && grade > 100)

        {

            this.grades.Add(grade);


        }
        else

        {


            Console.WriteLine("Int under the 100");



        }
    }

    public void AddGrade(double grade, int v)

    {

        double doubleValue;


        if (double.TryParse(float.MinValue.ToString(), out doubleValue))
        {

            Console.WriteLine("Wartość doubleValue wynosi: " + doubleValue);
        }
        else
        {
           
            Console.WriteLine("Nie udało się sparsować wartości float.");
        }



    }

    public Statistics GetStatistics()
    {
        var statistics = new Statistics();
        statistics.Min = float.MaxValue;
        statistics.Max = float.MinValue;
        statistics.Average = 0;


        foreach (var grade in this.grades)
        {
            statistics.Max = Math.Max(statistics.Max, grade);
            statistics.Average += grade;
            statistics.Min = Math.Min(statistics.Min, grade);
        }


        statistics.Average /= this.grades.Count;

        return statistics;
    }

}






