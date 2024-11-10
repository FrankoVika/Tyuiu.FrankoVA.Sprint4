using Tyuiu.FrankoVA.Sprint4.Task4.V23.Lib;
namespace Tyuiu.FrankoVA.Sprint4.Task4.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #0| Выполнила: Франко В.А. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнила: Франко В.А. | ИБКСб-24-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 3 до 8. Найдите сумму            *");
            Console.WriteLine("* нечетных элементов массива.                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int[,] mas2 = new int[5, 5] { {8, 7, 5, 8, 7},
                                          {8, 3, 3, 6, 4},
                                          {4, 4, 5, 5, 4},
                                          {3, 4, 7, 7, 3},
                                          {6, 8, 3, 6, 7} };


            Console.WriteLine("Двумерный массив:");
            for (int i = 0; i < mas2.GetLength(0); i++)
            {
                for (int j = 0; j < mas2.GetLength(1); j++)
                {
                    Console.Write(mas2[i, j] + "\t"); 
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int sumOdd = ds.Calculate(mas2);
            Console.WriteLine("Сумма нечетных элементов: " + sumOdd);
            Console.ReadKey();
        }

       
    }
}

