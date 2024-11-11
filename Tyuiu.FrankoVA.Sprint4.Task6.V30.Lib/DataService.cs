﻿using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.FrankoVA.Sprint4.Task6.V30.Lib
{
    public class DataService : ISprint4Task6V30
    {
        public string[] Calculate(string[] array)
        {
            string[] mas = Array.FindAll(array, tree => tree.Length > 5);
            return mas;
        }
    }
}
