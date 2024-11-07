using Tyuiu.FrankoVA.Sprint4.Task3.V20.Lib;
namespace Tyuiu.FrankoVA.Sprint4.Task3.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #0| Выполнила: Франко В.А. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнила: Франко В.А. | ИБКСб-24-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 3 до 8. Найдите минимальный      *");
            Console.WriteLine("*  элемент в первом столбце массива.                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int[,] array = new int[5, 5] { {8, 7, 7, 8, 5},
                                          {4, 3, 5, 3, 6},
                                          {5, 3, 8, 6, 3},
                                          {6, 3, 8, 5, 4},
                                          {3, 6, 8, 3, 4} };


            Console.WriteLine("Двумерный массив:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "t");
                }
                Console.WriteLine();
            }

            // Находим минимальный элемент в первом столбце
            int minElement =  FindMinInFirstColumn(array);
        }

        // Метод для нахождения минимального элемента в первом столбце
        static int FindMinInFirstColumn(int[,] array)
        {
            int minElement = array[0, 0]; // Инициализируем минимальный элемент первым элементом первого столбца

            for (int i = 1; i < array.GetLength(0); i++) // Начинаем с первой строки
            {
                if (array[i, 0] < minElement) // Сравниваем с текущим минимальным элементом
                {
                    minElement = array[i, 0]; // Обновляем минимальный элемент
                }
            }
            Console.WriteLine($"Минимальный элемент в первом столбце: {minElement}");
            return minElement; // Возвращаем найденный минимальный элемент



          
        }
    }
}
