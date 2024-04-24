using ChallengeApp21;



 public class Supervisor : IEmployee
{

    public string Name { get; set; }

    public string Surname { get; set; }



    private List<float> grades = new List<float>();
  


    public void AddGrade(float grade)
    {
        if (grade >= 0 && grade <= 100)
        {
            this.AddGrade(grade);
        }
        else
        {
            throw new Exception("invalid grade value");
        }
    }

    public void AddGrade(double grade)
    {
        var doubleAsFloat = (float)grade;
        AddGrade(doubleAsFloat);
    }

    public void AddGrade(long grade)
    {
        var longAsFloat = (float)grade;
        AddGrade(longAsFloat);
    }

    public void AddGrade(char grade)
    {
        {
            {
                switch (grade)

                {
                    case 'A':
                    case 'a':
                        AddGrade(100);
                        break;
                    case 'B':
                    case 'b':
                        AddGrade(80);
                        break;
                    case 'C':
                    case 'c':
                        AddGrade(60);
                        break;
                    case 'D':
                    case 'd':
                        AddGrade(40);
                        break;
                    case 'E':
                    case 'e':
                        AddGrade(20);
                        break;
                    default:

                        throw new NotImplementedException("Wrong Number");

                }
            }
        }
    }

   

    public Statistics GetStatistics()
    {
        var statistics = new Statistics();
        statistics.Average = 0;
        statistics.Max = float.MinValue;
        statistics.Min = float.MaxValue;

        foreach (var grade in this.grades)
        {
            if (grade >= 0)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
        }
        statistics.Average /= this.grades.Count;

        switch (statistics.Average)
        {
            case var average when average >= 80:
                statistics.AverageLetter = 'A';
                break;
            case var average when average >= 60:
                statistics.AverageLetter = 'B';
                break;
            case var average when average >= 40:
                statistics.AverageLetter = 'C';
                break;
            case var average when average >= 20:
                statistics.AverageLetter = 'D';
                break;
            default:
                statistics.AverageLetter = 'E';
                break;
        }
        return statistics;
    }

    void IEmployee.AddGrade(string grade)
    {


        switch (grade)

        {
            case "A":
                (char item1, int item2) = ('a', 6);
                AddGrade(95);
                break;
            case "B":
                (char, int) value = ('b', -6);
                AddGrade(90);
                break;
            case "C":
                (char, int) value1 = ('c', +6);
                AddGrade(85);
                break;
            case "D":
                (char, int) value3 = ('d', -5);
                AddGrade(80);
                break;
            case "E":
                (char, int) value2 = ('e', 5);
                AddGrade(75);
                break;
            case "F":
                (char, int) value4 = ('f', +5);
                AddGrade(65);
                break;
            case "G":
                (char, int) value5 = ('g', -4);
                AddGrade(60);
                break;
            case "H":
                (char, int) value6 = ('h', 4);
                AddGrade(55);
                break;
            case "I":
                (char, int) value7 = ('i', +4);
                AddGrade(50);
                break;
            case "J":
                (char, int) value8 = ('j', +3);
                AddGrade(45);
                break;
            case "K":
                (char, int) value9 = ('k', 3);
                AddGrade(40);
                break;
            case "L":
                (char, int) value10 = ('l', -3);
                AddGrade(35);
                break;
            case "M":
                (char, int) value11 = ('m', -2);
                AddGrade(30);
                break;
            case "N":
                (char, int) value12 = ('n', 2);
                AddGrade(25);
                break;
            case "P":
                (char, int) value13 = ('p', +2);
                AddGrade(20);
                break;
            case "R":
                (char, int) value14= ('r', -1);
                AddGrade(15);
                break;
            case "S":
                (char, int) value15 = ('s', 1);
                AddGrade(10);
                break;
            case "T":
                (char, int) value16 = ('T', +1);
                AddGrade(5);
                break;

            default:

                throw new NotImplementedException("Wrong Letter");
        }
    }
}



