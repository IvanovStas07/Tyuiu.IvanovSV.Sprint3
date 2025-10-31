using Tyuiu.IvanovSV.Sprint3.Task5.V24.Lib;
namespace Tyuiu.IvanovSV.Sprint3.Task5.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double wait = -4308.964;
            double res = ds.GetSumSumSeries(2, 1, 3, 1, 12);
            Assert.AreEqual(wait, res);
        }
    }
}