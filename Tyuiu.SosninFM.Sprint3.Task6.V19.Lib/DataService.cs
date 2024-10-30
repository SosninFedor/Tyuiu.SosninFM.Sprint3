
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SosninFM.Sprint3.Task6.V19.Lib
{
    public class DataService : ISprint3Task6V19
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            // Напишите программу, которая ищет среди целых чисел, принадлежащих числовому отрезку [10, 15]
            // количество всех делителей меньше 8

            int x;
            int sum = 0;
            for (x = startValue; x <= stopValue; x++)
            {
                for ( int a = 1; a <= x; a++)
                {
                    if (x % a == 0)
                    {
                        if (a < 8)
                        {
                            sum++;
                        }
                    }
                }
            }
            return sum;


        }
    }
}
