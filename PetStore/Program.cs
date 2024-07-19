using PetStore;
using System.Runtime.CompilerServices;

internal class Program:Invenotory
{
    private static void Main(string[] args)
    {
       
        Program p = new Program();
        p.quantity=0;
        p.price = 0;
        do
        {
            Console.WriteLine("Menu.....");
            Console.WriteLine("1.View All items");
            Console.WriteLine("2.view Item by Id");
            Console.WriteLine("3.purchase Item");
            Console.WriteLine("4.Exit");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    {
                        string items = p.readData();

                        Console.WriteLine(items);
                        
                        break;
                    }  
                case 2:
                    {
                        Console.WriteLine("Enter the Items Id");
                        int id2 = int.Parse(Console.ReadLine());
                        string[] items = p.readData().Split("\n");
                        foreach (string i in items)
                        {
                            string split = i.Split(',')[0];
                            int id = int.Parse(split);
                            if (id == id2)
                            {
                                Console.WriteLine($"{i}");
                                break;
                            }

                        }
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Enter Item id You want to Purchase");
                        int id = int.Parse(Console.ReadLine());
                        string[] items = p.readData().Split("\n");
                        foreach (string i in items)
                        {
                            string[] split = new string[50];
                               split= i.Split(',');
                            int itemId = int.Parse(split[0]);
                            if (itemId == id)
                            {
                                if (int.Parse(split[5]) > 0)
                                {

                                    p.price+= Decimal.Parse(split[4]);
                                   

                                    Console.WriteLine("Item purchased total amount is"+p.price);
                                }
                                else
                                {
                                    Console.WriteLine("SoldOut");
                                }
                                

                                break;
                            }

                        }

                        break;
                    } 
                case 4: return; 
                default: Console.WriteLine("Invalid Selection"); break; 

            }
        } while (true);


     }


}