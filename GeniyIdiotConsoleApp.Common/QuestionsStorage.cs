using System.Collections.Generic;

namespace GeniyIdiot.Common
{
    public class QuestionsStorage
    {
        private static string _questionListPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Список вопросов.txt");
        public static List<Question> GetAll()
        {
            if (!File.Exists(_questionListPath) || new FileInfo(_questionListPath).Length == 0)
            {
                SeedDefaults();
            }
            List<Question> questions = new List<Question>();
            IEnumerable<string> fileContent = FileManager.ReadAllLines(_questionListPath);
            foreach (string line in fileContent)
            {
                string[] currentLine = line.Split('#');
                questions.Add(new Question(currentLine[0], Convert.ToInt32(currentLine[1])));
            }
            return questions;
        }

        public static List<Question> SeedDefaults()
        {
            var questions = new List<Question>()
            {
                new Question("Сколько будет два плюс два умноженное на два?", 6),
                new Question("Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?", 9),
                new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25),
                new Question("Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?", 60),
                new Question("Пять свечей горело, две потухли. Сколько свечей осталось?", 2)
            };

            for (int i = 0; i < questions.Count; i++)
            {
                string currentQuestion = $"{questions[i].Text}#{questions[i].Answer}";
                FileManager.Write(currentQuestion, _questionListPath);
            }
            return questions;
        }

        public static List<Question> Shuffle(List<Question> questions)
        {
            Random randomQuestion = new Random();
            for (int i = questions.Count - 1; i > 0; i--)
            {
                int j = randomQuestion.Next(0, i + 1);
                (questions[i], questions[j]) = (questions[j], questions[i]);
            }
            return questions;
        }
    }
}