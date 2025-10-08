namespace GeniyIdiot.WindowsForm
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void returnToMainMenuButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void questionEditorButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var questionEditor = new QuestionEditor())
            {
                questionEditor.ShowDialog();
            }
            this.Show();
        }
    }
}
