// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter Price Code");
int productCode = int.Parse(Console.ReadLine());
int quantity = int.Parse(Console.ReadLine());
switch (productCode)
{
    case 127:
        {
            if (quantity >= 1 && quantity <= 24)
            {
                Console.WriteLine(quantity * 18.99);
            }
            else if(quantity>=25 && quantity <= 50)
            {
                Console.WriteLine(quantity * 17.00);
            }
            else if (quantity >= 51)
            {
                if (quantity >= 200)
                {
                    Console.WriteLine((quantity * 14.49) - ((quantity * 14.49) * 15 / 100));
                }
                else
                Console.WriteLine(quantity * 14.49);
            }
            break;
        }
    case 28:
        {
            if (quantity >= 1 && quantity <= 24)
            {
                Console.WriteLine(quantity * 125.00);
            }
            else if (quantity >= 25 && quantity <= 50)
            {
                Console.WriteLine(quantity * 113.75);
            }
            else if (quantity >= 51)
            {
                if (quantity >= 200)
                {
                    Console.WriteLine((quantity * 99.99) - ((quantity * 99.99) * 15 / 100));
                }
               else  Console.WriteLine(quantity * 99.99);

            }
            break;
        }
    case 8:
        {
            if (quantity >= 1 && quantity <= 24)
            {
                Console.WriteLine(quantity * 8.99);
            }
            else if (quantity >= 25 && quantity <= 50)
            {
                Console.WriteLine(quantity * 8.99);
            }
            else if (quantity >= 51)
            {
               
                if (quantity >= 200)
                {
                    Console.WriteLine((quantity * 7.49) - ((quantity * 7.49)*15/100));
                }
                else Console.WriteLine(quantity * 7.49);
            }
            break;
        }
    default:
        {
            Console.WriteLine("Invalid code");
            break;
        }
}
