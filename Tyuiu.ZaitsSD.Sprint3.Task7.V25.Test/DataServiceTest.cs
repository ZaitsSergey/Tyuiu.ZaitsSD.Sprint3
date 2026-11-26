using Tyuiu.ZaitsSD.Sprint3.Task7.V25.Lib;
namespace Tyuiu.ZaitsSD.Sprint3.Task7.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void FuncTest()
        {
            int startVal = -1;
            int stopVal = 1;
            double[] res = ds.GetMassFunction(startVal, stopVal);
            double[] wait_res = {-3.98, 1.0, 0.02 };
            CollectionAssert.AreEqual(res, wait_res);
        }
    }
}
