using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.FrankoVA.Sprint4.Task3.V20.Lib
{

    public class DataService : ISprint4Task3V20
    {
        public int Calculate(int[,] array)
        {
            // Предполагаем, что массив уже инициализирован и имеет размер 5x5
            int minElement = array[0, 0]; // Инициализируем минимальный элемент первым элементом первого столбца

            for (int i = 0; i < array.GetLength(0); i++) // Проходим по всем строкам
            {
                if (array[i, 0] < minElement) // Сравниваем с текущим минимальным элементом
                {
                    minElement = array[i, 0]; // Обновляем минимальный элемент
                }
            }

            return minElement;
        }
    }
}    
