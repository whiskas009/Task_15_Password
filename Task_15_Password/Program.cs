using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_15_Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Придумайте пароль: ");
            string setPassword = Console.ReadLine();
            int attempts = 3;

            for (int i = attempts; i >= 0; i--)
            {
                Console.WriteLine("Введите пароль: ");
                string enterPassword = Console.ReadLine();
                if (enterPassword == setPassword)
                {
                    Console.WriteLine("Пароль введён верно!");
                    break;
                }
                else if (i == 0)
                {
                    Console.WriteLine($"Вы ввели пароль неверно {attempts} раза. Программа завершена!");
                    break;
                }
                
                Console.WriteLine($"Неверный пароль! Осталось {i} попытки");
            }

        }
    }
}
