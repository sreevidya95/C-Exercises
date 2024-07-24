using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Math
{
    internal class BasicMath
    {
        public double Add(double x, double y) {
            return x + y;
        }
        public double Substract(double x, double y)
        {
            return x - y;
        }
        public double Multiply(double x, double y)
        {
            return x * y;
        }
        public double Divide(double x, double y)
        {
            return x / y;
        }
    }
}
