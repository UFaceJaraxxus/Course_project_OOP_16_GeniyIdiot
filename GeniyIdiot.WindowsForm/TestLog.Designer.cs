namespace GeniyIdiot.WindowsForm
{
    partial class TestLog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            testLogDataGridView = new DataGridView();
            returnToMainMenuButton = new Button();
            testLogLabel = new Label();
            lastName_firstName_middleName = new DataGridViewTextBoxColumn();
            Score = new DataGridViewTextBoxColumn();
            Result = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)testLogDataGridView).BeginInit();
            SuspendLayout();
            // 
            // testLogDataGridView
            // 
            testLogDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            testLogDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            testLogDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            testLogDataGridView.Columns.AddRange(new DataGridViewColumn[] { lastName_firstName_middleName, Score, Result });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            testLogDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            testLogDataGridView.Location = new Point(12, 53);
            testLogDataGridView.Name = "testLogDataGridView";
            testLogDataGridView.RowHeadersVisible = false;
            testLogDataGridView.Size = new Size(566, 380);
            testLogDataGridView.TabIndex = 0;
            // 
            // returnToMainMenuButton
            // 
            returnToMainMenuButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            returnToMainMenuButton.Location = new Point(245, 443);
            returnToMainMenuButton.Name = "returnToMainMenuButton";
            returnToMainMenuButton.Size = new Size(77, 28);
            returnToMainMenuButton.TabIndex = 4;
            returnToMainMenuButton.Text = "Закрыть";
            returnToMainMenuButton.UseVisualStyleBackColor = true;
            returnToMainMenuButton.Click += returnToMainMenuButton_Click;
            // 
            // testLogLabel
            // 
            testLogLabel.AutoSize = true;
            testLogLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            testLogLabel.Location = new Point(189, 9);
            testLogLabel.Name = "testLogLabel";
            testLogLabel.Size = new Size(204, 25);
            testLogLabel.TabIndex = 5;
            testLogLabel.Text = "Журнал тестирования";
            // 
            // lastName_firstName_middleName
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter;
            lastName_firstName_middleName.DefaultCellStyle = dataGridViewCellStyle2;
            lastName_firstName_middleName.HeaderText = "Фамилия Имя Отчество";
            lastName_firstName_middleName.Name = "lastName_firstName_middleName";
            lastName_firstName_middleName.Width = 416;
            // 
            // Score
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopCenter;
            Score.DefaultCellStyle = dataGridViewCellStyle3;
            Score.HeaderText = "Баллы";
            Score.Name = "Score";
            Score.Width = 67;
            // 
            // Result
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Result.DefaultCellStyle = dataGridViewCellStyle4;
            Result.HeaderText = "Диагноз";
            Result.Name = "Result";
            Result.Width = 80;
            // 
            // TestLog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 483);
            ControlBox = false;
            Controls.Add(testLogLabel);
            Controls.Add(returnToMainMenuButton);
            Controls.Add(testLogDataGridView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TestLog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Гений-Идиот";
            Load += testLogForm_Load;
            ((System.ComponentModel.ISupportInitialize)testLogDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView testLogDataGridView;
        private Button returnToMainMenuButton;
        private Label testLogLabel;
        private DataGridViewTextBoxColumn lastName_firstName_middleName;
        private DataGridViewTextBoxColumn Score;
        private DataGridViewTextBoxColumn Result;
    }
}