using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入年分 ：");
            var yearInput = Console.ReadLine();
            int year = !IsInt(yearInput) ? 0 : int.Parse(yearInput);

            if (year > 0)
            {
                if (IsLeapYear(year))
                    Console.WriteLine("閏年");
                else
                    Console.WriteLine("不閏年");
            }
            else
            {
                Console.WriteLine("輸入錯誤");
            }
            Console.ReadKey();
        }
        static bool IsLeapYear(int year) 
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    return (year % 400 == 0);
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

        static bool IsInt(string input)
        {
            return int.TryParse(input, out _);
        }
    }

}
