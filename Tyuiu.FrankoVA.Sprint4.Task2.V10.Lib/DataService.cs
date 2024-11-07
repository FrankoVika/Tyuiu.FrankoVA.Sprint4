using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.FrankoVA.Sprint4.Task2.V10.Lib
{
    public class DataService : ISprint4Task2V10
    {
        public int Calculate(int[] array)
        {
            int sumArray = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] % 2 != 0) // Проверка на нечетность
                {
                    sumArray *= array[i];
                }
            }
            return sumArray;
        }
    }
}
