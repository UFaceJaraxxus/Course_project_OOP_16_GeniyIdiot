using System.Net;

namespace GeniyIdiot.WindowsForm
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var authorizationForm = new Authorization())
            {
                authorizationForm.ShowDialog();
            }
            this.Show();
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var testLogForm = new TestLog())
            {
                testLogForm.ShowDialog();
            }
            this.Show();
        }

        private void adminMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var passwordForm = new PasswordWindow())
            {
                passwordForm.ShowDialog();
            }
            this.Show();
        }
    }
}
