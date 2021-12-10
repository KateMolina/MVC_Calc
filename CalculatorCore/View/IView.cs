using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCore.View
{
   public interface IView
    {
        public string FirstNumber { get;  }
        public string SecondNumber { get; }
        public string Result { set; }
    }


}
