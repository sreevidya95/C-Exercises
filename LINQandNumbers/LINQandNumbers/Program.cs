using LINQandNumbers;

internal class Program:LinqandNumbers
{
    private static void Main(string[] args)
    {

        Random r = new Random();
        List<int> numbers = new List<int>();
        for (int i = 0; i < 50; i++)
        {
            numbers.Add(r.Next(1,1000));
        }
        Program p = new Program();
        p.GetAsc(numbers);
       p.GetHunderedDesc(numbers);
        p.GetEven(numbers);
        p.GetAggregates(numbers);
    }
}