using PetStore;
using System.Runtime.CompilerServices;

internal class Program:Invenotory
{
    private static void Main(string[] args)
    {
       
        Program p = new Program();
        p.quantity=0;
        p.price = 0;
        p.id = 0;
        string file = p.readData();
        string[] items = string[10];
        items = file.split('\n');

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
                       

                        Console.WriteLine(file);
                        
                        break;
                    }  
                case 2:
                    {
                        Console.WriteLine("Enter the Items Id");
                        p.id= int.Parse(Console.ReadLine());
                        if (p.id > items.Length)
                        {
                            Console.WriteLine("invalid id selection");
                        }
                        else
                        {
                            foreach (string i in items)
                            {
                                string split = i.Split(',')[0];
                                int id = int.Parse(split);
                                if (id == p.id)
                                {
                                    p.id = id;
                                    Console.WriteLine($"{i}");
                                    break;
                                }

                            }
                        }
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Enter Item id You want to Purchase");
                        int p.id = int.Parse(Console.ReadLine());
                        foreach (string i in items)
                        {
                            string[] split = new string[50];
                               split= i.Split(',');
                            int itemId = int.Parse(split[0]);
                            if (itemId == p.id)
                            {
                                p.quantity = int.parse(split[5])-1;
                                if (p.quantity > 0)
                                {
                                    Console.WriteLine("Available Items" + p.quantity);
                                    split[5] =(p.quntity).toString();
                                    p.price+= Decimal.Parse(split[4]);
                                    i = split;
                                    Console.WriteLine("Item purchased,total amount is"+p.price);
                                   
                                   
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