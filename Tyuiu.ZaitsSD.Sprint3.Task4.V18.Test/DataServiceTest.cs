using Tyuiu.ZaitsSD.Sprint3.Task4.V18.Lib;
namespace Tyuiu.ZaitsSD.Sprint3.Task4.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void FuncExample()
        {
            double res = ds.Calculate(-5, 5);
            double res_wait = 2.993;
            Assert.AreEqual(res_wait, res);
        }
    }
}
