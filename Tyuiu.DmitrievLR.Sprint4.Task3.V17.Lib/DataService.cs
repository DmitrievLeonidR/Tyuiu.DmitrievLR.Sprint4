﻿using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.DmitrievLR.Sprint4.Task3.V17.Lib
{
    public class DataService : ISprint4Task3V17
    {
        public int Calculate(int[,] array)
        {
            // Сумма элементов в четвертом столбце
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                sum += array[i, 3];
            }

            return sum;
        }
    }
}