using System.Collections.Generic;

namespace GeniusIdiotConsoleApp
{
    class QuestionsStorage
    {
        public static List<Question> CreateQuestionList()
        {
            if (!File.Exists("Список вопросов.txt") || new FileInfo("Список вопросов.txt").Length == 0)
            {
                UploadDefaultQuestions();
            }
            List<Question> questions = new List<Question>();
            IEnumerable<string> fileContent = FileManager.ReadFile("Список вопросов.txt");
            foreach (string line in fileContent)
            {
                string[] currentLine = line.Split('#');
                questions.Add(new Question(currentLine[0], Convert.ToInt32(currentLine[1])));
            }
            return questions;
        }

        public static List<Question> UploadDefaultQuestions()
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
                FileManager.WriteToFile(currentQuestion, "Список вопросов.txt");
            }
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

        public static void AddQuestion()
        {
            bool repeatAddQuestion = true;
            while (repeatAddQuestion)
            {
                Console.WriteLine("Введите текст вопроса:");
                string newTextQuestion = Console.ReadLine();

                Console.WriteLine("Введите ответ:");
                int newAnswerQuestion = ConsoleHelper.TryParseInt();

                string newQuestion = $"{newTextQuestion}#{newAnswerQuestion}";

                IEnumerable<string> fileContent = FileManager.ReadFile("Список вопросов.txt");
                foreach (string file in fileContent)
                {
                    if (newQuestion.ToLower().Equals(file.ToLower()))
                    {
                        Console.WriteLine("Данный вопрос уже присутствует в списке");
                        return;
                    }
                }

                using (StreamWriter sw = new StreamWriter("Список вопросов.txt", true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(newQuestion);
                    Console.WriteLine("Вопрос добавлен в список");
                }

                Console.WriteLine("Добавить ещё вопрос? (да/нет)");
                string userChoice = ConsoleHelper.CheckYesOrNot();
                if (userChoice == "да")
                {
                    repeatAddQuestion = true;
                }
                else
                {
                    repeatAddQuestion = false;
                }
            }
        }

        public static void ShowQuestionList()
        {
            IEnumerable<string> fileContent = FileManager.ReadFile("Список вопросов.txt");
            int countQuestion = 1;
            Console.WriteLine("--------------------- Список вопросов ---------------------");
            foreach (string line in fileContent)
            {
                Console.Write($"{countQuestion}. {line}");
                Console.WriteLine();
                countQuestion++;
            }
        }

        public static void DeleteQuestion()
        {
            bool repeatDeleteQuestion = true;            
            while (repeatDeleteQuestion)
            {
                ShowQuestionList();
                Console.WriteLine("Выберите номер вопроса, который нужно удалить:");
                int questionNumber = ConsoleHelper.TryParseInt();

                var lines = FileManager.ReadFile("Список вопросов.txt").ToList();
                lines.RemoveAt(questionNumber - 1);
                FileManager.WriteAllFile(lines, "Список вопросов.txt");

                Console.WriteLine("Вопрос удалён.");

                Console.WriteLine("Удалить ещё вопрос? (да/нет)");
                string userChoice = ConsoleHelper.CheckYesOrNot();
                if (userChoice == "да")
                {
                    repeatDeleteQuestion = true;
                }
                else
                {
                    repeatDeleteQuestion = false;
                }
            }            
        }
    }
}