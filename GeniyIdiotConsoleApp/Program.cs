using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniusIdiotConsoleApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            bool repeatTest = true;

            Console.WriteLine("Введите фамилию:");
            string lastName = ConsoleHelper.IdentifyUser();

            Console.WriteLine("Введите имя:");
            string firstName = ConsoleHelper.IdentifyUser();

            Console.WriteLine("Введите отчество:");
            string middleName = ConsoleHelper.IdentifyUser();

            var user = new User(lastName, firstName, middleName);
            Random randomQuestion = new Random();

            while (repeatTest)
            {
                int rightAnswers = 0;
                int currentQuestion;
                int userAnswer;
                string resultToLog;                
                var copyQuestions = new List<Question>(QuestionsStorage.GetQuestions());
                while (copyQuestions.Count > 0)
                {
                    currentQuestion = randomQuestion.Next(0, copyQuestions.Count);
                    Console.WriteLine(copyQuestions[currentQuestion].Text);
                    userAnswer = ConsoleHelper.TryParseInt();
                    if (userAnswer == copyQuestions[currentQuestion].Answer)
                    {
                        rightAnswers++;
                    }
                    copyQuestions.RemoveAt(currentQuestion);
                }
                Console.WriteLine($"Количество верных ответов: {rightAnswers}/{QuestionsStorage.GetQuestions().Count}");
                Console.WriteLine($"Поздравляю, {user.FirstName}, Вы - {UsersResultStorage.GetResult(rightAnswers)}!");
                repeatTest = ConsoleHelper.RepeatTest();
                resultToLog = $"{user}#{rightAnswers}/{QuestionsStorage.GetQuestions().Count}#{UsersResultStorage.GetResult(rightAnswers)}";
                LogManager.WriteToLog(resultToLog);
                Console.WriteLine("Результат записан в журнал тестирования");
            }

            LogManager.ShowLog();
            Console.WriteLine("Выход из программы!");
        }
    }
}