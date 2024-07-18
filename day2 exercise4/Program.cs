// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the amount you are borrowing");
float amount = float.Parse(Console.ReadLine());
Console.WriteLine("Enter your interest rate");
float interest = float.Parse(Console.ReadLine());
Console.WriteLine("Enter How many years?");
int years = int.Parse(Console.ReadLine());
double mir =  (interest / 1200);
double np = -(years * 12);
double power = Math.Pow(1+mir,np);

double payment = (amount * mir) / 1 - power;
Console.WriteLine($"The Estimated Payment is {payment:C}");