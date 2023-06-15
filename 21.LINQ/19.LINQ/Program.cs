﻿var employees = new List<Employee>
            {
                new Employee {LastName = "Andreev", FirstName = "Andrew",  Nationality = "Ukrainian"},
                new Employee {LastName = "Ivanov",  FirstName = "Ivan",    Nationality = "Russian"},
                new Employee {LastName = "Andreev", FirstName = "Ivan",  Nationality = "Ukrainian"},
                new Employee {LastName = "Petrov",  FirstName = "Petr",    Nationality = "American"},
                new Employee {LastName = "Andreev", FirstName = "Sergey",  Nationality = "Ukrainian"},
                new Employee {LastName = "Petrov",  FirstName = "Slava",    Nationality = "American"}
            };

var query = from emp in employees
            group emp by new { Nationality = emp.Nationality, LastName = emp.LastName };

foreach (var group in query)
{
    Console.WriteLine(group.Key);

    foreach (var employee in group)
        Console.WriteLine(employee.FirstName);
}

// Delay.
Console.ReadKey();

public class Employee
{
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Nationality { get; set; }
}