

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>();

        
        Employee User1 = new Employee("Adam Mickiewicz", 30);
        Employee User2 = new Employee("Julian Tuwim", 42);
        Employee User3 = new Employee("Mikołaj Kopernik", 55);

        User1.AddRating(7);
        User1.AddRating(9);
        User1.AddRating(8);
        User1.AddRating(6);
        User1.AddRating(10);

        User2.AddRating(5);
        User2.AddRating(7);
        User2.AddRating(8);
        User2.AddRating(9);
        User2.AddRating(6);

        User3.AddRating(10);
        User3.AddRating(9);
        User3.AddRating(8);
        User3.AddRating(7);
        User3.AddRating(6);

        employees.Add(User1);
        employees.Add(User2);
        employees.Add(User3);

       
        Employee employeeWithHighestRating = null;
        int maxRating = 0;

        foreach (Employee employee in employees)
        {
            if (employee.GetAverageRating() > maxRating)
            {
                maxRating = employee.GetAverageRating();
                employeeWithHighestRating = employee;
            }
        }

       
        if (employeeWithHighestRating != null)
        {
            Console.WriteLine("Pracownik z najwyższą liczbą ocen:");
            Console.WriteLine("Imię i nazwisko: " + employeeWithHighestRating.FullName);
            Console.WriteLine("Wiek: " + employeeWithHighestRating.Age);
            Console.WriteLine("Średnia ocen: " + employeeWithHighestRating.GetAverageRating());
        }
    }
}
