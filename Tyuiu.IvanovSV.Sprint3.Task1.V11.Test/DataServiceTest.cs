using Tyuiu.IvanovSV.Sprint3.Task1.V11.Lib;
namespace Tyuiu.IvanovSV.Sprint3.Task1.V11.Test
{
    public class DataServiceTest
    {
        public void ValidGetMUltSeries()
        {
            DataService ds = new DataService();

            double value = 4;
            int startValue = 2;
            int endValue = 3;

            double res = ds.GetMultiplySeries(value, startValue, endValue);

            double wait = 0;

            Assert.AreEqual(wait, res);
        }
    }
}