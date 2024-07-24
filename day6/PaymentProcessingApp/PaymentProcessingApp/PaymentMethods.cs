using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessingApp
{
    internal class PaymentMethods
    {
       public bool ProcessMastercardPayment(string accountNumber, double amount)
        {
            if (amount == 123456789.1234)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool ProcessVisaPayment(string accountNumber, double amount)
        {
            if (amount == 123456789.1234)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool ProcessDiscoverPayment(string accountNumber, double amount)
        {
            if (amount == 123456789.1234)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
