
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.FrankoVA.Sprint4.Task0.V28.Lib
{
    public class DataService : ISprint4Task0V28
    {
        public int GetMultEvenArrEl(int[] array)
        {
            int product = 1; 
            bool hasEven = false; 

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0) 
                {
                    product *= array[i]; 
                    hasEven = true; 
                }
            }

            return hasEven ? product : 0; 
        }
    }
}


