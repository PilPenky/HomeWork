using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string GetFullName(string firstName, string lastName, string patronymic)
            {
                if (firstName != null)
                {
                    return firstName;
                }
                else
                if (lastName != null)
                {
                    return lastName;
                }
                else
                {
                    return patronymic;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Введите фамилию: ");
                string firstName1 = Console.ReadLine();
                Console.Write("Введите имя: ");
                string lastName1 = Console.ReadLine();
                Console.Write("Введите отчество: ");
                string patronymic1 = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine($"{GetFullName(firstName1, null, null)} {GetFullName(null, lastName1, null)} {GetFullName(null, null, patronymic1)}");
                Console.WriteLine();

            }


        }
    }
}