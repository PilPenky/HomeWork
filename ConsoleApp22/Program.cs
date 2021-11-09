using System;

namespace ConsoleApp51
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] PhonBook = new string[5, 2]
            {
                {"Мама", "          +79581111111, mama@mail.ru"},
                {"Папа", "          +79582222222, papa@mail.ru"},
                {"Братишка", "      +79583333333, brat@mail.ru"},
                {"Сестренка", "     +79584444444, sister@mail.ru"},
                {"Друг", "          +79585555555, friend@mail.ru"},
            };
            Console.WriteLine("Имя:          Телефон, электронная почта:");
            Console.WriteLine(); //Красная строка
            for (var i = 0; i < PhonBook.GetLength(0); i++)
            {
                for (var x = 0; x < PhonBook.GetLength(1); x++)
                {
                    Console.Write(PhonBook[i, x]);
                }
                Console.WriteLine();
            }


        }
    }
}
