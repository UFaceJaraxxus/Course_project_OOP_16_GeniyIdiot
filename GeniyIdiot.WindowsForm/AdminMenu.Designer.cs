namespace GeniyIdiot.WindowsForm
{
    partial class AdminMenu
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
            adminMenuLabel = new Label();
            questionEditorButton = new Button();
            returnToMaiMenuButton = new Button();
            SuspendLayout();
            // 
            // adminMenuLabel
            // 
            adminMenuLabel.AutoSize = true;
            adminMenuLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            adminMenuLabel.Location = new Point(45, 25);
            adminMenuLabel.Name = "adminMenuLabel";
            adminMenuLabel.Size = new Size(214, 25);
            adminMenuLabel.TabIndex = 1;
            adminMenuLabel.Text = "Меню администратора";
            // 
            // questionEditorButton
            // 
            questionEditorButton.Font = new Font("Segoe UI", 9.75F);
            questionEditorButton.Location = new Point(55, 64);
            questionEditorButton.Name = "questionEditorButton";
            questionEditorButton.RightToLeft = RightToLeft.No;
            questionEditorButton.Size = new Size(188, 37);
            questionEditorButton.TabIndex = 5;
            questionEditorButton.Text = "Редактор вопросов";
            questionEditorButton.UseVisualStyleBackColor = true;
            questionEditorButton.Click += questionEditorButton_Click;
            // 
            // returnToMaiMenuButton
            // 
            returnToMaiMenuButton.Font = new Font("Segoe UI", 9.75F);
            returnToMaiMenuButton.Location = new Point(55, 107);
            returnToMaiMenuButton.Name = "returnToMaiMenuButton";
            returnToMaiMenuButton.RightToLeft = RightToLeft.No;
            returnToMaiMenuButton.Size = new Size(188, 37);
            returnToMaiMenuButton.TabIndex = 7;
            returnToMaiMenuButton.Text = "Вернуться в главное меню";
            returnToMaiMenuButton.UseVisualStyleBackColor = true;
            returnToMaiMenuButton.Click += returnToMainMenuButton_Click;
            // 
            // AdminMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 169);
            ControlBox = false;
            Controls.Add(returnToMaiMenuButton);
            Controls.Add(questionEditorButton);
            Controls.Add(adminMenuLabel);
            Name = "AdminMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Гений-Идиот";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label adminMenuLabel;
        private Button startButton;
        private Button questionEditorButton;
        private Button returnToMaiMenuButton;
    }
}