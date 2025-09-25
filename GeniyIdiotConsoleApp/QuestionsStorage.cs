using System.Collections.Generic;

namespace GeniusIdiotConsoleApp
{
    class QuestionsStorage
    {
        private static List<Question> questions = new List<Question>()
        {
            new Question("Сколько будет два плюс два умноженное на два?", 6),
            new Question("Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?", 9),
            new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25),
            new Question("Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?", 60),
            new Question("Пять свечей горело, две потухли. Сколько свечей осталось?", 2)
        };

        public static List<Question> GetQuestions()
        {
            return questions;
        }

        public static List<Question> ShuffleQuestions(List<Question> questions)
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