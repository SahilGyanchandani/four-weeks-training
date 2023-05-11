using System;
using System.Collections.Generic;
using System.Linq;
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Country { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>()
        {
            new Person { Name = "John", Age = 25, Country = "USA" },
            new Person { Name = "Emma", Age = 30, Country = "Canada" },
            new Person { Name = "Michael", Age = 35, Country = "USA" },
            new Person { Name = "Sophia", Age = 28, Country = "Canada" },
            new Person { Name = "Daniel", Age = 32, Country = "USA" }
        };
        int filterAge = 30;
        var filteredPeople = people.Where(p => p.Age > filterAge);
        var sortedPeople = filteredPeople.OrderBy(p => p.Name);
        var projectedPeople = sortedPeople.Select(p => new { p.Name, p.Country });
        foreach (var person in projectedPeople)
        {
            Console.WriteLine($"Name: {person.Name}, Country: {person.Country}");
        }
       
    }
}