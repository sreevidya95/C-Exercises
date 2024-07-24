using LINQandObjects;

internal class Program:Person
{
    private static void Main(string[] args)
    {
      List<Person> people = new List<Person>();
        people.Add(new Person { 
          Name = "Sree",
          Gender = "Female",
          Age=30,
          HomeTown="Anantapur"
        });
        people.Add(new Person
        {
            Name = "kasyap",
            Gender = "Male",
            Age = 35,
            HomeTown = "Bellary"
        });
        people.Add(new Person
        {
            Name = "Vihaan",
            Gender = "Male",
            Age = 5,
            HomeTown = "Bangalore"
        });
        people.Add(new Person
        {
            Name = "Sree12",
            Gender = "Female",
            Age = 22,
            HomeTown = "hyderabad"
        });
        people.Add(new Person
        {
            Name = "lalli",
            Gender = "Female",
            Age = 50,
            HomeTown = "kadapa"
        });
        people.Add(new Person
        {
            Name = "Sreenu",
            Gender = "Male",
            Age = 53,
            HomeTown = "Btp"
        });
        people.Add(new Person
        {
            Name = "lekha",
            Gender = "Female",
            Age = 25,
            HomeTown = "Anantapur"
        });
        people.Add(new Person
        {
            Name = "mani",
            Gender = "Female",
            Age = 60,
            HomeTown = "bellary"
        });
        people.Add(new Person
        {
            Name = "Alice",
            Gender = "Female",
            Age = 32,
            HomeTown = "Springfield"
        }
        );
        people.Add(new Person
        {
            Name = "Bob",
            Gender = "Male",
            Age = 45,
            HomeTown = "New York"
        });
        people.Add(new Person
        {
            Name = "Elena",
            Gender = "Female",
            Age = 28,
            HomeTown = "Los Angeles"
        });
         people.Add(new Person
         {
             Name = "Jack",
             Gender = "Male",
             Age = 37,
             HomeTown = "Chicago"
         });
        people.Add(new Person
        {
            Name = "Sophia",
            Gender = "Female",
            Age = 50,
            HomeTown = "Miami"
        });
        people.Add(new Person
        {
            Name = "David",
            Gender = "Male",
            Age = 41,
            HomeTown = "Houston"
        });
        people.Add(new Person
        {
            Name = "Emma",
            Gender = "Female",
            Age = 29,
            HomeTown = "Seattle"
        });
        people.Add(new Person
        {
            Name = "Michael",
            Gender = "Male",
            Age = 34,
            HomeTown = "San Francisco"
        });
        people.Add(new Person
        {
            Name = "Olivia",
            Gender = "Female",
            Age = 26,
            HomeTown = "Boston"
        });
        people.Add(new Person
        {
            Name = "William",
            Gender = "Male",
            Age = 39,
            HomeTown = "Denver"
        });
        people.Add(new Person
        {
            Name = "Sophie",
            Gender = "Female",
            Age = 31,
            HomeTown = "Dallas"
        });
        people.Add(new Person
        {
            Name = "Daniel",
            Gender = "Male",
            Age = 43,
            HomeTown = "Atlanta"
        });
        people.Add(new Person
        {
            Name = "Mia",
            Gender = "Female",
            Age = 35,
            HomeTown = "Phoenix"
        });
        people.Add(new Person
        {
            Name = "Liam",
            Gender = "Male",
            Age = 30,
            HomeTown = "Portland"
        });
        people.Add(new Person
        {
            Name = "Isabella",
            Gender = "Female",
            Age = 38,
            HomeTown = "San Diego"
        });
        people.Add(new Person
        {
            Name = "Samantha",
            Gender = "Female",
            Age = 27,
            HomeTown = "Charlotte"
        });

        Program p = new Program();
        p.GetMaleUnder25(people);
        p.GetHomeTown(people);
        p.OrderByHomeTown_Name(people);
        p.AverageAge(people);
        p.List_people(people);

    }
}