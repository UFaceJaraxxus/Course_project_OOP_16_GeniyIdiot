namespace GeniyIdiot.WindowsForm
{
    partial class Testing
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
            userAnswerTextBox = new TextBox();
            questionNumberLabel = new Label();
            questionTextLabel = new Label();
            nextButton = new Button();
            SuspendLayout();
            // 
            // userAnswerTextBox
            // 
            userAnswerTextBox.Location = new Point(12, 118);
            userAnswerTextBox.Name = "userAnswerTextBox";
            userAnswerTextBox.Size = new Size(100, 23);
            userAnswerTextBox.TabIndex = 0;
            // 
            // questionNumberLabel
            // 
            questionNumberLabel.AutoSize = true;
            questionNumberLabel.Location = new Point(12, 21);
            questionNumberLabel.Name = "questionNumberLabel";
            questionNumberLabel.Size = new Size(94, 15);
            questionNumberLabel.TabIndex = 1;
            questionNumberLabel.Text = "Номер вопроса";
            // 
            // questionTextLabel
            // 
            questionTextLabel.AutoSize = true;
            questionTextLabel.Location = new Point(12, 79);
            questionTextLabel.Name = "questionTextLabel";
            questionTextLabel.Size = new Size(85, 15);
            questionTextLabel.TabIndex = 2;
            questionTextLabel.Text = "Текст вопроса";
            // 
            // nextButton
            // 
            nextButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nextButton.Location = new Point(450, 228);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(76, 28);
            nextButton.TabIndex = 3;
            nextButton.Text = "Далее";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // Testing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 268);
            Controls.Add(nextButton);
            Controls.Add(questionTextLabel);
            Controls.Add(questionNumberLabel);
            Controls.Add(userAnswerTextBox);
            Name = "Testing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Гений-Идиот";
            Load += Testing_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userAnswerTextBox;
        private Label questionNumberLabel;
        private Label questionTextLabel;
        private Button nextButton;
    }
}