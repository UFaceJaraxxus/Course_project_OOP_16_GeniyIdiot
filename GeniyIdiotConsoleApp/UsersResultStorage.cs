namespace GeniusIdiotConsoleApp
{
    class UsersResultStorage
    {
        public static string GetResult(int rightAnswers)
        {
            int ratioRightAnswers = (rightAnswers * 100) / QuestionsStorage.GetAll().Count;

            switch (ratioRightAnswers)
            {
                case int currentRatioRightAnswers when currentRatioRightAnswers >= 81:
                    return "гений";
                case int currentRatioRightAnswers when currentRatioRightAnswers >= 61:
                    return "талант";
                case int currentRatioRightAnswers when currentRatioRightAnswers >= 41:
                    return "нормальный";
                case int currentRatioRightAnswers when currentRatioRightAnswers >= 21:
                    return "дурак";
                case int currentRatioRightAnswers when currentRatioRightAnswers >= 1:
                    return "кретин";
            }
            return "идиот";
        }

        public static void PrintLog()
        {
            IEnumerable<string> fileContent = FileManager.ReadAllLines("Журнал тестирования.txt");
            Console.WriteLine("==================== Журнал тестирования ====================");
            Console.WriteLine($"{"Фамилия Имя Отчество",-35} | {"Баллы",-10} | {"Результат",-11}");
            Console.WriteLine(new string('-', 61));
            foreach (string line in fileContent)
            {
                string[] currentLine = line.Split('#');
                Console.WriteLine($"{currentLine[0],-35} | {currentLine[1],-10} | {currentLine[2],-11}");
            }
        }
    }
}