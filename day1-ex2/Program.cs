// See https://aka.ms/new-console-template for more information
string name = "Zachary";
DateTime bday = new DateTime(1990, 5, 20);
double pay = 69759.25;
Console.WriteLine("v1- {0} was born on {1:dd-MM-yyyy} and earns {2:c}", name, bday, pay);
Console.WriteLine($"v2 - {name} was born on {bday:dd-mm-yyyy} and earns {pay:c}"); 

