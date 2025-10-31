using Tyuiu.IvanovSV.Sprint3.Task4.V5.Lib;
namespace Tyuiu.IvanovSV.Sprint3.Task4.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculationValid()
        {
            DataService ds = new DataService();
            int start = -5, end = 5;
            double res = ds.Calculate(start, end);
            Assert.AreEqual(-0.858, res);
        }
    }
}