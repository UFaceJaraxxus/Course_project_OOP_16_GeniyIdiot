using System;
using System.Collections.Generic;
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

            Console.WriteLine("Введите Ваше имя:");
            string name = Console.ReadLine();

            while (repeatTest)
            {
                string result = AskQuestion();
                Console.WriteLine($"{name}, поздравляю! Вы - {result}");
                repeatTest = RepeatTest();
            }
        }

        private static string AskQuestion()
        {
            int rightAnswers = 0;

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

            switch (ratioRightAnswers)
            {
                case int currentRatioRightAnswers when currentRatioRightAnswers >= 81:
                    return "гений";
                case int currentRatioRightAnswers when currentRatioRightAnswers >= 61:
                    return "талант";
                case int currentRatioRightAnswers when currentRatioRightAnswers >= 41:
                    return "нормальный";
                case int currentRatioRightAnswers when currentRatioRightAnswers >= 21:
                    return "дурак";
                case int currentRatioRightAnswers when currentRatioRightAnswers >= 1:
                    return "кретин";         
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
                string repeat = Console.ReadLine().ToLower();

                if (repeat == "да")
                    return true;
                else if (repeat == "нет")
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
    }
}