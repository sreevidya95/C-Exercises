
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter time is hh:mm format");
        TimeOnly t = TimeOnly.Parse(Console.ReadLine());
        Console.WriteLine("Enter how many minutes to add");
        int minutes = int.Parse(Console.ReadLine());    
        Console.WriteLine(t);
        Console.WriteLine(minutes);
        Console.WriteLine(t.AddMinutes(minutes));
    }
}