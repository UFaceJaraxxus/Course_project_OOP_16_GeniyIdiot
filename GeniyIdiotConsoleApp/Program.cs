using GeniyIdiot.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniyIdiot.ConsoleApp
{
    internal class Program
    {
        private static string _logPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Журнал тестирования.txt");
        public static void Main(string[] args)
        {
            while (true)
            {
                Menu.OpenMenu();
                int userChoice = ConsoleHelper.SetNumber();
                switch (userChoice)
                {
                    case 1:
                        Console.WriteLine("Введите фамилию:");
                        string lastName = ConsoleHelper.SetName();

                        Console.WriteLine("Введите имя:");
                        string firstName = ConsoleHelper.SetName();

                        Console.WriteLine("Введите отчество:");
                        string middleName = ConsoleHelper.SetName();

                        var user = new User(lastName, firstName, middleName);

                        user.RightAnswers = 0;
                        int userAnswer;
                        string resultToLog;
                        var questions = GeniyIdiot.Common.QuestionsStorage.Shuffle(GeniyIdiot.Common.QuestionsStorage.GetAll());
                        for (int i = 0; i < questions.Count; i++)
                        {
                            Console.WriteLine(questions[i].Text);
                            userAnswer = ConsoleHelper.SetNumber();
                            if (userAnswer == questions[i].Answer)
                            {
                                user.RightAnswers++;
                            }
                        }
                        Console.WriteLine($"Количество верных ответов: {user.RightAnswers}/{questions.Count}");
                        Console.WriteLine($"Поздравляю, {user.FirstName}, Вы - {UsersResultStorage.GetResult(user.RightAnswers)}!");
                        resultToLog = $"{user}#{user.RightAnswers}/{questions.Count}#{UsersResultStorage.GetResult(user.RightAnswers)}";
                        FileManager.Write(resultToLog, _logPath);
                        Console.WriteLine("Результат записан в журнал тестирования!");
                        break;
                    case 2:
                        PrintLog();
                        break;
                    case 3:
                        Console.WriteLine("Введите пароль:");
                        if (Console.ReadLine() == "пароль")
                        {
                            bool isAdminMenu = true;
                            while (isAdminMenu)
                            {
                                Menu.OpenAdminMenu();
                                int adminChoice = ConsoleHelper.SetNumber();
                                switch (adminChoice)
                                {
                                    case 1:
                                        QuestionsStorage.AddOne();
                                        break;
                                    case 2:
                                        QuestionsStorage.PrintAll();
                                        break;
                                    case 3:
                                        QuestionsStorage.DeleteOne();
                                        break;
                                    case 4:
                                        isAdminMenu = false;
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

        public static void PrintLog()
        {
            IEnumerable<string> fileContent = FileManager.ReadAllLines(_logPath);
            Console.WriteLine("==================== Журнал тестирования ====================");
            Console.WriteLine($"{"Фамилия Имя Отчество",-35} | {"Баллы",-10} | {"Результат",-11}");
            Console.WriteLine(new string('-', 61));
            foreach (string line in fileContent)
            {
                string[] currentLine = line.Split('#');
                Console.WriteLine($"{currentLine[0],-35} | {currentLine[1],-10} | {currentLine[2],-11}");
            }
        }
    }
}