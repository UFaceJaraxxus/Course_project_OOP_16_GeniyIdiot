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

            while (repeatTest)
            {
                user.rightAnswers = 0;
                int userAnswer;
                string resultToLog;
                var Questions = QuestionsStorage.ShuffleQuestions(QuestionsStorage.GetQuestions());
                for (int i = 0; i < Questions.Count; i++)
                {
                    Console.WriteLine(Questions[i].Text);
                    userAnswer = ConsoleHelper.TryParseInt();
                    if (userAnswer == Questions[i].Answer)
                    {
                        user.rightAnswers++;
                    }
                }
                Console.WriteLine($"Количество верных ответов: {user.rightAnswers}/{QuestionsStorage.GetQuestions().Count}");
                Console.WriteLine($"Поздравляю, {user.FirstName}, Вы - {UsersResultStorage.GetResult(user.rightAnswers)}!");
                repeatTest = ConsoleHelper.RepeatTest();
                resultToLog = $"{user}#{user.rightAnswers}/{QuestionsStorage.GetQuestions().Count}#{UsersResultStorage.GetResult(user.rightAnswers)}";
                FileManager.WriteToFile(resultToLog);
                Console.WriteLine("Результат записан в журнал тестирования!");
            }

            UsersResultStorage.ShowResult();
            Console.WriteLine("Выход из программы!");
        }
    }
}