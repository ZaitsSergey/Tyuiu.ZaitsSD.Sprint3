using Tyuiu.ZaitsSD.Sprint3.Task1.V14.Lib;
namespace Tyuiu.ZaitsSD.Sprint3.Task1.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void CheckSigmaExample()
        {
            double res = ds.GetSumSeries(0.7, 1, 14);
            double res_wait = 3.546;
            Assert.AreEqual(res_wait, res);
        }
    }
}
