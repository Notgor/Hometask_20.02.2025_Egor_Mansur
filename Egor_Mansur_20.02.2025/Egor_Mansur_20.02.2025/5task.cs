using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egor_Mansur_20._02._2025
{
    internal class _5_NumbersProductWithWhile
    {
        public static void Execute()
        {
            int product = 1;
            int number;

            do
            {
                Console.Write("Введите число (0 для выхода): ");
                number = int.Parse(Console.ReadLine());
                if (number != 0)
                {
                    product *= number;
                }
            } while (number != 0);

            Console.WriteLine("Произведение введённых чисел равно: " + product);
        }
    }
}
