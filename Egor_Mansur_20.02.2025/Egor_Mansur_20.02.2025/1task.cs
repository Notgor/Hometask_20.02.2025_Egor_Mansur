using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egor_Mansur_20._02._2025
{
    internal class _1_EvenOdd
    {
        public static void Execute()
        {
            Console.Write("Введите целое число: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("Число чётное.");
                }
                else
                {
                    Console.WriteLine("Число нечётное.");
                }

                
                string result = (number % 2 == 0) ? "Число чётное." : "Число нечётное.";
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Некорректный ввод.");
            }
        }
    }
}
