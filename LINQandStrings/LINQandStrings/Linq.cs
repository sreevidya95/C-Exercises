using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQandStrings
{
    internal class Linq
    {
        List<string> list = new List<string>();
        internal void GetFruitstartswithb(List <string> fuits)
        {
            list = (from f in fuits
                    where f.StartsWith('B') || f.StartsWith('b')
                    select f).ToList(); 
            list.ForEach(x => Console.WriteLine(x));
            
        }
        internal void HasBerry(List<string> fuits) { 
        
         list = (from f in fuits
                 where f.Contains("berry")
                 select f).ToList();
            list.ForEach(x => Console.WriteLine(x));

        }
        internal void StartWitmA_M(List<string> fruits){
            list =(from f in fruits
                   where f.StartsWith('a') || f.StartsWith('b')|| f.StartsWith('c')|| f.StartsWith('d')
                   ||  f.StartsWith('e') || f.StartsWith('f') || f.StartsWith('g') || f.StartsWith('h')||
                   f.StartsWith('i') || f.StartsWith('j') || f.StartsWith('k') || f.StartsWith('l') || f.StartsWith('m')
                   select f).ToList();
            list.ForEach(x => Console.WriteLine(x));
        }
        internal void StartsWithN_Z(List<string> fruits)
        {
            list = (from f in fruits
                    where f.StartsWith('n') || f.StartsWith('o') || f.StartsWith('p') || f.StartsWith('q')
                    || f.StartsWith('r') || f.StartsWith('s') || f.StartsWith('t') || f.StartsWith('u') ||
                    f.StartsWith('v') || f.StartsWith('w') || f.StartsWith('x') || f.StartsWith('y') || f.StartsWith('z')
                    select f).ToList();
            list.ForEach(x => Console.WriteLine(x));
        }
        internal void longstring(List<string> fruits) {
           Console.WriteLine( (from f in fruits
                    select f).MaxBy(x => x.Length));
        
        }
    }
}
