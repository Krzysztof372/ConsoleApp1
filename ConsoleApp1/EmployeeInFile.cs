using ChallengeApp21;


namespace ChallengeApp21
{
    public class EmployeeInFile : EmployeeBase
    {

        private List<float> grades = new List<float>();
        public EmployeeInFile(string name, string surname) :

            base(name, surname)
        {

        }



        private const string filename = "grades.txt";
       

        public string fileName { get; private set; }

        public override void AddGrade(float grade)
        {
            using (var writer = File.AppendText(filename))

            {
                writer.WriteLine(grade);
            }

        }

        public override void AddGrade(double grade)
        {
            var doubleAsFloat = (float)grade;
            AddGrade(doubleAsFloat);
        }

        public override void AddGrade(long grade)
        {
            var longAsFloat = (float)grade;
            AddGrade(longAsFloat);
        }

        public override void AddGrade(char grade)
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

                    throw new Exception("Wrong Letter");

            }
        }
            

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if (char.TryParse(grade, out char resultChar))
            {
                this.AddGrade(resultChar);
            }
            else
            {
                throw new Exception("float is not a value");
            }
        }

        public override Statistics GetStatistics()

        {
            var Gradesfromfile = ReadGradesfromfile();
            var result = this.CountStatistics(Gradesfromfile);


            return result;
        }

        private  List<float> ReadGradesfromfile()
        {
            var grades = new List<float>();
            if (File.Exists(filename))
            {

                using (var reader = File.OpenText(filename))
                {

                    var line = reader.ReadLine();
                    while (line != null)

                    {

                        var number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                    }
                }


                
            }

            return ReadGradesfromfile();
        }
       


        private Statistics CountStatistics(List<float> grades)

           
           
            
        {

            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in grades)
            {
                if (grade >= 0)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;
                }


                statistics.Average /= this.grades.Count;
            }

            return CountStatistics();


            
        }

        private Statistics CountStatistics()
        {
            throw new Exception();
        }
    }
    }

