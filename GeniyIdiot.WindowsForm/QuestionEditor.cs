using GeniyIdiot.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeniyIdiot.WindowsForm
{
    public partial class QuestionEditor : Form
    {
        private string _questionListPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Список вопросов.txt");
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
                string currentQuestionText = questionEditorDataGridView.CurrentRow.Cells["questionText"].Value + "#" + questionEditorDataGridView.CurrentRow.Cells["questionAnswer"].Value;

                IEnumerable<string> fileContent = FileManager.ReadAllLines(_questionListPath);
                List<string> newContent = new List<string>();

                foreach (string file in fileContent)
                {
                    if (file != currentQuestionText)
                    {
                        newContent.Add(file);
                    }
                }

                FileManager.WriteAllLines(newContent, _questionListPath);
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
            if (!File.Exists(_questionListPath))
            {
                QuestionsStorage.GetAll();
            }
            questionEditorDataGridView.Rows.Clear();
            var lines = FileManager.ReadAllLines(_questionListPath);
            int questionCount = 1;

            foreach (var line in lines)
            {
                var parts = line.Split('#');
                questionEditorDataGridView.Rows.Add(questionCount, parts[0], parts[1]);
                questionCount++;
            }
        }
    }
}
