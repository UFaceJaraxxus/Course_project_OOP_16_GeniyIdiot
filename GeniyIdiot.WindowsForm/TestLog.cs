using GeniyIdiot.Common;

namespace GeniyIdiot.WindowsForm
{
    public partial class TestLog : Form
    {
        public TestLog()
        {
            InitializeComponent();
        }

        private void testLogForm_Load(object sender, EventArgs e)
        {
            foreach (User user in UserResultStorage.UserResults)
            {
                testLogDataGridView.Rows.Add($"{user.LastName} {user.FirstName} {user.MiddleName}", user.RightAnswers, user.Diagnose);
            }
        }

        private void returnToMainMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
