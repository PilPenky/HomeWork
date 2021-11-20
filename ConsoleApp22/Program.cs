/*                                                                        ЗАДАНИЕ К УРОКУ № 7
 *                                           Написать любое приложение, произвести его сборку с помощью MSBuild, осуществить
 *                                      декомпиляцию с помощью dotPeek, внести правки в программный код и пересобрать приложение.
 */
using System;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 77;
            Console.WriteLine(a);
            string secret = "some secret password";
            Console.WriteLine("Enter password:");
            string input = Console.ReadLine();
            if (input == secret)
            {
                Console.WriteLine("Welcome!");
            }
            /* К домашнему заданию я прикрепил word-файл со скриншотами.
              
               1. Для компиляции через MSBuild: захожу во встроенный терминал VS-2019 (ctrl + `), ввожу команду "dotnet build".
               2. Копирую путь с компилированной программой (C:\Users\Asus\source\repos\ConsoleApp20\ConsoleApp20\bin\Debug\netcoreapp3.1\ConsoleApp20.dll) и через "Мой компьютер" ввожу путь.
               3. Поскольку в JetBrains dotPeek нельзя редактировать код, экспортирую сборку в VS. Для этого кликаю ПКМ по сборке ConsoleApp20 и выбираю Export to Project.
               4. Вношу правки: var a = 77; Console.WriteLine(a);
               5. Пересобераю приложение через MSBuild.
               6. Иду в путь сборки, вижу, что проект собран.
               7. Проверяю работу приложения через системный терминал Windows. Приложение работает. Готово!
            */
        }
    }
}