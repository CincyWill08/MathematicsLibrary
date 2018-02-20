using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicsLibrary
{
    public class MathLib
    {
        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Subtract(double a, double b)
        {
            return a - b;
        }
        public double Multiply(double a, double b)
        {
            return a * b;
        }
        public double Divide(double a, double b)
        {
            return a / b;
        }
        public double SqrRoot(double a)
        {
            return Math.Sqrt(a);
        }
        public double Inverse(double a)
        {
            return 1/a;
        }
        public double Negate(double a)
        {
            return a * -1;
        }
    }
}
