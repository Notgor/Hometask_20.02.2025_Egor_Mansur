using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egor_Mansur_20._02._2025
{
    internal class _9_BitOperations
    {
        public static void Execute()
        {
            Console.Write("Введите первое целое число: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите второе целое число: ");
            int b = int.Parse(Console.ReadLine());

            int and = a & b;
            int or = a | b;
            int xor = a ^ b;

            Console.WriteLine("a & b = " + and);
            Console.WriteLine("a | b = " + or);
            Console.WriteLine("a ^ b = " + xor);
        }
    }
}
