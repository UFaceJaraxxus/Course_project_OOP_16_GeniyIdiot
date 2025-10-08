using GeniyIdiot.Common;

namespace GeniyIdiot.WindowsForm
{
    public partial class Testing : Form
    {
        private User user;
        private List<Question> _questions;
        private int countQuestionList = 0;
        private int _questionNumber = 1;
        private int _rightAnswers = 0;

        public Testing(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Testing_Load(object sender, EventArgs e)
        {
            _questions = QuestionsStorage.Shuffle(QuestionsStorage.Questions);
            ShowNextQuestion();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            (bool success, int value) userAnswer = Validator.TryParseNumber(userAnswerTextBox.Text.Trim());

            if (userAnswer.success == false)
            {
                MessageBox.Show("Недопустимое значение! Повторите попытку");
                userAnswerTextBox.Clear();
                userAnswerTextBox.Clear();
                return;
            }

            if (userAnswer.value == _questions[countQuestionList].Answer)
            {
                _rightAnswers++;
            }

            countQuestionList++;            

            if (countQuestionList == _questions.Count)
            {
                user.RightAnswers = $"{_rightAnswers}/{_questions.Count}";
                user.Diagnose = UserResultStorage.GetResult(_rightAnswers);
                UserResultStorage.UserResults.Add(user);
                MessageBox.Show($"Поздравляю, {user.FirstName}, Вы - {user.Diagnose}!\nРезультат записан в Журнал тестирования");
                FileManager.SerializeToFile(UserResultStorage.UserResults, UserResultStorage.LogPath);
                this.Close();
                return;
            }            
            ShowNextQuestion();
            userAnswerTextBox.Clear();
        }

        private void ShowNextQuestion()
        {
            questionNumberLabel.Text = $"Вопрос №{_questionNumber}";
            questionTextLabel.Text = _questions[countQuestionList].Text;
            _questionNumber++;
        }
    }
}
