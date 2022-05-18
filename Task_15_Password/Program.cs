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
            int attempts = 4;

            while (attempts != 0)
            {
                Console.WriteLine("Введите пароль: ");
                string enterPassword = Console.ReadLine();
                if (enterPassword == setPassword)
                {
                    Console.WriteLine("Пароль введён верно!");
                }
                else
                {
                    attempts--;
                    Console.WriteLine($"Неверный пароль! Осталось {attempts} попытки");
                }
            }

            Console.WriteLine("Вы ввели пароль неверно 3 раза. Программа завершена!");
        }
    }
}
