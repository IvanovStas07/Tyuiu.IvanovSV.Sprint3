using Tyuiu.IvanovSV.Sprint3.Task1.V11.Lib;
namespace Tyuiu.IvanovSV.Sprint3.Task1.V11

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Иванов С. В. | ИСТНб-25-1";
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Иванов С. В. | ИСТНб-25-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:   Написать программу используя цикл while, которая вычисляет   *");

            Console.WriteLine("* произведение ряда по формуле, при a=0,75                                 *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
          
            Console.WriteLine(" a = 0,75                                                                         *");
            Console.WriteLine("***************************************************************************");


            double a = 8;
            int startValue = 3;
            int endValue = 10;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            var result = ds.GetMultiplySeries(a, startValue, endValue);

            Console.WriteLine($"Произведение ряда для a={a}, от {startValue} до {endValue} равно: {result}");
            Console.ReadKey();
        }
    }
}