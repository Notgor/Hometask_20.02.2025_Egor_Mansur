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
            // Неявное преобразование
            int intNumber = 10;
            double doubleNumber = intNumber;
            Console.WriteLine("Неявное преобразование из int в double: " + doubleNumber);

            // Явное преобразование
            double originalDouble = 9.78;
            int convertedInt = (int)originalDouble;
            Console.WriteLine("Явное преобразование из double в int: " + convertedInt);
        }
    }
}
