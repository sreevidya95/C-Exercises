internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter You Name:");
        string name = Console.ReadLine();
        Console.WriteLine("What Will be Your age on dec 31?");
        int age = int.Parse(Console.ReadLine());
        getYear(age);

        void getYear(int age)
        {
            int year =DateTime.Now.Year;
            int dob = year - age;
            Console.WriteLine($"{name} Date of Birth is: {dob}");

        }
    }
}