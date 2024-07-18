// See https://aka.ms/new-console-template for more information
Console.WriteLine("xEnter Encoded String");
string encodedString = Console.ReadLine();
String[] address = new String[4];
address = encodedString.Split("|");
Console.WriteLine("name:"+address[0]);
Console.WriteLine("addrss:" + address[1]);
Console.WriteLine("City:" + address[2]);
Console.WriteLine("Country:" + address[3]);
