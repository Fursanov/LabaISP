using System;

namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа рассчитывает максимальную степень двойки,\nна которую делится произведение подряд идущих чисел от a до b");
            Console.WriteLine("введите число a:");
            long first = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("введите число b:");
            long  last = Convert.ToInt64(Console.ReadLine());
            long counter = 0;
            if (first % 2 == 1) first++;
            for (long i = first; i <= last; i += 2)
                for (long j = i; j % 2 == 0; j /= 2, counter++) ;
            Console.WriteLine("максимальная степень равна: "+counter);
            Console.ReadLine();
        }
    }
}