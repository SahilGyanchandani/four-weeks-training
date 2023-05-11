using System;
using System.Collections.Generic;
using System.Linq;
class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>
        {
            new Person { FirstName = "Rahul", LastName = "Mishra", Age = 20 },
            new Person { FirstName = "Janki", LastName = "Sharma", Age = 35 },
            new Person { FirstName = "Minesh", LastName = "Mishra", Age = 30 },
            new Person { FirstName = "Mayank", LastName = "Sharma", Age = 25 },
        };
        var filteredPeople = people.Where(p => p.Age >= 25)
                                   .OrderBy(p => p.LastName)
                                   .ThenBy(p => p.FirstName);
        foreach (var person in filteredPeople)
        {
            Console.WriteLine($"Name: {person.FirstName} {person.LastName}, Age: {person.Age}");
        }
    }
}