
using Tyuiu.SosninFM.Sprint3.Task7.V20.Lib;

namespace Tyuiu.SosninFM.Sprint3.Task7.V20;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнил: Соснин Ф. М. | АСОиУб-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #20                                                             *");
        Console.WriteLine("* Выполнил: Соснин Фёдор Михайлович | АСОиУб-24-1                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("* вычисляет, и печатает результат на экране                               *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int startValue = -5;
        int endValue = 5;

        Console.WriteLine("Старт шага = " + startValue);
        Console.WriteLine("Конец шага = " + endValue);
        int len = ds.GetMassFunction(startValue, endValue).Length;

        double[] valueArray;
        valueArray = new double[len];

        valueArray = ds.GetMassFunction(startValue,endValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("+--------+--------+");
        Console.WriteLine("|   x    |  f(x)  |");
        Console.WriteLine("+--------+--------+");

        for (int i = 0; i < len; i++)
        {
            Console.WriteLine("|{0,5:d}   | {1, 5:f2}   |", startValue, valueArray[i]);
            startValue++;
        }
        Console.WriteLine("+--------+--------+");
        Console.ReadKey();


    }
}
