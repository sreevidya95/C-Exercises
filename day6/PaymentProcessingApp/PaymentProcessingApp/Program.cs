using PaymentProcessingApp;

internal class Program:PaymentMethods
{
    public delegate bool PaymentHandler(string accountnum, double amoun);
    private static void Main(string[] args)
    {
        Program p = new Program();
        PaymentProcessor processor = new PaymentProcessor();
        PaymentHandler mastercardHandler = new PaymentHandler(p.ProcessMastercardPayment);
        bool isOk = processor.ProcessPayment(mastercardHandler,"1234 - 1111 - 2222 - 1234", 100.00);

        if (!isOk)
            Console.WriteLine("[ALERT] Payment processing failed");
        else Console.WriteLine("[ALERT] Payment processing Success");
        //Func<string, double,bool> func = p.ProcessMastercardPayment;
        //Console.WriteLine(func.Invoke("123g1aq", 123456789.1234));
        //Console.WriteLine(func.Invoke("123g1aq", 1234567.1234));

    }
}