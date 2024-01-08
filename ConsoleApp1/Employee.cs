



using ChallengeApp21;

namespace ChallengeApp21
{ }
public class Employee
{
    private List<float> grades = new List<float>();

   
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



    public void AddGrade(string grade)

    {

        double doubleValue;


        if (double.TryParse(float.MinValue.ToString(), out doubleValue))
        {

            Console.WriteLine("Wartość doubleValue wynosi: " + doubleValue);
        }
        else
        {

            Console.WriteLine($"({grade})jest ");
        }





    }

    public Statistics GetStatisticsForeach()
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

    public Statistics GetStatisticsFor()
    {
        var statistics = new Statistics();
        statistics.Min = float.MaxValue;
        statistics.Max = float.MinValue;
        statistics.Average = 0;
        var index = 0;
        index = grades.Count;
        index++;


        for (index = 0; index < grades.Count; index++)
        {
            statistics.Max = Math.Max(statistics.Max, this.grades[index]);
            statistics.Average += this.grades[index];
            statistics.Min = Math.Min(statistics.Min, this.grades[index]);
            index++;

        }

        statistics.Average /= this.grades.Count;



        return statistics;
    }

    public Statistics GetStatisticsdoWhile()
    {
        var statistics = new Statistics();
        statistics.Min = float.MaxValue;
        statistics.Max = float.MinValue;
        statistics.Average = 0;
        var index = 0;
        do
        {
            statistics.Max = Math.Max(statistics.Max, this.grades[index]);
            statistics.Average += this.grades[index];
            statistics.Min = Math.Min(statistics.Min, this.grades[index]);
            index++;
        }

        while (index < this.grades.Count);


        statistics.Average /= this.grades.Count;

        return statistics;
    }

    public Statistics GetStatisticsWhile()
    {
        var statistics = new Statistics();
        statistics.Min = float.MaxValue;
        statistics.Max = float.MinValue;
        statistics.Average = 0;
        var index = 0;

      
        {
            statistics.Max = Math.Max(statistics.Max, this.grades[index]);
            statistics.Average += this.grades[index];
            statistics.Min = Math.Min(statistics.Min, this.grades[index]);
            index++;
        }




        statistics.Average /= this.grades.Count;

        return statistics;
    }

}





