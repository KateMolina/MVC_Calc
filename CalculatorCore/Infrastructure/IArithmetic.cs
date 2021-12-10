using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCore.Infrastructure
{
    public interface IArithmetic
    {
        double Result(double a, double b);
    }

    public class Sum : IArithmetic
    {
        public double Result(double a, double b) => a + b;
        
    }
    public class Sub : IArithmetic
    {
        public double Result(double a, double b) => a - b;

    }
    public class Mult : IArithmetic
    {
        public double Result(double a, double b) => a * b;

    }
    public class Div : IArithmetic
    {

        public double Result(double a, double b) => a / b;

    }
}
