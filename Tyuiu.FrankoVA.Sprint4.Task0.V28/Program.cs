using Tyuiu.FrankoVA.Sprint4.Task0.V28.Lib;
namespace Tyuiu.FrankoVA.Sprint4.Task0.V28
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
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнила: Франко В.А. | ИБКСб-24-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать произведение   *");
            Console.WriteLine("* четных элементов массива.  {9, 8, 4, 6, 9, 4, 3, 6, 1, 2}               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int[] numsArray = { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 }; 

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < numsArray.Length; i++) 
            {
                Console.Write(numsArray[i] + " "); 
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            
            int product = ds.GetMultEvenArrEl(numsArray);
            Console.WriteLine($"Произведение четных элементов: {product}");
            Console.ReadKey();
        }
    }
}
