using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egor_Mansur_20._02._2025
{
    internal class _7_OverflowCheck
    {
        public static void Execute()
        {
            checked
            {
                try
                {
                    int maxInt = int.MaxValue;
                    Console.WriteLine("Max Int: " + maxInt);
                    int result = maxInt + 1; // Переполнение
                    Console.WriteLine("Result: " + result);
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Переполнение в checked блоке.");
                }
            }

            unchecked
            {
                int maxInt = int.MaxValue;
                Console.WriteLine("Max Int: " + maxInt);
                int result = maxInt + 1; // Переполнение
                Console.WriteLine("Result: " + result);
            }
        }
    }
}
