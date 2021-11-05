using System;

namespace ConsoleApp45
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Для определения четности числа введите его значение.");
            int a;
            a = int.Parse(Console.ReadLine());
            int temp = a % 2;
            bool result = temp == 0;
            if (result)
                Console.WriteLine("Чётное число");
            else
                Console.WriteLine("Нечётное число");
        }
    }
}
