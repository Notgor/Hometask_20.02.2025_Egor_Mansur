﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egor_Mansur_20._02._2025
{
    internal class _12_ValidatingDoWhileInput
    {
        public static void Execute()
        {
            int number;

            do
            {
                Console.Write("Введите число от 1 до 10: ");
                number = int.Parse(Console.ReadLine());
            } while (number < 1 || number > 10);

            Console.WriteLine("Вы ввели корректное число: " + number);
        }
    }
}
