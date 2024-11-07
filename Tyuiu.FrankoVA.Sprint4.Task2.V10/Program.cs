using Tyuiu.FrankoVA.Sprint4.Task2.V10.Lib;
namespace Tyuiu.FrankoVA.Sprint4.Task2.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #0| Выполнила: Франко В.А. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнила: Франко В.А. | ИБКСб-24-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 13 элементов заполненный         *");
            Console.WriteLine("* случайными в диапазоне от 1 до 6 подсчитать произведение нечетных       *");
            Console.WriteLine("* элементов массива.                                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            Random rnd = new Random(); 
            const int len = 13; // Задаем фиксированную длину массива
            int[] numsArray = new int[len];
            for (int i = 0; i < len; i++)
            {
                numsArray[i] = rnd.Next(1, 6);
            }
                        
            Console.WriteLine("Введенный массив:");
            for (int i = 0; i < len; i++)
            {
                Console.Write(numsArray[i] + "t");
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(numsArray);
            Console.WriteLine("Сумма нечетных элементов:" +res);
            Console.ReadKey();
        }
    }
}
