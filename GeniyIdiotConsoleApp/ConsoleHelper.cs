namespace GeniusIdiotConsoleApp
{
    public static class ConsoleHelper
    {
        public static string ValidateName()
        {            
            while (true)
            {
                string inputUser = Console.ReadLine().ToLower();
                if (!string.IsNullOrEmpty(inputUser) && inputUser.All(char.IsLetter))
                {
                    string userValue = inputUser[0].ToString().ToUpper();

                    for (int i = 1; i < inputUser.Length; i++)
                    {
                        userValue = userValue + inputUser[i];
                    }
                    return userValue;
                }
                else
                {
                    Console.WriteLine("Ошибка! Значение должно содержать только буквы");
                }
            }
        }
        public static bool RepeatTest()
        {
            while (true)
            {
                Console.WriteLine("Вы желаете повторить тест? (да/нет)");
                string userChoice = Console.ReadLine().ToLower();

                if (userChoice == "да")
                {
                    return true;
                }
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
        public static int TryParseInt()
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
    }
}