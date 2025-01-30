using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    public class Multiplication : IOperation
    {
        public double Execute(double a, double b) => a * b;
    }
}
