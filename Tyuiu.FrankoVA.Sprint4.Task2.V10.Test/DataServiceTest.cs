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

            int[] numsArray = { 1, 5, 3, 3, 5, 4, 4, 2, 6, 4, 2, 3, 1 };
            int res = ds.Calculate(numsArray);
            int wait = 21;
            Assert.AreEqual(wait, res);
        }
    }
}