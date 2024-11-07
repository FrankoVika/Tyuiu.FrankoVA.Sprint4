using Tyuiu.FrankoVA.Sprint4.Task2.V10.Lib;
namespace Tyuiu.FrankoVA.Sprint4.Task2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] numsArray = { 4, 6, 1, 1, 6, 1, 6, 4, 4, 6, 3, 5, 4 };
            int res = ds.Calculate(numsArray);
            int wait = 15;
            Assert.AreEqual(wait, res);
        }
    }
}