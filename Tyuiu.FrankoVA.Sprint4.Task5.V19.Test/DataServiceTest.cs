using Tyuiu.FrankoVA.Sprint4.Task5.V19.Lib;
namespace Tyuiu.FrankoVA.Sprint4.Task5.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { {-2, -1, 0, 2, 3},
                                          {-2, -1, 0, 2, 3},
                                          {-2, -1, 0, 2, 3},
                                          {-2, -1, 0, 2, 3},
                                          {-2, -1, 0, 2, 3}
            };
            int res = ds.Calculate(mas2);
            int wait = 10;
            Assert.AreEqual(wait, res);
        }
    }
}