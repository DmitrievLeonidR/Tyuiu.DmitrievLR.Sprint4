using Tyuiu.DmitrievLR.Sprint4.Task3.V17.Lib;
namespace Tyuiu.DmitrievLR.Sprint4.Task3.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Дмитриев Леонид Романович | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Дмитриев Леонид Романович | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*                                                                         *");

            int[,] mass = {
            { 6, 4, 2, 2, 1 },
            { 3, 6, 5, 4, 1 },
            { 5, 2, 3, 1, 6 },
            { 8, 8, 4, 5, 3 },
            { 7, 4, 5, 1, 6 }
        };

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            var result = ds.Calculate(mass);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}