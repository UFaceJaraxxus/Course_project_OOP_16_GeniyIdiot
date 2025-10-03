namespace GeniyIdiot.WindowsForm
{
    partial class AddQuestion
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
            newQuestionTextBox = new TextBox();
            newQuestionLabel = new Label();
            newAnswerTextBox = new TextBox();
            newAnswerTextLabel = new Label();
            cancelButton = new Button();
            addButton = new Button();
            SuspendLayout();
            // 
            // newQuestionTextBox
            // 
            newQuestionTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            newQuestionTextBox.Location = new Point(12, 43);
            newQuestionTextBox.Name = "newQuestionTextBox";
            newQuestionTextBox.Size = new Size(515, 29);
            newQuestionTextBox.TabIndex = 8;
            // 
            // newQuestionLabel
            // 
            newQuestionLabel.AutoSize = true;
            newQuestionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            newQuestionLabel.Location = new Point(12, 19);
            newQuestionLabel.Name = "newQuestionLabel";
            newQuestionLabel.Size = new Size(175, 21);
            newQuestionLabel.TabIndex = 7;
            newQuestionLabel.Text = "Введите текст вопроса:";
            // 
            // newAnswerTextBox
            // 
            newAnswerTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            newAnswerTextBox.Location = new Point(12, 108);
            newAnswerTextBox.Name = "newAnswerTextBox";
            newAnswerTextBox.Size = new Size(155, 29);
            newAnswerTextBox.TabIndex = 11;
            // 
            // newAnswerTextLabel
            // 
            newAnswerTextLabel.AutoSize = true;
            newAnswerTextLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            newAnswerTextLabel.Location = new Point(12, 84);
            newAnswerTextLabel.Name = "newAnswerTextLabel";
            newAnswerTextLabel.Size = new Size(206, 21);
            newAnswerTextLabel.TabIndex = 10;
            newAnswerTextLabel.Text = "Введите правильный ответ:";
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(12, 172);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 13;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(452, 172);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 12;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // AddQuestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 207);
            ControlBox = false;
            Controls.Add(cancelButton);
            Controls.Add(addButton);
            Controls.Add(newAnswerTextBox);
            Controls.Add(newAnswerTextLabel);
            Controls.Add(newQuestionTextBox);
            Controls.Add(newQuestionLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddQuestion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Гений-Идиот";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox newQuestionTextBox;
        private Label newQuestionLabel;
        private TextBox newAnswerTextBox;
        private Label newAnswerTextLabel;
        private Button cancelButton;
        private Button addButton;
    }
}