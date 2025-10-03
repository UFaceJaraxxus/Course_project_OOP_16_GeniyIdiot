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
    public partial class PasswordWindow : Form
    {
        public PasswordWindow()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "пароль")
            {
                using (var adminMenuForm = new AdminMenu())
                {
                    adminMenuForm.ShowDialog();
                    this.Close();
                    return;
                }                
            }
            else
            {
                MessageBox.Show("Неверный пароль");
                this.Close();
            }
        }
    }
}