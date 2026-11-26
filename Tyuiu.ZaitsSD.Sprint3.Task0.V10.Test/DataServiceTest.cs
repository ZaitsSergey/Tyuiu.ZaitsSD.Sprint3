using Tyuiu.ZaitsSD.Sprint3.Task0.V10.Lib;
namespace Tyuiu.ZaitsSD.Sprint3.Task0.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void CheckSigmaFunc()
        {
            double res = ds.GetMultiplySeries(5, 1, 5);
            Assert.AreEqual(0.033, res);
        }
    }
}
