/*                                                                   Задание 1 к уроку 5
 *                                          Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.
 */
using System;
using System.IO;
using System.Text.Json;

namespace ConsoleApp11
{
    class Program
    {
        static void Main()
        {
            string json = JsonSerializer.Serialize(Console.ReadLine());
            File.WriteAllText("dataone.txt", json);
        }
    }
}
