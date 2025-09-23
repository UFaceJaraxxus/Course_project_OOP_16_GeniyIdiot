namespace GeniusIdiotConsoleApp
{
    class LogManager
    {
        static string logPath = "Журнал тестирования.txt";

        public static void WriteToLog(string result)
        {
            using (StreamWriter sw = new StreamWriter(logPath, true, System.Text.Encoding.Default))
            {
                sw.WriteLine(result);
            }
        }

        public static void ShowLog()
        {
            while (true)
            {
                Console.WriteLine("Открыть журнал тестирования? (да/нет)");

                string userChoice = Console.ReadLine().ToLower();

                if (userChoice == "да")
                {
                    Console.WriteLine("==================== Журнал тестирования ====================");
                    Console.WriteLine($"{"Фамилия Имя Отчество",-35} | {"Баллы",-10} | {"Результат",-11}");
                    Console.WriteLine(new string('-', 61));
                    foreach (string line in File.ReadLines("Журнал тестирования.txt"))
                    {
                        string[] currentLine = line.Split('#');
                        Console.WriteLine($"{currentLine[0],-35} | {currentLine[1],-10} | {currentLine[2],-11}");
                    }
                    return;
                }
                else if (userChoice == "нет")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите 'да' или 'нет'");
                }
            }
        }
    }
}