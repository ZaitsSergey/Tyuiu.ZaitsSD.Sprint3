using Tyuiu.ZaitsSD.Sprint3.Task5.V9.Lib;
namespace Tyuiu.ZaitsSD.Sprint3.Task5.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void CheckSigmaFunc()
        {
            double res = ds.GetSumSumSeries(5, 1, 1, 3, 14);
            double res_wait = 26.235;
            Assert.AreEqual(res_wait, res);
        }
    }
}
