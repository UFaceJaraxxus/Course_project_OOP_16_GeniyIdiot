using GeniyIdiot.Common;

namespace GeniyIdiot.WindowsForm
{
    public partial class AddQuestion : Form
    {
        public AddQuestion()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string newQuestionText = newQuestionTextBox.Text.Trim();

            foreach (Question question in QuestionsStorage.Questions)
            {
                if (question.Text.ToLower() == newQuestionText.ToLower())
                {
                    MessageBox.Show("Данный вопрос уже есть в списке");
                    newQuestionTextBox.Clear();
                    newAnswerTextBox.Clear();
                    return;
                }
            }
            
            (bool success, int value) result = Validator.TryParseNumber(newAnswerTextBox.Text.Trim());

            if (newQuestionText == string.Empty || newAnswerTextBox.Text == string.Empty || result.success == false)
            {
                MessageBox.Show("Недопустимое значение! Повторите попытку");
                newQuestionTextBox.Clear();
                newAnswerTextBox.Clear();
                return;
            }

            int newQuestionAnswer = result.value;

            Question newQuestion = new Question(newQuestionText, newQuestionAnswer);
            QuestionsStorage.Questions.Add(newQuestion);
            FileManager.SerializeToFile(QuestionsStorage.Questions, QuestionsStorage.QuestionsListPath);
            MessageBox.Show("Вопрос добавлен");

            newQuestionTextBox.Clear();
            newAnswerTextBox.Clear();
        }
    }
}