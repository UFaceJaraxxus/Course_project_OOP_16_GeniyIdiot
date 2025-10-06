namespace GeniyIdiot.WindowsForm
{
    partial class Authorization
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
            lastNameLabel = new Label();
            lastNameTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            firstNameLabel = new Label();
            middleNameTextBox = new TextBox();
            middleNameLabel = new Label();
            okButton = new Button();
            SuspendLayout();
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lastNameLabel.Location = new Point(12, 9);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(144, 21);
            lastNameLabel.TabIndex = 0;
            lastNameLabel.Text = "Введите фамилию:";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lastNameTextBox.Location = new Point(12, 33);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(188, 29);
            lastNameTextBox.TabIndex = 1;
            lastNameTextBox.Leave += LastNameTextBox_Leave;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            firstNameTextBox.Location = new Point(12, 105);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(188, 29);
            firstNameTextBox.TabIndex = 3;
            firstNameTextBox.Leave += FirstNameTextBox_Leave;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            firstNameLabel.Location = new Point(12, 81);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(103, 21);
            firstNameLabel.TabIndex = 2;
            firstNameLabel.Text = "Введите имя:";
            // 
            // middleNameTextBox
            // 
            middleNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            middleNameTextBox.Location = new Point(12, 180);
            middleNameTextBox.Name = "middleNameTextBox";
            middleNameTextBox.Size = new Size(188, 29);
            middleNameTextBox.TabIndex = 5;
            middleNameTextBox.Leave += MiddleNameTextBox_Leave;
            // 
            // middleNameLabel
            // 
            middleNameLabel.AutoSize = true;
            middleNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            middleNameLabel.Location = new Point(12, 156);
            middleNameLabel.Name = "middleNameLabel";
            middleNameLabel.Size = new Size(139, 21);
            middleNameLabel.TabIndex = 4;
            middleNameLabel.Text = "Введите отчество:";
            // 
            // okButton
            // 
            okButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            okButton.Location = new Point(67, 229);
            okButton.Name = "okButton";
            okButton.Size = new Size(74, 33);
            okButton.TabIndex = 6;
            okButton.Text = "Ок";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // Authorization
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(224, 274);
            Controls.Add(okButton);
            Controls.Add(middleNameTextBox);
            Controls.Add(middleNameLabel);
            Controls.Add(firstNameTextBox);
            Controls.Add(firstNameLabel);
            Controls.Add(lastNameTextBox);
            Controls.Add(lastNameLabel);
            Name = "Authorization";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Гений-Идиот";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lastNameLabel;
        private TextBox lastNameTextBox;
        private TextBox firstNameTextBox;
        private Label firstNameLabel;
        private TextBox middleNameTextBox;
        private Label middleNameLabel;
        private Button okButton;
    }
}