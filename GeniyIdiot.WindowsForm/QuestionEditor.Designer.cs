namespace GeniyIdiot.WindowsForm
{
    partial class QuestionEditor
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
            questionEditorLabel = new Label();
            exitButton = new Button();
            questionEditorDataGridView = new DataGridView();
            addButton = new Button();
            deleteButton = new Button();
            questionNumber = new DataGridViewTextBoxColumn();
            questionText = new DataGridViewTextBoxColumn();
            questionAnswer = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)questionEditorDataGridView).BeginInit();
            SuspendLayout();
            // 
            // questionEditorLabel
            // 
            questionEditorLabel.AutoSize = true;
            questionEditorLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            questionEditorLabel.Location = new Point(189, 10);
            questionEditorLabel.Name = "questionEditorLabel";
            questionEditorLabel.Size = new Size(181, 25);
            questionEditorLabel.TabIndex = 8;
            questionEditorLabel.Text = "Редактор вопросов";
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            exitButton.Location = new Point(12, 443);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(77, 28);
            exitButton.TabIndex = 7;
            exitButton.Text = "Закрыть";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // questionEditorDataGridView
            // 
            questionEditorDataGridView.AllowUserToAddRows = false;
            questionEditorDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            questionEditorDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            questionEditorDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            questionEditorDataGridView.Columns.AddRange(new DataGridViewColumn[] { questionNumber, questionText, questionAnswer });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            questionEditorDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            questionEditorDataGridView.Location = new Point(12, 54);
            questionEditorDataGridView.Name = "questionEditorDataGridView";
            questionEditorDataGridView.RowHeadersVisible = false;
            questionEditorDataGridView.Size = new Size(566, 380);
            questionEditorDataGridView.TabIndex = 6;
            // 
            // addButton
            // 
            addButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addButton.Location = new Point(452, 443);
            addButton.Name = "addButton";
            addButton.Size = new Size(126, 28);
            addButton.TabIndex = 9;
            addButton.Text = "Добавить вопрос";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            deleteButton.Location = new Point(320, 443);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(126, 28);
            deleteButton.TabIndex = 10;
            deleteButton.Text = "Удалить вопрос";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // questionNumber
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            questionNumber.DefaultCellStyle = dataGridViewCellStyle2;
            questionNumber.FillWeight = 6.893415F;
            questionNumber.HeaderText = "Номер вопроса";
            questionNumber.Name = "questionNumber";
            questionNumber.Width = 67;
            // 
            // questionText
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            questionText.DefaultCellStyle = dataGridViewCellStyle3;
            questionText.FillWeight = 284.771576F;
            questionText.HeaderText = "Текст вопроса";
            questionText.Name = "questionText";
            questionText.Width = 416;
            // 
            // questionAnswer
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            questionAnswer.DefaultCellStyle = dataGridViewCellStyle4;
            questionAnswer.FillWeight = 8.335009F;
            questionAnswer.HeaderText = "Правильный ответ";
            questionAnswer.Name = "questionAnswer";
            questionAnswer.Width = 80;
            // 
            // QuestionEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 483);
            ControlBox = false;
            Controls.Add(deleteButton);
            Controls.Add(addButton);
            Controls.Add(questionEditorLabel);
            Controls.Add(exitButton);
            Controls.Add(questionEditorDataGridView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "QuestionEditor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += QuestionEditor_Load;
            ((System.ComponentModel.ISupportInitialize)questionEditorDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label questionEditorLabel;
        private Button exitButton;
        private DataGridView questionEditorDataGridView;
        private Button addButton;
        private Button deleteButton;
        private DataGridViewTextBoxColumn questionNumber;
        private DataGridViewTextBoxColumn questionText;
        private DataGridViewTextBoxColumn questionAnswer;
    }
}