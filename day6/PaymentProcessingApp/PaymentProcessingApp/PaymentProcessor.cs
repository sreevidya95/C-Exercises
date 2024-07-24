using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program;

namespace PaymentProcessingApp
{
    internal class PaymentProcessor
    {
       
        internal bool ProcessPayment(PaymentHandler paymentHandler, string accountNumber, double amount)
        {
            return paymentHandler(accountNumber,amount);
        }

    }
}
