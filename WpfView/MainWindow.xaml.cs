using CalculatorCore.Controller;
using CalculatorCore.Infrastructure;
using CalculatorCore.Log;
using CalculatorCore.Model;
using CalculatorCore.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfView
{

    public partial class MainWindow : Window, IWPFView
    {
      
        public string FirstNumber
        {
            get
            {
                return tb.Text;
            }
        }
        public string SecondNumber => tb1.Text;
        public string Result { set => tb2.Text = value; }

        public MainWindow()
        {
            InitializeComponent();

            var controller = new LoggerController(new ControllerBuilder()
                .SetView(this).SetModel(new Model(new Sum()))
                .SetConverter(new Converter()).Build(), new DebugLog());
            res.Click += delegate { controller.ButtonClick(); };
            
        }
        public void WPFWelcome()
        {
            Console.WriteLine("");
        }
    }
}
