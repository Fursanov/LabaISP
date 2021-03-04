using System;

namespace Задание_3
{
    class Program
    {
        static void Swap (System.Text.StringBuilder str, int a,int b)
        {
            char c = str[a];
            str[a] = str[b];
            str[b] = c;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("программа перемешивает символы введённой строки.\nВведите начальную строку:");
            Random rnd = new Random();
            System.Text.StringBuilder str = new System.Text.StringBuilder();
            str.AppendFormat(Console.ReadLine());
            for (int i = 0; i < str.Length; i++)
                Swap(str,i,rnd.Next(0, str.Length-1));
            Console.WriteLine(str);
        }
    }
}
