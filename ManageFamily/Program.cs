using System;
using System.Collections.Generic;
namespace ManageFamily {
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }

    public Person(string name, int age, string gender)
    {
        Name = name;
        Age = age;
        Gender = gender;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Gender: {Gender}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>();

        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add a person");
            Console.WriteLine("2. Display all people");
            Console.WriteLine("3. Display people of a selected gender");
            Console.WriteLine("4. Display people within an age range");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddPerson(people);
                    break;
                case "2":
                    DisplayAllPeople(people);
                    break;
                case "3":
                    DisplayPeopleByGender(people);
                    break;
                case "4":
                    DisplayPeopleByAgeRange(people);
                    break;
                case "5":
                    Console.WriteLine("Exiting the program.");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid menu option.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void AddPerson(List<Person> people)
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        Console.Write("Enter age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter gender: ");
        string gender = Console.ReadLine();

        Person person = new Person(name, age, gender);
        people.Add(person);

        Console.WriteLine("Person added successfully.");
    }

    static void DisplayAllPeople(List<Person> people)
    {
        Console.WriteLine("All people:");
        foreach (Person person in people)
        {
            person.Display();
        }
    }

    static void DisplayPeopleByGender(List<Person> people)
    {
        Console.Write("Enter gender to filter (Male/Female/Others): ");
        string gender = Console.ReadLine();

        Console.WriteLine($"People with gender '{gender}':");
        foreach (Person person in people)
        {
            if (person.Gender.Equals(gender, StringComparison.OrdinalIgnoreCase))
            {
                person.Display();
            }
        }
    }

    static void DisplayPeopleByAgeRange(List<Person> people)
    {
        Console.Write("Enter minimum age: ");
        int minAge = int.Parse(Console.ReadLine());

        Console.Write("Enter maximum age: ");
        int maxAge = int.Parse(Console.ReadLine());

        Console.WriteLine($"People between ages {minAge} and {maxAge}:");
        foreach (Person person in people)
        {
            if (person.Age >= minAge && person.Age <= maxAge)
            {
                person.Display();
            }
        }
    }
}
}
