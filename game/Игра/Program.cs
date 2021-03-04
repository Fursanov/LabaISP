using System;


namespace Игра
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            int size = 4;
            int bul = 0;
            int cow = 0;
            int attemp = 0;
            System.Text.StringBuilder iskomoe_chislo = new System.Text.StringBuilder(4);
            System.Text.StringBuilder iskomoe_chislo1 = new System.Text.StringBuilder(4);
            System.Text.StringBuilder wwedennoe_chislo = new System.Text.StringBuilder(4);
            Random rnd = new Random();
            Console.Write("Приветствую вас! Это игра угадай число. Компьютер загадывает 4х значное число,\nно при желании можно сделать и больше, и каждый ход вы пытаетесь его угадать.\nВ конце каждого хода вам говориться сколько цифр числа вы угадали на своих\nпозициях, и сколько стоящих на другой позиции, всё просто. Задача угадать число за минимальное количество попыток. Удачной игры!");
            for (int i = 0; i < size; i++)
                iskomoe_chislo.Insert(i, Convert.ToChar(rnd.Next(48, 57)));
            while (bul != 4)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("\nпопробуйте угадать число");
                iskomoe_chislo1.Clear();
                iskomoe_chislo1.Insert(0,iskomoe_chislo);
                wwedennoe_chislo.Clear();
                bul = 0; cow = 0;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n");                             ///////////////////////////////////////////////////
                string str = Console.ReadLine();                                     //                           //
                Console.ForegroundColor = ConsoleColor.Green;                        //                           //
                int num;                                                             //                           //
                bool isNum = int.TryParse(str, out num);                             //                           //
                if (isNum && str.Length == size)                                     //данный кусок кода отвечает //
                    wwedennoe_chislo.Insert(0, str);                                 //за корректный ввод данныъх //
                else                                                                 //                           //
                {                                                                    //                           //
                    Console.Write("некорректно введено число, попробуйте еще раз");  //                           //
                    continue;                                                        //                           //
                }                                                ///////////////////////////////////////////////////
                for (int i = 0; i < size - bul; i++)                  
                    if (iskomoe_chislo1[i] == wwedennoe_chislo[i])        // чтобы не было проблем с повторяющимися цифрами
                    {                                                     // в каждом из двух циклов for при нахождении совподений
                        bul++;                                            // удаляем данные цифры из обеих строк
                        iskomoe_chislo1.Remove(i, 1);                     // для этого нам и нужна строка iskomoe_chislo1
                        wwedennoe_chislo.Remove(i, 1);                    // которая стирается, и с каждой новой итерацией 
                        i = -1;                                           // снова восстанавливается с помощью строки iskomoe_chislo
                    }
                for (int i = 0; i < size - bul - cow; i++)
                    for (int j = 0; j < size - bul - cow; j++)
                    {
                        if (iskomoe_chislo1[j] == wwedennoe_chislo[i])
                        {
                            cow++;
                            iskomoe_chislo1.Remove(j, 1);
                            wwedennoe_chislo.Remove(i, 1);
                            j = -1; i = 0;
                        }
                    }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("вы угадали цифр с правильной позицией: " + bul + "\nвы угадли цифр с неправильной позицией: " + cow + "\n");
                Console.ForegroundColor = ConsoleColor.Green;
                attemp++;            
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nПоздравляю, вы нашли загаданное число!!!\nКоличество попыток: " + (attemp - 1));
           Console.ReadLine();
        }
    }
}
