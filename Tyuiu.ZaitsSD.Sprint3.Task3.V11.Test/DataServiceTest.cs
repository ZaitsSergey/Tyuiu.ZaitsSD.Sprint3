using Tyuiu.ZaitsSD.Sprint3.Task3.V11.Lib;
namespace Tyuiu.ZaitsSD.Sprint3.Task3.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void CheckReplacement()
        {
            string res = ds.ReplaceCharOnNum("sqwreq vqwqq q", 'q', '7');
            string res_wait = "s7wre7 v7w77 7";
            Assert.AreEqual(res_wait, res);
        }
    }
}
