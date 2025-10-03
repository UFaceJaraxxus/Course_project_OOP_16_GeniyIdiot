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
    public partial class AddQuestion : Form
    {
        private string _questionListPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Список вопросов.txt");
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
            string newQuestion = newQuestionTextBox.Text.Trim();
            
            (bool success, int value) result = GeniyIdiot.Common.Validator.TryParseNumber(newAnswerTextBox.Text.Trim());

            if (newQuestion == string.Empty || newAnswerTextBox.Text == string.Empty || result.success == false)
            {
                MessageBox.Show("Недопустимое значение! Повторите попытку");
                newQuestionTextBox.Clear();
                newAnswerTextBox.Clear();
                return;
            }

            string newAnswer = result.value.ToString();

            string newQuestionAndAnswer = newQuestion + "#" + newAnswer;            

            GeniyIdiot.Common.FileManager.Write(newQuestionAndAnswer, _questionListPath);
            MessageBox.Show("Вопрос добавлен");

            newQuestionTextBox.Clear();
            newAnswerTextBox.Clear();
        }
    }
}
