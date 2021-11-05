using System;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Для вычисления среднесуточной температуры воздуха выполните слудующие действия:");
            Console.WriteLine("1. Введите минимальное значение температуры за сутки в °C");
            string input = Console.ReadLine();
            int x = int.Parse(input);
            Console.WriteLine("2. Введите максимальное значение температуры за сутки в °C");
            string input1 = Console.ReadLine();
            int y = int.Parse(input1);
            Console.WriteLine($"Среднесуточная температуры воздуха составляет {(y + x) / 2}°C");
        }
    }
}
