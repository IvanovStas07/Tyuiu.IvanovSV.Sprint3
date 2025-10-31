using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.IvanovSV.Sprint3.Task5.V24.Lib
{
    public class DataService : ISprint3Task5V24
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double res = 0;
            for (startValue1 = 1; startValue1 <= stopValue1; startValue1++)
            {
                for (startValue2 = 1; startValue2 <= stopValue2; startValue2++)
                {
                    res += (Math.Pow(x, startValue2) + 2) * Math.Sin(startValue2);
                }
            }
            res = Math.Round(res, 3);
            return res;
        }
    }
}