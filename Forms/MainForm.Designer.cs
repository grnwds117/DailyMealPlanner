namespace DailyMealPlanner
{
    partial class MainForm
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
            UserDataLabel = new Label();
            WeightLabel = new Label();
            HeightLabel = new Label();
            AgeLabel = new Label();
            ActivityLabel = new Label();
            MorningLabel = new Label();
            LunchLabel = new Label();
            MorningPanel = new Panel();
            LunchPanel = new Panel();
            EveningPanel = new Panel();
            label5 = new Label();
            MorningButton = new Button();
            LunchButton = new Button();
            EveningButton = new Button();
            EditUserButton = new Button();
            SuspendLayout();
            // 
            // UserDataLabel
            // 
            UserDataLabel.AutoSize = true;
            UserDataLabel.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            UserDataLabel.Location = new Point(167, 23);
            UserDataLabel.Name = "UserDataLabel";
            UserDataLabel.Size = new Size(295, 23);
            UserDataLabel.TabIndex = 0;
            UserDataLabel.Text = "Пользовательская информация:";
            // 
            // WeightLabel
            // 
            WeightLabel.AutoSize = true;
            WeightLabel.Location = new Point(167, 60);
            WeightLabel.Name = "WeightLabel";
            WeightLabel.Size = new Size(40, 20);
            WeightLabel.TabIndex = 1;
            WeightLabel.Text = "Вес: ";
            // 
            // HeightLabel
            // 
            HeightLabel.AutoSize = true;
            HeightLabel.Location = new Point(167, 80);
            HeightLabel.Name = "HeightLabel";
            HeightLabel.Size = new Size(78, 20);
            HeightLabel.TabIndex = 2;
            HeightLabel.Text = "Рост (см): ";
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(167, 100);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(71, 20);
            AgeLabel.TabIndex = 3;
            AgeLabel.Text = "Возраст: ";
            // 
            // ActivityLabel
            // 
            ActivityLabel.AutoSize = true;
            ActivityLabel.Location = new Point(167, 120);
            ActivityLabel.Name = "ActivityLabel";
            ActivityLabel.Size = new Size(95, 20);
            ActivityLabel.TabIndex = 4;
            ActivityLabel.Text = "Активность: ";
            // 
            // MorningLabel
            // 
            MorningLabel.AutoSize = true;
            MorningLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MorningLabel.Location = new Point(35, 154);
            MorningLabel.Name = "MorningLabel";
            MorningLabel.Size = new Size(85, 25);
            MorningLabel.TabIndex = 5;
            MorningLabel.Text = "Morning";
            // 
            // LunchLabel
            // 
            LunchLabel.AutoSize = true;
            LunchLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LunchLabel.Location = new Point(365, 154);
            LunchLabel.Name = "LunchLabel";
            LunchLabel.Size = new Size(63, 25);
            LunchLabel.TabIndex = 6;
            LunchLabel.Text = "Lunch";
            // 
            // MorningPanel
            // 
            MorningPanel.BackColor = Color.FromArgb(255, 255, 192);
            MorningPanel.Location = new Point(35, 199);
            MorningPanel.Name = "MorningPanel";
            MorningPanel.Size = new Size(300, 500);
            MorningPanel.TabIndex = 7;
            // 
            // LunchPanel
            // 
            LunchPanel.BackColor = Color.FromArgb(255, 255, 192);
            LunchPanel.Location = new Point(365, 199);
            LunchPanel.Name = "LunchPanel";
            LunchPanel.Size = new Size(300, 500);
            LunchPanel.TabIndex = 8;
            // 
            // EveningPanel
            // 
            EveningPanel.BackColor = Color.FromArgb(255, 255, 192);
            EveningPanel.Location = new Point(697, 199);
            EveningPanel.Margin = new Padding(0);
            EveningPanel.Name = "EveningPanel";
            EveningPanel.Padding = new Padding(0, 0, 0, 200);
            EveningPanel.Size = new Size(300, 500);
            EveningPanel.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(697, 154);
            label5.Name = "label5";
            label5.Size = new Size(80, 25);
            label5.TabIndex = 9;
            label5.Text = "Evening";
            // 
            // MorningButton
            // 
            MorningButton.Location = new Point(126, 154);
            MorningButton.Name = "MorningButton";
            MorningButton.Size = new Size(94, 29);
            MorningButton.TabIndex = 11;
            MorningButton.Text = "Добавить";
            MorningButton.UseVisualStyleBackColor = true;
            // 
            // LunchButton
            // 
            LunchButton.Location = new Point(447, 154);
            LunchButton.Name = "LunchButton";
            LunchButton.Size = new Size(94, 29);
            LunchButton.TabIndex = 12;
            LunchButton.Text = "Добавить";
            LunchButton.UseVisualStyleBackColor = true;
            // 
            // EveningButton
            // 
            EveningButton.Location = new Point(793, 154);
            EveningButton.Name = "EveningButton";
            EveningButton.Size = new Size(94, 29);
            EveningButton.TabIndex = 13;
            EveningButton.Text = "Добавить";
            EveningButton.UseVisualStyleBackColor = true;
            // 
            // EditUserButton
            // 
            EditUserButton.Location = new Point(12, 60);
            EditUserButton.Name = "EditUserButton";
            EditUserButton.Size = new Size(135, 57);
            EditUserButton.TabIndex = 14;
            EditUserButton.Text = "Редактировать информацию";
            EditUserButton.UseVisualStyleBackColor = true;
            EditUserButton.Click += EditUserButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1582, 853);
            Controls.Add(EditUserButton);
            Controls.Add(EveningButton);
            Controls.Add(LunchButton);
            Controls.Add(MorningButton);
            Controls.Add(EveningPanel);
            Controls.Add(label5);
            Controls.Add(LunchPanel);
            Controls.Add(MorningPanel);
            Controls.Add(LunchLabel);
            Controls.Add(MorningLabel);
            Controls.Add(ActivityLabel);
            Controls.Add(AgeLabel);
            Controls.Add(HeightLabel);
            Controls.Add(WeightLabel);
            Controls.Add(UserDataLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UserDataLabel;
        private Label WeightLabel;
        private Label HeightLabel;
        private Label AgeLabel;
        private Label ActivityLabel;
        private Label MorningLabel;
        private Label LunchLabel;
        private Panel MorningPanel;
        private Panel LunchPanel;
        private Panel EveningPanel;
        private Label label5;
        private Button MorningButton;
        private Button LunchButton;
        private Button EveningButton;
        private Button EditUserButton;
    }
}