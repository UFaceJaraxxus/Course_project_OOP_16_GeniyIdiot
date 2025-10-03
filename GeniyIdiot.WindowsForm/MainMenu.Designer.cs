namespace GeniyIdiot.WindowsForm
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainMenuLabel = new Label();
            startButton = new Button();
            adminMenuButton = new Button();
            logButton = new Button();
            SuspendLayout();
            // 
            // mainMenuLabel
            // 
            mainMenuLabel.AutoSize = true;
            mainMenuLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            mainMenuLabel.Location = new Point(87, 32);
            mainMenuLabel.Name = "mainMenuLabel";
            mainMenuLabel.Size = new Size(137, 25);
            mainMenuLabel.TabIndex = 0;
            mainMenuLabel.Text = "Главное меню";
            // 
            // startButton
            // 
            startButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            startButton.Location = new Point(60, 73);
            startButton.Name = "startButton";
            startButton.RightToLeft = RightToLeft.No;
            startButton.Size = new Size(188, 57);
            startButton.TabIndex = 1;
            startButton.Text = "Начать тестирование";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // adminMenuButton
            // 
            adminMenuButton.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point, 204);
            adminMenuButton.Location = new Point(1, 250);
            adminMenuButton.Name = "adminMenuButton";
            adminMenuButton.Size = new Size(103, 20);
            adminMenuButton.TabIndex = 2;
            adminMenuButton.Text = "Режим администратора";
            adminMenuButton.UseVisualStyleBackColor = true;
            adminMenuButton.Click += adminMenuButton_Click;
            // 
            // logButton
            // 
            logButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            logButton.Location = new Point(60, 136);
            logButton.Name = "logButton";
            logButton.RightToLeft = RightToLeft.No;
            logButton.Size = new Size(188, 57);
            logButton.TabIndex = 3;
            logButton.Text = "Журнал тестирования";
            logButton.UseVisualStyleBackColor = true;
            logButton.Click += logButton_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 272);
            Controls.Add(logButton);
            Controls.Add(adminMenuButton);
            Controls.Add(startButton);
            Controls.Add(mainMenuLabel);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Гений-Идиот";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mainMenuLabel;
        private Button startButton;
        private Button adminMenuButton;
        private Button logButton;
    }
}
