internal class Program
{
    private static void Main(string[] args)
    {
       Program p = new Program();
        LoggingOperation lp = p.Info;
        lp += p.Warning;
        lp += p.Error;
        lp.Invoke("Hello World!!");

    }
    void Info(string message)
    {
        Console.WriteLine("[INFO]"+message);
    }
    void Warning(string message) 
    { 
        Console.WriteLine("[warning]"+message);
    }
    void Error(string message)
    {
        Console.WriteLine("[Error]" + message);
    }
    delegate void LoggingOperation(string message);
}