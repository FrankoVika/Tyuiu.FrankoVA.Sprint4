using System.Runtime.ConstrainedExecution;
using Tyuiu.FrankoVA.Sprint4.Task7.V20.Lib;
namespace Tyuiu.FrankoVA.Sprint4.Task7.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int n = 3;
            int m = 5;
            int[,] mtrx = new int[n, m];
            string str = "357951248632587";
            int res = ds.Calculate(n, m, str);
            int wait = 6144;
            Assert.AreEqual(wait, res);
        }
    }
}