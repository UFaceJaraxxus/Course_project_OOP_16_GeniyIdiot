namespace GeniyIdiot.Common
{
    public class User
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public int RightAnswers;
        public string Diagnose;

        public User(string lastName, string firstName, string middleName)
        {
            LastName = lastName;
            FirstName = firstName;
            MiddleName = middleName;
        }
        public override string ToString()
        {
            return $"{LastName} {FirstName} {MiddleName}";
        }
    }
}