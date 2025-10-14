namespace GeniyIdiot.Common
{
    public class UserResultStorage
    {
        public static string LogPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Журнал тестирования.json");
        public static List<User> UserResults = FileManager.DeserializeFromFile<List<User>>(LogPath) ?? new List<User>();

        public static string GetResult(int rightAnswers)
        {
            int ratioRightAnswers = rightAnswers * 100 / QuestionsStorage.GetAll().Count;

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
    }
}