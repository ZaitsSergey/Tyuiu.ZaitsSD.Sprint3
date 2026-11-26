using Tyuiu.ZaitsSD.Sprint3.Task2.V1.Lib;
namespace Tyuiu.ZaitsSD.Sprint3.Task2.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void CheckSigmaExample()
        {
            double res = ds.GetSumSeries(1, 10);
            double res_wait = 0.353;
            Assert.AreEqual(res_wait, res);
        }
    }
}
