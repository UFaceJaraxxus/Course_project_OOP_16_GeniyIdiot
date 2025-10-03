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
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            GeniyIdiot.Common.User user;

            (bool success, string value) lastName = GeniyIdiot.Common.Validator.ValidateName(lastNameTextBox.Text.Trim());
            (bool success, string value) firstName = GeniyIdiot.Common.Validator.ValidateName(firstNameTextBox.Text.Trim());
            (bool success, string value) middleName = GeniyIdiot.Common.Validator.ValidateName(middleNameTextBox.Text.Trim());
            if (lastName.success == true && firstName.success == true && middleName.success == true)
            {
                user = new GeniyIdiot.Common.User(lastName.value, firstName.value, middleName.value);

                this.Hide();

                using (var testForm = new Testing(user))
                {
                    testForm.ShowDialog();
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Некорректный ввод! Повторите попытку");
            }
        }            
    }
}
