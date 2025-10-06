namespace GeniyIdiot.WindowsForm
{
    partial class PasswordWindow
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
            passwordLabel = new Label();
            passwordTextBox = new TextBox();
            okButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(12, 9);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(96, 15);
            passwordLabel.TabIndex = 0;
            passwordLabel.Text = "Введите пароль:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(12, 37);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(156, 23);
            passwordTextBox.TabIndex = 1;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // okButton
            // 
            okButton.Location = new Point(126, 74);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 2;
            okButton.Text = "ОК";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(12, 74);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 3;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // PasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(213, 109);
            ControlBox = false;
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(passwordTextBox);
            Controls.Add(passwordLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label passwordLabel;
        private TextBox passwordTextBox;
        private Button okButton;
        private Button cancelButton;
    }
}