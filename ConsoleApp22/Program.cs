/*                                                                        Задание 3 к уроку 5
 *                                           Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл.
 */
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace HelloWorld
{
    /// <summary>
    /// Здание
    /// </summary>
    [Serializable]
    public class Building
    {
    }

    namespace ConsoleApp11
    {
        class Program
        {
            static void Main()
            {
                Console.WriteLine("Введите произвольный набор чисел от 0 до 255)");
                BinaryFormatter numbers = new BinaryFormatter();
                numbers.Serialize(new FileStream("numbers.bin", FileMode.OpenOrCreate), Console.ReadLine());
            }
        }
    }
}
