using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.DmitrievLR.Sprint4.Task1.V16.Lib
{
    public class DataService : ISprint4Task1V16
    {
        public int Calculate(int[] array)
        {
            int res = 1;
            for (int i = 0; i < 13; i++)
            {
                if (array[i] % 2 != 0)
                {
                    res *= array[i];
                }
            }
             
            return res;
        }
    }
}
