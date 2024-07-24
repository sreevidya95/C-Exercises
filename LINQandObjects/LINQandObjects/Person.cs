using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQandObjects
{
    internal class Person
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
        List<Person> List = new List<Person> ();
        internal void GetMaleUnder25(List<Person> person)
        {
               List = (from p in person
                       where p.Age < 25
                       select p).ToList ();  
            List.ForEach(p=>Console.WriteLine(p.Name));
        }
        internal void GetHomeTown(List<Person> person)
        {
            string[] town = new string[20];
           town= (from p in person
                    orderby p.HomeTown
                    select p.HomeTown).Distinct().ToArray();
            foreach (var item in town)
            {
                Console.WriteLine(item);
            }
        }
        internal void AverageAge(List<Person> person)
        {

            var item = (from p in person
                        group p by p.Gender into g
                        select new
                        {
                            Average = g.Average(p => p.Age),
                        }).ToArray();
            foreach(var i in item)
            {
                Console.WriteLine(i);
            }
        }
        internal void OrderByHomeTown_Name(List<Person> person)
        {
            List = (from p in person
                    orderby p.HomeTown, p.Name
                    select p).ToList();
           //method : List = person.OrderBy(p=>p.HomeTown).ThenBy(p=>p.Name).ToList();
            List.ForEach(p => Console.WriteLine(p.Name));
        }
        internal void List_people(List<Person> persons)
        {
            var per = (from p in persons
                    group p by p.HomeTown into g
                    select new
                    {
                        count = g.Count(),
                        home =g.Key
                    }).ToArray();
            foreach(var item in per)
            {
                Console.WriteLine(item);
            }
        }
    }
    
}
