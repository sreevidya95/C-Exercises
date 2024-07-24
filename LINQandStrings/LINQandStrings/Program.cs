using LINQandStrings;

internal class Program:Linq
{
    private static void Main(string[] args)
    {
       List<string> fruits = new List<string>();
        fruits.Add("mango");
        fruits.Add("Apple");
        fruits.Add("Banana");
        fruits.Add("Pear");
        fruits.Add("grapes");
        fruits.Add("avacado");
        fruits.Add("lichi");
        fruits.Add("custord apple");
        fruits.Add("pine apple");
        fruits.Add("jack fruit");
        fruits.Add("papaya");
        fruits.Add("dates");
        fruits.Add("blue berry");
        fruits.Add("musk melon");
        fruits.Add("water melon");
        fruits.Add("guava");
        fruits.Add("pomegranate");
        fruits.Add("orange");
        fruits.Add("straw berry");
        fruits.Add("cherry");

        Program p = new Program();
        p.GetFruitstartswithb(fruits);
        p.HasBerry(fruits);
        p.StartWitmA_M(fruits);
        p.StartsWithN_Z(fruits);
        p.longstring(fruits);

    }
}