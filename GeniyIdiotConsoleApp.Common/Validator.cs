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

        public static (bool success, string value) ValidateName(string userInput)
        {
            if (userInput.Trim() != string.Empty && userInput.Trim().Length >= 2 && !userInput.Any(char.IsDigit))
            {
                userInput = userInput.Trim();
                string userName = char.ToUpper(userInput[0]) + userInput.Substring(1).ToLower();
                return (true, userName);
            }
            return (false, string.Empty);
        }
    }
}