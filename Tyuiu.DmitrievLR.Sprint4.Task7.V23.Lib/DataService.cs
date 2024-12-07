using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.DmitrievLR.Sprint4.Task7.V23.Lib
{
    public class DataService : ISprint4Task7V23
    {
        public int Calculate(int rows, int cols, string value)
        {

            int[,] matrix = new int[rows, cols];

            // Преобразование строки в матрицу
            int count = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (count < value.Length)
                    {
                        matrix[i, j] = int.Parse(value[count].ToString());
                        count++;
                    }
                }
            }

            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        sum++;
                    }
                }
            }

            return sum;
        }
    }
}
