using CalculatorCore.Infrastructure;

namespace CalculatorCore.Model
{
    public class Model: IModel
    {
        private readonly IArithmetic arithmetic;
        public Model(IArithmetic arithmetic)
        {
            this.arithmetic = arithmetic;
        }

        public double Execute(double x, double y)
        {
            return arithmetic.Result(x, y);
        }
    }
}
