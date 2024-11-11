using Tyuiu.FrankoVA.Sprint4.Task6.V30.Lib;
namespace Tyuiu.FrankoVA.Sprint4.Task6.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var tree= new string[] { "Береза", "Дуб", "Клён", "Сосна", "Пихта", "Осина" };
            var res = ds.Calculate(tree);
            int wait = 1;
            Assert.AreEqual(wait, res.Length);
        }
    }
}