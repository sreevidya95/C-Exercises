using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPlay
{
    internal class SportsPlayer
    {
        public string playerName;
        public string sportsName;
        public int noe;
        public int age;
        public string gender;

        public SportsPlayer(int age)
        {
            if (age < 18)
            {
                Console.WriteLine(age);
                Console.WriteLine("You are Under age to play");
            }
            else
            {
                Console.WriteLine("You are allowed to play");
            }

        }
        public void ageCriteria()
        {
            Console.WriteLine(playerName);
            Console.WriteLine(sportsName);
            Console.WriteLine(gender);
            Console.WriteLine(noe);
            Console.WriteLine(age);
        }

    }
}
