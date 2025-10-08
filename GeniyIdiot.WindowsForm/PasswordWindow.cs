namespace GeniyIdiot.WindowsForm
{
    public partial class PasswordWindow : Form
    {
        public PasswordWindow()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "пароль")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный пароль");
                passwordTextBox.Clear();
            }
        }
    }
}