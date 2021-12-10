using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCore.Model
{
    public interface IModel
    {
        public double Execute(double a, double b);
    }
}
