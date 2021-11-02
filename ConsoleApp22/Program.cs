using System;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Ваше имя.");
            string name = Console.ReadLine();
            DateTime dt = DateTime.Now;
            Console.WriteLine($"Приветствую Вас, {name}! Сегодня {DateTime.Now.ToShortDateString()}, время {dt.ToString("HH:mm")}.");
        }
    }
}
