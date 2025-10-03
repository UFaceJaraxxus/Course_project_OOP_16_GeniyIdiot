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
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void returnToMaiMenuButton_Click(object sender, EventArgs e)
        {
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
