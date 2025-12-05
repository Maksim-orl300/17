internal class Program
{
    static void Main(string[] args)
    {
        var emp = new Employee
        {
            Name = "Петр",
            HireDate = new DateTime(2020, 3, 15),
            Status = EmployementStatus.Active
        };
        Console.WriteLine(emp.GetYearsWorked());
        emp.HireDate = null;
        Console.WriteLine(emp.GetYearsWorked());
        Console.WriteLine(emp);


        var w1 = new Weather { City = "Москва", Temperature = 22.5 };
        var w2 = new Weather { City = "Сочи", Temperature = null };
        Console.WriteLine(w1);
        Console.WriteLine(w2);
        Console.WriteLine(w2.Temperature ?? -999);


        var f = new File { Permissions = FileAccess.Read | FileAccess.Write };
        Console.WriteLine(f.CanRead());
        Console.WriteLine(f.CanWrite());


        var order1 = new Order { Id = 1001, Total = 1500.00m };
        var order2 = order1;
        order2.Total = 2000.00m;
        Console.WriteLine(order2.Total);
        Console.WriteLine(order1.Total);

        var c1 = new Color(255, 128, 0);
        var c2 = c1;
        c2.R = 100;
        Console.WriteLine(c1);
        Console.WriteLine(c2);
    }
}
