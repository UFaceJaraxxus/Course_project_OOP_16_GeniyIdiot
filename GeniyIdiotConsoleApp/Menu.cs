using GeniusIdiotConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniyIdiotConsoleApp
{
    class Menu
    {
        public static void OpenMenu()
        {
            Console.WriteLine("======================= Главное меню =======================");
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1 - Пройти тестирование \"Гений-Идиот\"");
            Console.WriteLine("2 - Открыть журнал тестирования");
            Console.WriteLine("3 - Войти в режим разработчика");
            Console.WriteLine("4 - Выйти из программы");
        }
        public static void OpenAdminMenu()
        {
            Console.WriteLine("==================== Меню разработчика ====================");
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1 - Добавить вопрос");
            Console.WriteLine("2 - Открыть список вопросов");
            Console.WriteLine("3 - Выйти в предыдущее меню");
        }
    }
}
