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
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            var user = new User(lastNameTextBox.Text, firstNameTextBox.Text, middleNameTextBox.Text);

            this.Hide();
            using (var testForm = new Testing(user))
            {
                testForm.ShowDialog();
            }
            this.Close();
        }

        private void LastNameTextBox_Leave(object sender, EventArgs e)
        {
            (bool success, string value, string errorMessage) lastName = Validator.ValidateName(lastNameTextBox.Text.Trim());

            if (!lastName.success)
            {
                MessageBox.Show(lastName.errorMessage);
                lastNameTextBox.Focus();
            }
        }

        private void FirstNameTextBox_Leave(object sender, EventArgs e)
        {
            (bool success, string value, string errorMessage) firstName = Validator.ValidateName(firstNameTextBox.Text.Trim());

            if (!firstName.success)
            {
                MessageBox.Show(firstName.errorMessage);
                firstNameTextBox.Focus();
            }
        }

        private void MiddleNameTextBox_Leave(object sender, EventArgs e)
        {
            (bool success, string value, string errorMessage) middleName = Validator.ValidateName(middleNameTextBox.Text.Trim());

            if (!middleName.success)
            {
                MessageBox.Show(middleName.errorMessage);
                middleNameTextBox.Focus();
            }
        }
    }
}
