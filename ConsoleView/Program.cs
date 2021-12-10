using CalculatorCore.Controller;
using CalculatorCore.Infrastructure;
using CalculatorCore.Log;
using CalculatorCore.Model;
using System;

namespace ConsoleView
{
    class Program
    {

        static void Main(string[] args)
        {
            var conrol = new LoggerController(new ControllerBuilder().SetView(new UI())
                .SetModel(new Model(new Sum()))
                .SetConverter(new Converter())
                .Build(), new DebugLog()
                );

            conrol.ButtonClick();
            
        }
    }
}
