using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniyIdiot.ConsoleApp
{
    internal class ConsoleHelper
    {
        public static string CheckYesOrNot()
        {
            while (true)
            {
                string value = Console.ReadLine().ToLower();
                if (value == "да" || value == "нет")
                {
                    return value;
                }
                Console.WriteLine("Некорректный ввод! Повторите попытку");
            }
        }

        public static string SetName()
        {
            (bool success, string value) name;
            
            do
            {
                name = GeniyIdiot.Common.Validator.ValidateName(Console.ReadLine());
                if (name.success == false)
                {
                    Console.WriteLine("Некорректный ввод! Повторите попытку");
                }
            }
            while (name.success == false);
            return name.value;
        }

        public static int SetNumber()
        {
            (bool success, int value) number;

            do
            {
                number = GeniyIdiot.Common.Validator.TryParseNumber(Console.ReadLine());
                if (number.success == false)
                {
                    Console.WriteLine("Некорректный ввод! Повторите попытку");
                }
            }
            while (number.success == false);
            return number.value;
        }
    }
}