using GeniyIdiot.Common;

namespace GeniyIdiot.WindowsForm
{
    public partial class QuestionEditor : Form
    {
        public QuestionEditor()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QuestionEditor_Load(object sender, EventArgs e)
        {            
            LoadQuestionList();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить выбранный вопрос?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string selectedQuestionText = questionEditorDataGridView.CurrentRow.Cells["questionText"].Value?.ToString();

                for (int i = 0; i < QuestionsStorage.Questions.Count; i++)
                {
                    if (QuestionsStorage.Questions[i].Text == selectedQuestionText)
                    {
                        QuestionsStorage.Questions.RemoveAt(i);
                    }
                }

                FileManager.SerializeToFile(QuestionsStorage.Questions, QuestionsStorage.QuestionsListPath);
                LoadQuestionList();
            }
            else
            {
                return;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var addQuestion = new AddQuestion())
            {
                addQuestion.ShowDialog();
            }
            LoadQuestionList();
            this.Show();
        }

        private void LoadQuestionList()
        {
            questionEditorDataGridView.Rows.Clear();
            int questionCount = 1;

            foreach (Question question in QuestionsStorage.Questions)
            {
                questionEditorDataGridView.Rows.Add(questionCount, question.Text, question.Answer);
                questionCount++;
            }
        }
    }
}
