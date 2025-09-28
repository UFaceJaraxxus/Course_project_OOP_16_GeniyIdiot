using GeniyIdiotConsoleApp;
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
            Console.WriteLine("Введите фамилию:");
            string lastName = ConsoleHelper.ValidateName();

            Console.WriteLine("Введите имя:");
            string firstName = ConsoleHelper.ValidateName();

            Console.WriteLine("Введите отчество:");
            string middleName = ConsoleHelper.ValidateName();

            var user = new User(lastName, firstName, middleName);

            while (true)
            {
                Menu.OpenMenu();
                int userChoice = ConsoleHelper.TryParseInt();
                switch (userChoice)
                {
                    case 1:
                        user.RightAnswers = 0;
                        int userAnswer;
                        string resultToLog;
                        var questions = QuestionsStorage.ShuffleQuestions(QuestionsStorage.CreateListQuestion());
                        for (int i = 0; i < questions.Count; i++)
                        {
                            Console.WriteLine(questions[i].Text);
                            userAnswer = ConsoleHelper.TryParseInt();
                            if (userAnswer == questions[i].Answer)
                            {
                                user.RightAnswers++;
                            }
                        }
                        Console.WriteLine($"Количество верных ответов: {user.RightAnswers}/{questions.Count}");
                        Console.WriteLine($"Поздравляю, {user.FirstName}, Вы - {UsersResultStorage.GetResult(user.RightAnswers)}!");
                        resultToLog = $"{user}#{user.RightAnswers}/{questions.Count}#{UsersResultStorage.GetResult(user.RightAnswers)}";
                        FileManager.WriteToFile(resultToLog, "Журнал тестирования.txt");
                        Console.WriteLine("Результат записан в журнал тестирования!");
                        break;
                    case 2:
                        UsersResultStorage.ShowResult();
                        break;
                    case 3:
                        Console.WriteLine("Введите пароль:");
                        if (Console.ReadLine() == "пароль")
                        {                            
                            while (true)
                            {
                                Menu.OpenAdminMenu();
                                int adminChoice = ConsoleHelper.TryParseInt();
                                switch (adminChoice)
                                {
                                    case 1:
                                        QuestionsStorage.AddQuestion();
                                        break;
                                    case 2:
                                        QuestionsStorage.ShowQuestionList();
                                        break;
                                    case 3:
                                        QuestionsStorage.DeleteQuestion();
                                        break;
                                    case 4:
                                        break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Пароль неверный. Возврат к меню");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Завершение работы программы!");
                        return;
                }
            }






            
            
            
        }
    }
}