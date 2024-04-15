using ChallengeApp21;


public class Supervisor : IEmployee
{

    public string Name => throw new NotImplementedException();

    public string Surname => throw new NotImplementedException();



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
        throw new NotImplementedException();
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
                string tekst3; new string('d', -5);
                AddGrade(80);
                break;
            case "E":
                string tekst4; new string('e', 5);
                AddGrade(75);
                break;
            case "F":
                string tekst5; new string('f', +5);
                AddGrade(65);
                break;
            case "G":
                string tekst6; new string('g', -4);
                AddGrade(60);
                break;
            case "H":
                string tekst7; new string('h', 4);
                AddGrade(55);
                break;
            case "I":
                string tekst8; new string('i', +4);
                AddGrade(50);
                break;
            case "J":
                string tekst9; new string('j', +3);
                AddGrade(45);
                break;
            case "K":
                string tekst10; new string('k', 3);
                AddGrade(40);
                break;
            case "L":
                string tekst11; new string('l', -3);
                AddGrade(35);
                break;
            case "M":
                string tekst12; new string('m', -2);
                AddGrade(30);
                break;
            case "N":
                string ; new string('n', 2);
                AddGrade(25);
                break;
            case "P":
                string tekst14; new string('p', +2);
                AddGrade(20);
                break;
            case "R":
                string tekst15; new string('r', -1);
                AddGrade(15);
                break;
            case "S":
                string tekst16; new string('s', 1);
                AddGrade(10);
                break;
            case "T":
                string tekst17; new string('T', +1);
                AddGrade(5);
                break;

            default:

                throw new NotImplementedException("Wrong Letter");
                




        }

    }

}



