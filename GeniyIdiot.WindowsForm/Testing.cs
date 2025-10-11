using GeniyIdiot.Common;
using System.Windows.Forms;

namespace GeniyIdiot.WindowsForm
{
    public partial class Testing : Form
    {
        private User user;
        private List<Question> _questions;
        private int countQuestionList = 0;
        private int _questionNumber = 1;
        private int _rightAnswers = 0;
        private int secondLeft = 10;
        public event Action TimeEnded;

        public Testing(User user)
        {
            InitializeComponent();
            this.user = user;
            this.TimeEnded += OnTimeEnded;
        }

        private void Testing_Load(object sender, EventArgs e)
        {
            _questions = QuestionsStorage.Shuffle(QuestionsStorage.Questions);
            ShowNextQuestion();

            testTimer.Interval = 1000;
            testTimer.Start();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (secondLeft <= 0)
            {
                return;
            }                

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
                FinishTest();
                FileManager.SerializeToFile(UserResultStorage.UserResults, UserResultStorage.LogPath);
                this.Close();
                return;
            }
            ShowNextQuestion();
            secondLeft = 10;
            testTimer.Start();
            userAnswerTextBox.Clear();
        }

        private void ShowNextQuestion()
        {
            questionNumberLabel.Text = $"Вопрос №{_questionNumber}";
            questionTextLabel.Text = _questions[countQuestionList].Text;
            _questionNumber++;
        }

        private void FinishTest()
        {
            user.RightAnswers = $"{_rightAnswers}/{_questions.Count}";
            user.Diagnose = UserResultStorage.GetResult(_rightAnswers);
            UserResultStorage.UserResults.Add(user);
            MessageBox.Show($"Поздравляю, {user.FirstName}, Вы - {user.Diagnose}!\nРезультат записан в Журнал тестирования");
        }

        private void OnTimeEnded()
        {
            MessageBox.Show("Время вышло");
            countQuestionList++;

            if (countQuestionList >= _questions.Count)
            {
                FinishTest();
                FileManager.SerializeToFile(UserResultStorage.UserResults, UserResultStorage.LogPath);
                this.Close();
                return;
            }

            ShowNextQuestion();
            secondLeft = 10;
            testTimer.Start();            
        }

        private void testTimer_Tick(object sender, EventArgs e)
        {            
            timerLabel.Text = secondLeft.ToString();
            secondLeft--;

            if (secondLeft < 0)
            {
                testTimer.Stop();
                TimeEnded.Invoke();
            }
        }
    }
}
