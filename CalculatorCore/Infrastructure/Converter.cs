namespace CalculatorCore.Infrastructure
{
    public class Converter : IConverter
    {
        public double Convert(string str)
        {
            double.TryParse(str, out double result);
            return result;
        }

        public string ConvertBack(double num) => $"{num}";
     
    }
}
