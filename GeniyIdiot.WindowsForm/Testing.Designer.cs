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
            components = new System.ComponentModel.Container();
            userAnswerTextBox = new TextBox();
            questionNumberLabel = new Label();
            questionTextLabel = new Label();
            nextButton = new Button();
            testTimer = new System.Windows.Forms.Timer(components);
            timeLeftLabel = new Label();
            timerLabel = new Label();
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
            // testTimer
            // 
            testTimer.Enabled = true;
            testTimer.Interval = 1000;
            testTimer.Tick += testTimer_Tick;
            // 
            // timeLeftLabel
            // 
            timeLeftLabel.AutoSize = true;
            timeLeftLabel.Location = new Point(416, 9);
            timeLeftLabel.Name = "timeLeftLabel";
            timeLeftLabel.Size = new Size(113, 15);
            timeLeftLabel.TabIndex = 4;
            timeLeftLabel.Text = "Осталось времени:";
            // 
            // timerLabel
            // 
            timerLabel.AutoSize = true;
            timerLabel.Location = new Point(463, 33);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(19, 15);
            timerLabel.TabIndex = 5;
            timerLabel.Text = "10";
            // 
            // Testing
            // 
            AcceptButton = nextButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 268);
            Controls.Add(timerLabel);
            Controls.Add(timeLeftLabel);
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
        private System.Windows.Forms.Timer testTimer;
        private Label timeLeftLabel;
        private Label timerLabel;
    }
}