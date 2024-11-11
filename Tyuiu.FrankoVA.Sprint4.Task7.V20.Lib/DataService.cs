using System.Data;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.FrankoVA.Sprint4.Task7.V20.Lib
{
    public class DataService : ISprint4Task7V20
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] mtrx = new int[n, m];
            int product = 1; // Переменная для произведения четных чисел
            bool hasEven = false; // Флаг, указывающий на наличие четных чисел

            // Заполнение матрицы из строки
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                   
                    mtrx[i, j] = int.Parse(value.Substring(i * m + j, 1));

                    
                    if (mtrx[i, j] % 2 == 0)
                    {
                        product *= mtrx[i, j];
                        hasEven = true;
                    }
                }
            }

            
            return hasEven ? product : 0;
        }
    }
}
