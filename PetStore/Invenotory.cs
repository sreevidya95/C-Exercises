using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Drawing;

namespace PetStore
{
    internal class Invenotory
    {
        public int id;
        public string name;
        public string description;
        public decimal price;
        public int quantity;
            public string readData()
            {
                    String[] file = new string[50];
            try
                {

                    if (!File.Exists(@"D:\Users\sreevidya\source\repos\C-Exercises\PetStore\TestFile.txt"))
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.Append(" 1,Food,Dog Food, High-quality dry dog food,15.49,50,BrandA,Dry,Dog\r\n");
                        sb.Append("2,Accessory,Cat Collar, Cat collar with bell,5.99,20,Small,Blue\r\n");
                        sb.Append("3,Cage,Parrot Cage, Large parrot cage with toys,120.00,5,24x24x36,Wire\r\n");
                        sb.Append("4,Aquarium,50 - gallon Fish Tank,50 - gallon fish tank with stand,200.00,3,50,Rectangle\r\n");
                        sb.Append("5,Toy,Hedgehog Wheel, Exercise wheel for hedgehogs, 12.49, 8, Plastic, 6months\r\n");

                        File.WriteAllText(@"D:\Users\sreevidya\source\repos\C-Exercises\PetStore\TestFile.txt", sb.ToString());

                     }

                    

            }
                catch (Exception e)
                {
                        // Let the user know what went wrong.
                        Console.WriteLine("The file could not be read:");
                        Console.WriteLine(e.Message);
                 }
            return File.ReadAllText(@"D:\Users\sreevidya\source\repos\C-Exercises\PetStoreTestFile.txt");
        }
            


    }
    
     
}
