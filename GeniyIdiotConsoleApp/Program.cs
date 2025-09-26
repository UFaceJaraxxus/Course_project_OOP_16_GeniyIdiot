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
            string lastName = ConsoleHelper.ValidateName();

            Console.WriteLine("Введите имя:");
            string firstName = ConsoleHelper.ValidateName();

            Console.WriteLine("Введите отчество:");
            string middleName = ConsoleHelper.ValidateName();

            var user = new User(lastName, firstName, middleName);

            while (repeatTest)
            {
                user.RightAnswers = 0;
                int userAnswer;
                string resultToLog;
                var Questions = QuestionsStorage.ShuffleQuestions(QuestionsStorage.GetQuestions());
                for (int i = 0; i < Questions.Count; i++)
                {
                    Console.WriteLine(Questions[i].Text);
                    userAnswer = ConsoleHelper.TryParseInt();
                    if (userAnswer == Questions[i].Answer)
                    {
                        user.RightAnswers++;
                    }
                }
                Console.WriteLine($"Количество верных ответов: {user.RightAnswers}/{QuestionsStorage.GetQuestions().Count}");
                Console.WriteLine($"Поздравляю, {user.FirstName}, Вы - {UsersResultStorage.GetResult(user.RightAnswers)}!");
                repeatTest = ConsoleHelper.RepeatTest();
                resultToLog = $"{user}#{user.RightAnswers}/{QuestionsStorage.GetQuestions().Count}#{UsersResultStorage.GetResult(user.RightAnswers)}";
                FileManager.WriteToFile(resultToLog);
                Console.WriteLine("Результат записан в журнал тестирования!");
            }

            UsersResultStorage.ShowResult();
            Console.WriteLine("Выход из программы!");
        }
    }
}