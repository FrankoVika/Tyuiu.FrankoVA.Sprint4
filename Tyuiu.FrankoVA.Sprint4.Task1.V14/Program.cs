using Tyuiu.FrankoVA.Sprint4.Task1.V14.Lib;
namespace Tyuiu.FrankoVA.Sprint4.Task1.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #0| Выполнила: Франко В.А. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнила: Франко В.А. | ИБКСб-24-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 13 элементов заполненный         *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 1 до 8 подсчитать сумму нечетных *");
            Console.WriteLine("* элементов массива.  С клавиатуры: 1, 5, 3, 6, 5, 4, 8, 6, 8, 4, 2, 3, 1 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            const int len = 13; // Задаем фиксированную длину массива
            int[] numsArray = new int[len];

            for (int i = 0; i < len; i++)
            {
                Console.Write($"{i + 1}: ");
                numsArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("nВведенный массив:");
            for (int i = 0; i < len; i++)
            {
                Console.Write(numsArray[i] + "t");
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
                       
            int res = ds.Calculate(numsArray);
            Console.WriteLine("Сумма нечетных элементов: {res}");
            Console.ReadKey();
        }
    }
}
