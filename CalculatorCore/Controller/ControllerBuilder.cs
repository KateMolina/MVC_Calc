using CalculatorCore.Infrastructure;
using CalculatorCore.Model;
using CalculatorCore.View;

namespace CalculatorCore.Controller
{
    public class ControllerBuilder
    {
        Controller controller;
        public ControllerBuilder() => controller = new Controller();


        public ControllerBuilder SetModel(IModel model)
        {
            controller.Model = model;
            return this;
        }
        public ControllerBuilder SetView(IView view)
        {
            controller.View = view;
            return this;
        }

        public ControllerBuilder SetConverter(IConverter converter)
        {
            controller.Converter = converter;
            return this;
        }

        public Controller Build() => controller;
    }
}
