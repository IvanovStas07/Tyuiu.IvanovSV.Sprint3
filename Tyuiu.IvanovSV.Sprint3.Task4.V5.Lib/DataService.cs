using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.IvanovSV.Sprint3.Task4.V5.Lib
{
    public class DataService : ISprint3Task5V21
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sum1 = 0;
            for (int i = startValue1; i <= stopValue1; i++)
            {
                double sum2 = 0;
                for (int j = startValue2; j <= stopValue2; j++)
                {
                    sum2 += (x * x * x * Math.Cos(j) + 2);
                }
                sum1 += sum2;
            }
            return Math.Round(sum1, 3);
        }
    }
}
