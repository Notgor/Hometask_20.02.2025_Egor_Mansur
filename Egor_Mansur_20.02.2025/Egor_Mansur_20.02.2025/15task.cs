using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egor_Mansur_20._02._2025
{
    internal class _15_FromStringToDateTime
    {
        public static void Execute()
        {
            Console.Write("Введите дату в формате dd.MM.yyyy: ");
            string dateString = Console.ReadLine();

            try
            {
                DateTime date = DateTime.ParseExact(dateString, "dd.MM.yyyy", null);
                Console.WriteLine("Преобразованная дата: " + date.ToString("d"));
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: неверный формат даты.");
            }
        }
    }
}
