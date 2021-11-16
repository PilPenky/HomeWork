/*                                                                        Задание 2 к уроку 5
 *                                           Написать программу, которая при старте дописывает текущее время в файл «startup.txt».
 */
using System;
using System.IO;
using System.Text.Json;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "startup.txt";
            DateTime dt = DateTime.Now;
            File.AppendAllLines(filename, new[] { dt.ToString("HH:mm") }); //Использовал метод File.AppendAllLines, чтобы время в файле выводилось через строку
        }
    }
}
