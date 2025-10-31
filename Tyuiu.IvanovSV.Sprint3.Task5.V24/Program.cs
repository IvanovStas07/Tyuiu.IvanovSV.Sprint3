using Tyuiu.IvanovSV.Sprint3.Task5.V24.Lib;

namespace Tyuiu.IvanovSV.Sprint3.Task5.V24
{
    internal class Program
    {
        static void Main(string[] args)
            {
                DataService ds = new DataService();

                Console.Title = "Спринт #3 | Выполнил Иванов С. В. | ИСТНб-25-1";
                Console.WriteLine("****************************************************************************");
                Console.WriteLine("* Спринт #3                                                                *");
                Console.WriteLine("* Задание #5                                                               *");
                Console.WriteLine("* Вариант #24                                                              *");
                Console.WriteLine("* Выполнил: Выполнил Иванов С. В. | ИСТНб-25-1                             *");
                Console.WriteLine("****************************************************************************");
                Console.WriteLine("* УСЛОВИЕ:                                                                 *");
                Console.WriteLine("* Написать программу из операций сравнений и арифметических выражений,     *");
                Console.WriteLine("* которая вернет логическую последовательность(массив),                    *");
                Console.WriteLine("* при x = 5105, y = 475                                                    *");
                Console.WriteLine("****************************************************************************");
                Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
                Console.WriteLine("****************************************************************************");
                Console.WriteLine("");


                Console.WriteLine();
                Console.WriteLine("****************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
                Console.WriteLine("****************************************************************************");
                Console.WriteLine(ds.GetSumSumSeries(2, 1, 3, 1, 12));

                Console.ReadKey();
            }
        }
}