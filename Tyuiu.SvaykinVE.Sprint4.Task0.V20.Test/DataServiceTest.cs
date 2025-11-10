using Tyuiu.SvaykinVE.Sprint4.Task0.V20.Lib;
namespace Tyuiu.SvaykinVE.Sprint4.Task0.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] a = { 4, 8, 7, 6, 5, 8, 2, 4, 3, 2 };
            var res = ds.GetMultEvenArrEl(a);
            Assert.AreEqual(24576, res);
        }
    }
}
