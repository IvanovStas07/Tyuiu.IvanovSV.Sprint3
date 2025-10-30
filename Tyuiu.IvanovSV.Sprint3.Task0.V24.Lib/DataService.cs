using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.IvanovSV.Sprint3.Task0.V24.Lib
{
    public class DataService : ISprint3Task0V24
    {
        public double GetMultiplySeries(int value, int start, int stop)
        {
            double product = 1.0;


            for (int i = start; i <= stop; i++)
            {
                double term = Math.Pow(3.0 / (i + Math.Pow(value, -i)), 2);
                product *= term;
            }

            return Math.Round(product, 3);
        }
    }
}