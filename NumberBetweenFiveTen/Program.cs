using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberBetweenFiveTen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            string numString = Console.ReadLine();

            try
            {
                float num = float.Parse(numString);

                if (num > 5 && num < 10)
                    Console.WriteLine($"Число больше 5 и меньше 10");
                else
                    Console.WriteLine($"Неизвестное число");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
