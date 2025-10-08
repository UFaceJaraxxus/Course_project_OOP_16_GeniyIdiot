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
    public partial class TestLog : Form
    {
        private string _logPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Журнал тестирования.txt");
        public TestLog()
        {
            InitializeComponent();

            testLogDataGridView.Columns.Add("lastName firstName middleName", "Фамилия Имя Отчество");
            testLogDataGridView.Columns.Add("Score", "Баллы");
            testLogDataGridView.Columns.Add("Result", "Результат");
        }

        private void testLogForm_Load(object sender, EventArgs e)
        {
            var lines = FileManager.GetAll(_logPath);

            foreach (var line in lines)
            {
                var parts = line.Split('#');
                testLogDataGridView.Rows.Add(parts[0], parts[1], parts[2]);
            }
        }

        private void returnToMainMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
