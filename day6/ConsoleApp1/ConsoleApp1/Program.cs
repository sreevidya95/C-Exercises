using Delegate_Math;
using System.Security.Cryptography.X509Certificates;

internal class Program:BasicMath
{
    public delegate double MathOperations(double x, double y);
    private static void Main(string[] args)
    {
       Program p = new Program();
        //MathOperations m = new MathOperations(p.Add);
        //MathOperations m = new MathOperations(p.Substract);
        //MathOperations m = new MathOperations(p.Multiply);
        MathOperations m = new MathOperations(p.Divide);
        double result = m.Invoke(10.54,123.467);
        Console.WriteLine(result);
      
    }
}