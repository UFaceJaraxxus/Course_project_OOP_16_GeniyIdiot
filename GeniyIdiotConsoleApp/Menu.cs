namespace GeniyIdiot.ConsoleApp
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
            Console.WriteLine("3 - Удалить вопрос");
            Console.WriteLine("4 - Вернуться в главное меню");
        }
    }
}
