using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCore.Infrastructure
{
    public interface IConverter
    {
        double Convert(string str);
        string ConvertBack(double num);

    }
}
