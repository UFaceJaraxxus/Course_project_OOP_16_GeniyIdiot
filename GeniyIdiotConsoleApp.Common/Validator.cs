namespace GeniyIdiot.Common
{
    public static class Validator
    {
        public static (bool success, int value) TryParseNumber(string userInput)
        {
            if (int.TryParse(userInput, out int number))
            {
                return (true, number);
            }
            return (false, 0);
        }

        public static (bool success, string value, string errorMessage) ValidateName(string userInput)
        {
            userInput = userInput.Trim();

            if (userInput == string.Empty)
            {
                return (false, string.Empty, "Значение не должно быть пустым");
            }
            if (userInput.Length < 2 && userInput.Any(char.IsDigit))
            {
                return (false, string.Empty, "Значение должно содержать больше одной буквы и не содержать цифр");
            }
            if (userInput.Length < 2)
            {
                return (false, string.Empty, "Значение должно содержать больше одной буквы");
            }
            if (userInput.Any(char.IsDigit))
            {
                return (false, string.Empty, "Значение не должно содержать цифр");
            }
            string userName = char.ToUpper(userInput[0]) + userInput.Substring(1).ToLower();
            return (true, userName, string.Empty);
        }
    }
}