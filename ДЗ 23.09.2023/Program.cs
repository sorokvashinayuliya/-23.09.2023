using System;
using System.Globalization;
namespace ДЗ_23._09._2023

{
    internal class Тумаков
    {
        static void Main(string[] args)
        {
            DateTime dt = Convert.ToDateTime("01.01.1900");
            Console.WriteLine("Введите дату");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите год");
            int year = Convert.ToInt32(Console.ReadLine());
            if (num < 1 || num > 365)
            {
                Console.WriteLine("Столько дней не бывает!");
            }
            if (year % 4 == 0 || year % 400 == 0 & year % 100 != 0)
            {
                if (num < 59)
                {
                    dt = dt.AddDays(num - 1);
                    Console.WriteLine(dt.ToString("d MMMM", CultureInfo.CreateSpecificCulture("ru-RU")));
                }
                if (num>59)
                {
                    dt = dt.AddDays(num);
                    Console.WriteLine(dt.ToString("d MMMM", CultureInfo.CreateSpecificCulture("ru-RU")));
                }
                if (num == 59)
                {
                    Console.WriteLine("29 февраля");
                }
                Console.WriteLine("Год високосный");
            }
            else
            {
                dt = dt.AddDays(num - 1);
                Console.WriteLine(dt.ToString("d MMMM", CultureInfo.CreateSpecificCulture("ru-RU")));
                Console.WriteLine("Год не високосный");
            }

        }

    }
}
