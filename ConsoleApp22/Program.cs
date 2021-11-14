using System;

namespace ConsoleApp5
{
    class Program
    {
        public enum Season
        {
            Зима,
            Весна,
            Лето,
            Осень,
            Ошибка
        }
        static Season month_Number(int month)
        {
            switch (month)
            {
                case 1: return Season.Зима;
                case 2: return Season.Зима;
                case 3: return Season.Весна;
                case 4: return Season.Весна;
                case 5: return Season.Весна;
                case 6: return Season.Лето;
                case 7: return Season.Лето;
                case 8: return Season.Лето;
                case 9: return Season.Осень;
                case 10: return Season.Осень;
                case 11: return Season.Осень;
                case 12: return Season.Зима;
                default: return Season.Ошибка;
            }
        }
        private static string GetNameSesons(Season str)
        {
            switch (str)
            {
                case Season.Зима: return Convert.ToString(Season.Зима);
                case Season.Весна: return Convert.ToString(Season.Весна);
                case Season.Лето: return Convert.ToString(Season.Лето);
                case Season.Осень: return Convert.ToString(Season.Осень);
                default: return Convert.ToString(Season.Ошибка);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Введите порядковый номер месяца (1 - 12) ");
            string month = Console.ReadLine();
            int s = int.Parse(month);
            if (s > 12)
                Console.WriteLine("Ошибка: введите число от 1 до 12");
            else
                Console.WriteLine(GetNameSesons(month_Number(s)));
        }
    }
}