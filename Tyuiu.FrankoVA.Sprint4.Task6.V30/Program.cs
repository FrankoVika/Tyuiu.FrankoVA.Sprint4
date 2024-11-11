using Tyuiu.FrankoVA.Sprint4.Task6.V30.Lib;
namespace Tyuiu.FrankoVA.Sprint4.Task6.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #0| Выполнила: Франко В.А. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнила: Франко В.А. | ИБКСб-24-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [Береза, Дуб, Клён, Сосна, Пихта,           *");
            Console.WriteLine("* Осина], используя класс Array, выведите элементы массива, длина         *");
            Console.WriteLine("* которых больше 5 символов.                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            var tree = new string[] { "Береза", "Дуб", "Клён", "Сосна", "Пихта", "Осина" };
            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < tree.Length; i++)
            {
                Console.WriteLine(tree[i]);
            }



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("Количество элементов больше 5: ");
            var nums = ds.Calculate(tree);
            Console.WriteLine(nums.Length);
            Console.ReadKey();
        }
    }
}
