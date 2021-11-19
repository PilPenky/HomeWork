/*                                                  ЗАДАНИЕ К УРОКУ № 6
 *              Написать консольное приложение Task Manager, которое выводит на экран запущенные процессы и
 *                позволяет завершить указанный процесс. Предусмотреть возможность завершения процессов с
 *                                      помощью указания его ID или имени процесса. 
 */
using System;
using System.Diagnostics;
using System.Linq;
{
    var processes = Process.GetProcesses();
    foreach (var process in processes)
    {
        Console.WriteLine($"{nameof(Process.ProcessName)}: {process.ProcessName},");
        Console.WriteLine($"        {nameof(Process.Id)}:  {process.Id}");
        Console.WriteLine();
    }
    Console.WriteLine("Вас приветствует приложение Task Manager!");
    Console.WriteLine("Для завершения работы процесса Вам необходимо ввести имя или ID процесса из вышеуказанного списка.");
    Console.WriteLine();
    Console.WriteLine("Введите 1, чтобы завершить работу процесса по его названию.");
    Console.WriteLine("Введите 2, чтобы завершить работу процесса по его ID.");
    while (true)
    {
        switch (Console.ReadLine())
        {
            case "1":
                Console.WriteLine();
                Console.Write("Введите имя процесса: ");
                var name = Console.ReadLine();
                try
                {
                    int s = int.Parse(name);
                    processes.First(p => p.ProcessName.ToLower() == name.ToLower()).Kill(); // код на прием названия процесса
                    Console.WriteLine($"{name} удален.");
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Процесс {name} не найден."); // обработка исключений по не правельно введенному названия процесса
                    Console.WriteLine();
                    Console.WriteLine("Введите 1, чтобы завершить работу процесса по его названию.");
                    Console.WriteLine("Введите 2, чтобы завершить работу процесса по его ID.");
                    Console.WriteLine();
                }
                catch (InvalidOperationException)
                {
                    Console.WriteLine($"Процесс не найден!"); // обработка исключений по пустому вводу названия процесса
                    Console.WriteLine();
                    Console.WriteLine("Введите 1, чтобы завершить работу процесса по его названию.");
                    Console.WriteLine("Введите 2, чтобы завершить работу процесса по его ID.");
                    Console.WriteLine();
                }
                break;

            case "2":
                Console.WriteLine();
                Console.Write("Введите ID процесса: ");
                Console.WriteLine();
                var namecase2 = Console.ReadLine();
                try
                {
                    var y = int.Parse(namecase2); // код на прием ID процесса
                    var x = Process.GetProcessById(y);
                    x.Kill();
                    Console.WriteLine($"ID: {x} удален.");
                }
                catch (FormatException)
                {
                    Console.WriteLine($"ID {namecase2} не существует."); // обработка исключений по пустому вводу или буквенному вводу ID процесса
                    Console.WriteLine();
                    Console.WriteLine("Введите 1, чтобы завершить работу процесса по его названию.");
                    Console.WriteLine("Введите 2, чтобы завершить работу процесса по его ID.");
                    Console.WriteLine();
                }
                catch (System.ArgumentException)
                {
                    Console.WriteLine($"ID {namecase2} не существует."); // обработка исключений по не правельно введенному ID процесса
                    Console.WriteLine();
                    Console.WriteLine("Введите 1, чтобы завершить работу процесса по его названию.");
                    Console.WriteLine("Введите 2, чтобы завершить работу процесса по его ID.");
                    Console.WriteLine();
                }
                break;

            case "":
                Console.Write("Ошибка: Вы ввели пустое значение. Введите значение 1 или 2.");
                Console.WriteLine();
                break;

            default:
                Console.WriteLine("Ошибка: Вы ввели неверное значение. Введите значение 1 или 2.");
                Console.WriteLine();
                break;
        }
    }
}