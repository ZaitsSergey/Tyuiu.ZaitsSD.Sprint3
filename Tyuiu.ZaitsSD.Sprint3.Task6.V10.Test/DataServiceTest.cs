using Tyuiu.ZaitsSD.Sprint3.Task6.V10.Lib;
namespace Tyuiu.ZaitsSD.Sprint3.Task6.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void SummaDeliteliNum()
        {
            int res = ds.GetSumTheDivisors(20, 32);
            int res_wait = 396;
            Assert.AreEqual(res_wait, res);
        }
    }
}
