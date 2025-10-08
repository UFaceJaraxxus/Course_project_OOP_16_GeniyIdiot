using GeniyIdiot.Common;

namespace GeniyIdiot.ConsoleApp
{
    internal class QuestionsStorage
    {
        public static void AddOne()
        {
            bool repeatAddQuestion = true;
            while (repeatAddQuestion)
            {
                Console.WriteLine("Введите текст вопроса:");
                string newTextQuestion = Console.ReadLine();

                Console.WriteLine("Введите правильный ответ:");
                int newAnswerQuestion = ConsoleHelper.SetNumber();                

                foreach (Question question in GeniyIdiot.Common.QuestionsStorage.Questions)
                {
                    if (question.Text.ToLower() == newTextQuestion.ToLower())
                    {
                        Console.WriteLine("Данный вопрос уже присутствует в списке");
                        return;
                    }
                }

                Question newQuestion = new Question(newTextQuestion, newAnswerQuestion);
                GeniyIdiot.Common.QuestionsStorage.Questions.Add(newQuestion);

                Console.WriteLine("Добавить ещё вопрос? (да/нет)");
                string userChoice = ConsoleHelper.CheckYesOrNot();
                if (userChoice == "да")
                {
                    repeatAddQuestion = true;
                }
                else
                {
                    FileManager.SerializeToFile(GeniyIdiot.Common.QuestionsStorage.Questions, GeniyIdiot.Common.QuestionsStorage.QuestionsListPath);
                    repeatAddQuestion = false;
                }
            }
        }

        public static void DeleteOne()
        {
            bool repeatDeleteQuestion = true;
            while (repeatDeleteQuestion)
            {
                PrintAll();
                Console.WriteLine("Выберите номер вопроса, который нужно удалить:");
                int DelQuestionNumber = ConsoleHelper.SetNumber();

                GeniyIdiot.Common.QuestionsStorage.Questions.RemoveAt(DelQuestionNumber - 1);

                Console.WriteLine("Вопрос удалён.");

                Console.WriteLine("Удалить ещё вопрос? (да/нет)");
                string userChoice = ConsoleHelper.CheckYesOrNot();
                if (userChoice == "да")
                {
                    repeatDeleteQuestion = true;
                }
                else
                {
                    FileManager.SerializeToFile(GeniyIdiot.Common.QuestionsStorage.Questions, GeniyIdiot.Common.QuestionsStorage.QuestionsListPath);
                    repeatDeleteQuestion = false;
                }
            }
        }

        public static void PrintAll()
        {
            int countQuestion = 1;
            Console.WriteLine("--------------------- Список вопросов ---------------------");
            foreach (Question question in GeniyIdiot.Common.QuestionsStorage.Questions)
            {
                Console.WriteLine($"{countQuestion}. Вопрос: {question.Text} Правильный ответ: {question.Answer}");
                countQuestion++;
            }
        }
    }
}
