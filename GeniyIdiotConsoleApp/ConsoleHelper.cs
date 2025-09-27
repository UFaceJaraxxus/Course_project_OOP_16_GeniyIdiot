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

        public static string CheckYesOrNot()
        {
            while (true)
            {
                string value = Console.ReadLine().ToLower();
                if (value == "да" || value == "нет")
                {
                    return value;
                }
                Console.WriteLine("Некорректный ввод! Повторите попытку");
            }
        }
    }
}