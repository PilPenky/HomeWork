using System;
using System.IO;
using System.Text.Json;
using Microsoft.Extensions.Configuration;

namespace ConsoleApp26
{
    class MyOption
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Profession { get; set; }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var options = configuration.Get<MyOption>();
            string age = "";
            if (options.Age == 0)
            {
                age = "лет";
            }
            if (options.Age == 1)
            {
                age = "год";
            }
            if (options.Age >= 2)
            {
                age = "года";
            }
            if (options.Age >= 5)
            {
                age = "лет";
            }
            Console.WriteLine($"Здравствуй {options.Name}. Я помню, что тебе {options.Age} {age} и то, что ты по профессии {options.Profession}. Я всё о тебе помню... живи с этим.");
            Console.WriteLine();
            Console.WriteLine("Хотите изменить данные о себе? (да/нет)");

            while (true)
            {
                switch (Console.ReadLine())
                {
                    case "да":
                        Console.WriteLine("Введите Ваше имя:");
                        options.Name = Console.ReadLine();
                        Console.WriteLine();
                        File.WriteAllText("appsettings.json", JsonSerializer.Serialize(options));

                        try
                        {
                            Console.WriteLine("Введите Ваш возраст:");
                            var x = Console.ReadLine();
                            options.Age = int.Parse(x);
                            Console.WriteLine();
                            File.WriteAllText("appsettings.json", JsonSerializer.Serialize(options));
                        }
                        catch (System.FormatException)
                        {
                        }

                        Console.WriteLine("Введите Вашу профессию:");
                        options.Profession = Console.ReadLine();
                        Console.WriteLine();
                        File.WriteAllText("appsettings.json", JsonSerializer.Serialize(options));

                        Console.WriteLine("Данные успешно изменены");
                        Console.WriteLine("Нажмите Enter чтобы закрыть приложение");
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;

                    case "нет":
                        Console.WriteLine("Досвидания. Нажмите Enter чтобы закрыть приложение");
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;

                    case "":
                        Console.Write("Ошибка: Вы ввели пустое значение. Введите 'да' или 'нет'");
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine("Ошибка: Вы ввели неверное значение. Введите 'да' или 'нет'");
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
