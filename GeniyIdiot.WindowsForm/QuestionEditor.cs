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
            questionEditorDataGridView.Columns.Add("questionNumber", "Номер вопроса");
            questionEditorDataGridView.Columns.Add("questionText", "Текст вопроса");
            questionEditorDataGridView.Columns.Add("questionAnswer", "Правильный ответ");

            questionEditorDataGridView.Columns["questionNumber"].Width = 50;
            questionEditorDataGridView.Columns["questionText"].Width = 340;
            questionEditorDataGridView.Columns["questionAnswer"].Width = 80;

            questionEditorDataGridView.Columns["questionNumber"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            questionEditorDataGridView.Columns["questionText"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            questionEditorDataGridView.Columns["questionAnswer"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn column in questionEditorDataGridView.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
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

                IEnumerable<string> fileContent = FileManager.GetAll(_questionListPath);
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
                GeniyIdiot.Common.QuestionsStorage.GetAll();
            }
            questionEditorDataGridView.Rows.Clear();
            var lines = FileManager.GetAll(_questionListPath);
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
