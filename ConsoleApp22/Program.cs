using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Вас приветствует программа суммирования чисел.");
            Console.WriteLine("Введите числа через пробел, которые хотите сложить:");
            string str = Console.ReadLine();
            int result = 0;
            int number = 0;
            for (int i = 0; i < str.Length; i++)
            {
                var click = str[i];
                if (click != ' ')
                {
                    int x = click - '0';
                    number = number * 10 + x;
                }
                else
                {
                    result += number;
                    number = 0;
                }
            }
            if (number > 0)
            {
                result += number;
            }
            Console.WriteLine(result);
        }
    }
}