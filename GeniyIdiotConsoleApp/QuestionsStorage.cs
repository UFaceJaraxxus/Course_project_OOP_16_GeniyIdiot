using GeniyIdiot.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniyIdiot.ConsoleApp
{
    internal class QuestionsStorage
    {
        private static string _questionListPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Список вопросов.txt");
        public static void AddOne()
        {
            bool repeatAddQuestion = true;
            while (repeatAddQuestion)
            {
                Console.WriteLine("Введите текст вопроса:");
                string newTextQuestion = Console.ReadLine();

                Console.WriteLine("Введите ответ:");
                int newAnswerQuestion = ConsoleHelper.SetNumber();

                string newQuestion = $"{newTextQuestion}#{newAnswerQuestion}";

                IEnumerable<string> fileContent = FileManager.GetAll(_questionListPath);
                foreach (string file in fileContent)
                {
                    if (newQuestion.ToLower().Equals(file.ToLower()))
                    {
                        Console.WriteLine("Данный вопрос уже присутствует в списке");
                        return;
                    }
                }

                using (StreamWriter sw = new StreamWriter(_questionListPath, true, System.Text.Encoding.Default))
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

        public static void DeleteOne()
        {
            bool repeatDeleteQuestion = true;
            while (repeatDeleteQuestion)
            {
                PrintAll();
                Console.WriteLine("Выберите номер вопроса, который нужно удалить:");
                int questionNumber = ConsoleHelper.SetNumber();

                var lines = FileManager.GetAll(_questionListPath).ToList();
                lines.RemoveAt(questionNumber - 1);
                FileManager.WriteAllLines(lines, _questionListPath);

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

        public static void PrintAll()
        {
            IEnumerable<string> fileContent = FileManager.GetAll(_questionListPath);
            int countQuestion = 1;
            Console.WriteLine("--------------------- Список вопросов ---------------------");
            foreach (string line in fileContent)
            {
                Console.Write($"{countQuestion}. {line}");
                Console.WriteLine();
                countQuestion++;
            }
        }
    }
}
