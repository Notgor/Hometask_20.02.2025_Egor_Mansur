using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egor_Mansur_20._02._2025
{
    internal class _6_Explicit_ImplicitTypeConversion
    {
        public static void Execute()
        {
            Console.Write("Введите целое число: ");
            int intNumber = int.Parse(Console.ReadLine());

            // Неявное преобразование
            double doubleNumber = intNumber;
            Console.WriteLine("Неявное преобразование из int в double: " + doubleNumber);

            Console.Write("Введите число с плавающей точкой: ");
            double originalDouble = double.Parse(Console.ReadLine());

            // Явное преобразование
            int convertedInt = (int)originalDouble;
            Console.WriteLine("Явное преобразование из double в int: " + convertedInt);
        }
    }
}
