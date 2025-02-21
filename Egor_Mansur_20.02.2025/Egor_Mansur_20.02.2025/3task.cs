using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egor_Mansur_20._02._2025
{
    internal class _3_StringToNumber
    {
        public static void Execute()
        {
            Console.Write("Введите строку, содержащую числовое значение: ");
            string input = Console.ReadLine();

            try
            {
                int number = int.Parse(input);
                Console.WriteLine("Преобразованное число: " + number);
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: неверный формат строки.");
            }
        }
    }
}
