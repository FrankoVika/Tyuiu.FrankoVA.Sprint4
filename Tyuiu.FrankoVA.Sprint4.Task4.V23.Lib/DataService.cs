using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.FrankoVA.Sprint4.Task4.V23.Lib
{
    public class DataService : ISprint4Task4V23
    {
        public int Calculate(int[,] array)
        {
            int sumArray = 0;

            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (array[i, j] % 2 != 0) 
                    {
                        sumArray += array[i, j];
                    }
                }
            }
            return sumArray;
        }
    }
}

