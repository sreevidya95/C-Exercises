using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQandNumbers
{
    internal class LinqandNumbers
    {

        List<int> list = new List<int>();
        internal void GetAsc(List<int> numbers)
        {
            list = (from n in numbers
                    orderby n select n).ToList();
            Console.WriteLine("AScending Order");
            foreach (int n in list) { 
                Console.WriteLine(n);
            }

           
        }
        internal void GetHunderedDesc(List<int> numbers)
        {
            Console.WriteLine("Descending Order");
            list = (from n in numbers
                    where n <= 100
                    orderby n descending
                    select n).ToList();
            foreach (int n in list)
            {
                Console.WriteLine(n);
            }

        }
        internal void GetEven(List<int> numbers)
        {
            list = (from n in numbers
                    where n % 2 == 0
                    select n).ToList();
            foreach (int n in list)
            {
                Console.WriteLine(n);
            }
        }
        internal void GetAggregates(List<int> numbers)
        {
            int min, max, sum;
            double avg;
            min = (from n in numbers
                   select n).Min();
            max = (from n in numbers select n).Max();
            avg = (from n in numbers select n).Average();
            sum = (from n in numbers select n).Sum();
            Console.WriteLine("The minimum number is: " + min);
            Console.WriteLine("The maximum number is: " + max);
            Console.WriteLine("The Average of numbers is: " + avg);
            Console.WriteLine("The SUm is: " + sum);

        }
    }
}
