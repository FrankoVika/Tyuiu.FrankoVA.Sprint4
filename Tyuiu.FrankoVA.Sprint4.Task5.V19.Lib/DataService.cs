﻿using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.FrankoVA.Sprint4.Task5.V19.Lib
{
    public class DataService : ISprint4Task5V19
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0)+1;
            int columns = matrix.GetLength(1);

            int count = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
