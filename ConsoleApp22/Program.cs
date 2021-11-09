using System;

namespace ConsoleApp51
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[5, 5];
            array[0, 0] = 5;
            array[1, 1] = 5;
            array[2, 2] = 5;
            array[3, 3] = 5;
            array[4, 4] = 5;
            for (var i = 0; i < array.GetLength(0); i++)
            {
                for (var x = 0; x < array.GetLength(1); x++)
                {
                    Console.Write($"{array[i, x]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
