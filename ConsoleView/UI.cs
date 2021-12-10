using CalculatorCore.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleView
{
    class UI : IConsoleView

    {
        public string FirstNumber { get
            {
                Console.Write( "First Number: ");
                return Console.ReadLine();
            }
        }
        public string SecondNumber {
            get
            {
                Console.Write("Second Number: ");
                return Console.ReadLine();
            }
        }
        public string Result {
            set
            {
                Console.WriteLine($"Result: {value}");
            }
               }

        public void ConsoleWelcome() => Console.WriteLine("Welcom method from ConsoleView");
        
    }
}
