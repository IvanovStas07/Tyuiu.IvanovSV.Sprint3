using Tyuiu.IvanovSV.Sprint3.Task4.V5.Lib;
namespace Tyuiu.IvanovSV.Sprint3.Task4.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
           
            Console.Title = "Спринт #3 | Выполнил: Иванов С. В. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Иванов С. В. | ИСТНб-25-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* x = 2, 1 <= i <= 3, 1 <= k <= 10                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            int x = 2, start1 = 1, end1 = 3, start2 = 1, end2 = 10;
            Console.Write("Сумма сумм ряда равна " + ds.GetSumSumSeries(x, start1, start2, end1, end2));
            Console.ReadLine();
        }
    }
}