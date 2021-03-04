using System;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Программа генерирует равновероятно случайную строку строчных английских букв, длиной, введенной с клавиатуры.");
            Console.Write("введите длину сироки");
            int size = Convert.ToInt32(Console.ReadLine());
            Char[]A = new char[size];
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                A[i] = Convert.ToChar(rnd.Next(97, 122));
                Console.Write(A[i]);
            }
            Console.ReadLine();
        }
    }
}
