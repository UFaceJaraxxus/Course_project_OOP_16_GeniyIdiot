using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeniyIdiot.Common;

namespace GeniyIdiot.WindowsForm
{
    public partial class Testing : Form
    {
        private static string _logPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Журнал тестирования.txt");
        private List<Question> questions;
        private GeniyIdiot.Common.User user;
        int countQuestionList = 0;
        private int questionNumber = 1;
        private string resultToLog;

        public Testing(GeniyIdiot.Common.User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Testing_Load(object sender, EventArgs e)
        {
            questions = QuestionsStorage.Shuffle(QuestionsStorage.GetAll());
            ShowNextQuestion();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            (bool success, int value) userAnswer = GeniyIdiot.Common.Validator.TryParseNumber(userAnswerTextBox.Text.Trim());

            if (userAnswer.success == false)
            {
                MessageBox.Show("Недопустимое значение! Повторите попытку");
                userAnswerTextBox.Clear();
                userAnswerTextBox.Clear();
                return;
            }

            if (userAnswer.value == questions[countQuestionList].Answer)
            {
                user.RightAnswers++;
            }

            countQuestionList++;            

            if (countQuestionList == questions.Count)
            {
                user.Diagnose = UsersResultStorage.GetResult(user.RightAnswers);
                MessageBox.Show($"Поздравляю, {user.FirstName}, Вы - {user.Diagnose}!\nРезультат записан в Журнал тестирования");
                resultToLog = $"{user}#{user.RightAnswers}/{questions.Count}#{user.Diagnose}";
                FileManager.Write(resultToLog, _logPath);
                this.Close();
                return;
            }            
            ShowNextQuestion();
            userAnswerTextBox.Clear();
        }

        private void ShowNextQuestion()
        {
            questionNumberLabel.Text = $"Вопрос №{questionNumber}";
            questionTextLabel.Text = questions[countQuestionList].Text;            
            questionNumber++;
        }
    }
}
