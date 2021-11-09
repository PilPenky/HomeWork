using System;

namespace ConsoleApp53
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует программа зеркального отображения.");
            Console.WriteLine();
            Console.WriteLine("Для зеркального отображения Вам нужно будет ввести любое слово или любую фразу.");
            Console.WriteLine("Нажмите Enter для продолжения.");
            string str = Console.ReadLine();
            {
                if (str == "")
                    do
                    {
                        Console.WriteLine("Введите слово или фразу.");
                    } while (str == Console.ReadLine());
                Console.WriteLine("Введите значение еще раз.");
                str = Console.ReadLine();
                Console.WriteLine("А пока программа думает, вот Вам смайлик");
                Console.WriteLine("                  =)");
                Console.WriteLine();
                Console.WriteLine("Нажмите Enter чтобы показать результат");
                Console.ReadLine();
            }
            char[] x = str.ToCharArray();
            str = "";
            for (var i = x.Length - 1; i >= 0; i--)
            {
                str += x[i];
            }
            Console.WriteLine("Ииииии Вуа-Ля:");
            Console.WriteLine(str);


        }
    }
}
