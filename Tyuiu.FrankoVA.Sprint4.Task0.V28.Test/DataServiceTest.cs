using Tyuiu.FrankoVA.Sprint4.Task0.V28.Lib;
namespace Tyuiu.FrankoVA.Sprint4.Task0.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] numsArray = { 4, 0, 3, 0, 10 };
            int[] res = ds.GetMultEvenArrEl(numsArray);
            int[] numsWaitArray = { 40 }; 
            CollectionAssert.AreEqual(numsWaitArray, res);
        }
    }
}