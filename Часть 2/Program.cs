using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Часть_2
{
    internal class Program
    {
        public static int i;

        static string TrueTrim(string input)
        {
            return Regex.Replace(input.Trim(), " +", " ");
        }
        enum Week
        {
            Monday=1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Дана последовательность из 10 чисел. Определить, является ли эта последовательность упорядоченной по возрастанию.");
            Random r = new Random();
            bool flag = true;
            int[] array = new int[10];
            int i = 0;
            do
            {
                array[i] = int.Parse(r.Next(10, 100) + "10000");
                Console.Write(array[i] + " ");
                if (i > 0 && array[i] < array[i - 1])
                {
                    flag = false;
                    break;
                }
            } while (i++ < 9);
            Console.WriteLine("Введите строку:");
            switch (TrueTrim(Console.ReadLine()).ToLower())
            {
                case "jabroni": Console.WriteLine("Patron Tequila"); break;
                case "school counselor": Console.WriteLine("Anything with Alcohol"); break;
                case "programmer": Console.WriteLine("Hipster Craft Beer"); break;
                case "bike gang member": Console.WriteLine("Moonshine"); break;
                case "politician": Console.WriteLine("Your tax dollars"); break;
                case "rapper": Console.WriteLine("Cristal"); break;
                default: Console.WriteLine("Beer"); break;
            }
            Console.WriteLine("Составить программу, которая в зависимости от порядкового номера дня недели (1, 2,...,7) выводит на экран его название (понедельник, вторник, ..., воскресенье).");
            Console.WriteLine("Введите номер дня недели");
            Week week = (Week)Convert.ToInt32(Console.ReadLine());
            switch (week)
            {
                case Week.Monday:
                    Console.WriteLine("Понедельник");
                    break;
                case Week.Tuesday:
                    Console.WriteLine("Вторник");
                    break;
                case Week.Wednesday:
                    Console.WriteLine("Среда");
                    break;
                case Week.Thursday:
                    Console.WriteLine("Понедельник");
                    break;
                case Week.Friday:
                    Console.WriteLine("Пятница");
                    break;
                case Week.Saturday:
                    Console.WriteLine("Суббота");
                    break;
                case Week.Sunday:
                    Console.WriteLine("Воскресенье");
                    break;
            }
            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите число от 6 до 14");
            byte cards;
            try
            {
                while (!byte.TryParse(Console.ReadLine(), out cards))
                {
                    throw new Exception();
                }
                switch (cards)
                {
                    case 6:
                        {
                            Console.WriteLine("Шестёрка");
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Семёрка");
                            break;
                        }

                    case 8:
                        {
                            Console.WriteLine("Восьмёрка");
                            break;
                        }
                    case 9:
                        {
                            Console.WriteLine("Девятка");
                            break;
                        }

                    case 10:
                        {
                            Console.WriteLine("Десятка");
                            break;
                        }
                    case 11:
                        {
                            Console.WriteLine("Валет");
                            break;
                        }
                    case 12:
                        {
                            Console.WriteLine("Дама");
                            break;
                        }

                    case 13:
                        {
                            Console.WriteLine("Король");
                            break;
                        }
                    case 14:
                        {
                            Console.WriteLine("Туз");
                            break;
                        }
                    default:
                        {
                            throw new Exception();
                        }
                }
            }
            catch (Exception)
            {
                Console.Write("Вы ввели не число или ваше число меньше 6 / больше 14.");
            }
        




        }









            }
    }

