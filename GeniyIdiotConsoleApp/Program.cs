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
        static string logPath = "Журнал тестирования.txt";
        static int rightAnswers = 0;

        public static void Main(string[] args)
        {
            bool repeatTest = true;

            string fullName = GetFullName();

            while (repeatTest)
            {
                string result = AskQuestion();
                Console.WriteLine($"{fullName}, поздравляю! Вы - {result}!");
                repeatTest = RepeatTest();
                WriteToLog(fullName, rightAnswers, result);
                Console.WriteLine("Результат записан в журнал тестирования");
            }

            Console.WriteLine("Желаете открыть журнал тестирования? (да/нет)");
            string userChoice = Console.ReadLine();

            if (userChoice.ToLower() == "да")
            {
                OpenLog();
            }
            else
            {
                Console.WriteLine("Завершениея тестирования");
            }
        }

        private static string GetFullName()
        {
            Console.WriteLine("Введите фамилию:");
            string lastName = Console.ReadLine();
            if (!string.IsNullOrEmpty(lastName))
                lastName = char.ToUpper(lastName[0]) + lastName.Substring(1).ToLower();

            Console.WriteLine("Введите имя:");
            string firstName = Console.ReadLine();
            if (!string.IsNullOrEmpty(firstName))
                firstName = char.ToUpper(firstName[0]) + firstName.Substring(1).ToLower();

            Console.WriteLine("Введите отчество:");
            string middleName = Console.ReadLine();
            if (!string.IsNullOrEmpty(middleName))
                middleName = char.ToUpper(middleName[0]) + middleName.Substring(1).ToLower();

            string fullName = lastName + " " + firstName + " " + middleName;

            return fullName;
        }

        private static string AskQuestion()
        {
            rightAnswers = 0;

            (string Question, int Answer)[] questionsAnswers = ShuffleArray(GetQuestionsAnswers());

            for (int i = 0; i < questionsAnswers.Length; i++)
            {
                Console.WriteLine(questionsAnswers[i].Question);
                int userAnswer = TryParseInt();
                if (userAnswer == questionsAnswers[i].Answer)
                {
                    rightAnswers++;
                }
            }
            return GetResult(rightAnswers);
        }

        private static (string Question, int Answer)[] GetQuestionsAnswers()
        {
            var questionsAnswers = new (string Question, int Answer)[5];
            questionsAnswers[0] = (Question: "Сколько будет два плюс два умноженное на два?", Answer: 6);
            questionsAnswers[1] = (Question: "Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?", Answer: 9);
            questionsAnswers[2] = (Question: "На двух руках 10 пальцев. Сколько пальцев на 5 руках?", Answer: 25);
            questionsAnswers[3] = (Question: "Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?", Answer: 60);
            questionsAnswers[4] = (Question: "Пять свечей горело, две потухли. Сколько свечей осталось?", Answer: 2);
            return questionsAnswers;
        }

        private static (string Question, int Answer)[] ShuffleArray((string Question, int Answer)[] array)
        {
            Random questionRandomizer = new Random();

            for (int i = (array.Length - 1); i >= 0; i--)
            {
                int j = questionRandomizer.Next(i + 1);
                (array[i], array[j]) = (array[j], array[i]);
            }
            return array;
        }

        private static string GetResult(int rightAnswers)
        {
            Console.WriteLine($"Количество верных ответов: {rightAnswers} / {GetQuestionsAnswers().Length}");

            int ratioRightAnswers = (rightAnswers * 100) / GetQuestionsAnswers().Length;

            if (ratioRightAnswers >= 1 && ratioRightAnswers <= 20)
            {
                return "кретин";
            }
            else if (ratioRightAnswers >= 21 && ratioRightAnswers <= 40)
            {
                return "дурак";
            }
            else if (ratioRightAnswers >= 41 && ratioRightAnswers <= 60)
            {
                return "нормальный";
            }
            else if (ratioRightAnswers >= 61 && ratioRightAnswers <= 80)
            {
                return "талант";
            }
            else if (ratioRightAnswers >= 81)
            {
                return "гений";
            }
            return "идиот";
        }

        private static int TryParseInt()
        {
            while (true)
            {
                string value = Console.ReadLine();
                if (int.TryParse(value, out int number))
                {
                    return number;
                }
                Console.WriteLine("Введено не число! Повторите попытку");
            }
        }

        private static bool RepeatTest()
        {
            while (true)
            {
                Console.WriteLine("Вы желаете повторить тест? (да/нет)");
                string userChoice = Console.ReadLine().ToLower();

                if (userChoice == "да")
                    return true;
                else if (userChoice == "нет")
                {
                    Console.WriteLine("Завершение тестирования");
                    return false;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите 'да' или 'нет'");
                }
            }
        }

        private static void WriteToLog(string lastFirstMiddleName, int result, string diagnose)
        {
            using (StreamWriter sw = new StreamWriter(logPath, true, System.Text.Encoding.Default))
            {
                if (sw.BaseStream.Length == 0)
                {
                    sw.WriteLine($"{"Фамилия Имя Отчество",-35} | {"Баллы",-10} | {"Результат",-15}");
                    sw.WriteLine(new string('-', 60));
                }
                sw.WriteLine($"{lastFirstMiddleName,-35} | {result}/{GetQuestionsAnswers().Length,-8} | {diagnose,-15}");
            }
        }

        private static void OpenLog()
        {
            if (File.Exists(logPath))
            {
                using (StreamReader sr = new StreamReader(logPath))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
            }
            else
            {
                Console.WriteLine("Журнал тестирования ещё не создан.");
            }
        }
    }
}