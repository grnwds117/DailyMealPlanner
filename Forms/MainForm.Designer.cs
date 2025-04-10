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
            label5 = new Label();
            MorningButton = new Button();
            LunchButton = new Button();
            EveningButton = new Button();
            EditUserButton = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            label1 = new Label();
            CaloriesLabel = new Label();
            CarbsLabel = new Label();
            FatsLabel = new Label();
            ProteinLabel = new Label();
            SuspendLayout();
            // 
            // UserDataLabel
            // 
            UserDataLabel.AutoSize = true;
            UserDataLabel.Font = new Font("Cambria", 10.8F, FontStyle.Bold);
            UserDataLabel.ForeColor = Color.Navy;
            UserDataLabel.Location = new Point(201, 35);
            UserDataLabel.Name = "UserDataLabel";
            UserDataLabel.Size = new Size(287, 21);
            UserDataLabel.TabIndex = 0;
            UserDataLabel.Text = "Пользовательская информация";
            // 
            // WeightLabel
            // 
            WeightLabel.AutoSize = true;
            WeightLabel.Font = new Font("Cambria", 10.2F);
            WeightLabel.Location = new Point(201, 72);
            WeightLabel.Name = "WeightLabel";
            WeightLabel.Size = new Size(43, 20);
            WeightLabel.TabIndex = 1;
            WeightLabel.Text = "Вес: ";
            // 
            // HeightLabel
            // 
            HeightLabel.AutoSize = true;
            HeightLabel.Font = new Font("Cambria", 10.2F);
            HeightLabel.Location = new Point(201, 92);
            HeightLabel.Name = "HeightLabel";
            HeightLabel.Size = new Size(88, 20);
            HeightLabel.TabIndex = 2;
            HeightLabel.Text = "Рост (см): ";
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Font = new Font("Cambria", 10.2F);
            AgeLabel.Location = new Point(201, 112);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(78, 20);
            AgeLabel.TabIndex = 3;
            AgeLabel.Text = "Возраст: ";
            // 
            // ActivityLabel
            // 
            ActivityLabel.AutoSize = true;
            ActivityLabel.Font = new Font("Cambria", 10.2F);
            ActivityLabel.Location = new Point(201, 132);
            ActivityLabel.Name = "ActivityLabel";
            ActivityLabel.Size = new Size(110, 20);
            ActivityLabel.TabIndex = 4;
            ActivityLabel.Text = "Активность: ";
            // 
            // MorningLabel
            // 
            MorningLabel.AutoSize = true;
            MorningLabel.Font = new Font("Cambria", 13.8F);
            MorningLabel.Location = new Point(35, 197);
            MorningLabel.Name = "MorningLabel";
            MorningLabel.Size = new Size(95, 27);
            MorningLabel.TabIndex = 5;
            MorningLabel.Text = "Завтрак";
            // 
            // LunchLabel
            // 
            LunchLabel.AutoSize = true;
            LunchLabel.Font = new Font("Cambria", 13.8F);
            LunchLabel.Location = new Point(58, 481);
            LunchLabel.Name = "LunchLabel";
            LunchLabel.Size = new Size(63, 27);
            LunchLabel.TabIndex = 6;
            LunchLabel.Text = "Обед";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 13.8F);
            label5.Location = new Point(51, 779);
            label5.Name = "label5";
            label5.Size = new Size(70, 27);
            label5.TabIndex = 9;
            label5.Text = "Ужин";
            // 
            // MorningButton
            // 
            MorningButton.BackColor = SystemColors.ActiveCaption;
            MorningButton.FlatAppearance.BorderSize = 0;
            MorningButton.FlatStyle = FlatStyle.Flat;
            MorningButton.Font = new Font("Cambria", 10.2F);
            MorningButton.Location = new Point(136, 197);
            MorningButton.Name = "MorningButton";
            MorningButton.Size = new Size(94, 29);
            MorningButton.TabIndex = 11;
            MorningButton.Text = "Добавить";
            MorningButton.UseVisualStyleBackColor = false;
            MorningButton.Click += MorningButton_Click;
            // 
            // LunchButton
            // 
            LunchButton.BackColor = SystemColors.ActiveCaption;
            LunchButton.FlatAppearance.BorderSize = 0;
            LunchButton.FlatStyle = FlatStyle.Flat;
            LunchButton.Font = new Font("Cambria", 10.2F);
            LunchButton.Location = new Point(136, 481);
            LunchButton.Name = "LunchButton";
            LunchButton.Size = new Size(94, 29);
            LunchButton.TabIndex = 12;
            LunchButton.Text = "Добавить";
            LunchButton.UseVisualStyleBackColor = false;
            LunchButton.Click += LunchButton_Click;
            // 
            // EveningButton
            // 
            EveningButton.BackColor = SystemColors.ActiveCaption;
            EveningButton.FlatAppearance.BorderSize = 0;
            EveningButton.FlatStyle = FlatStyle.Flat;
            EveningButton.Font = new Font("Cambria", 10.2F);
            EveningButton.Location = new Point(136, 781);
            EveningButton.Name = "EveningButton";
            EveningButton.Size = new Size(94, 29);
            EveningButton.TabIndex = 13;
            EveningButton.Text = "Добавить";
            EveningButton.UseVisualStyleBackColor = false;
            EveningButton.Click += EveningButton_Click;
            // 
            // EditUserButton
            // 
            EditUserButton.BackColor = SystemColors.ActiveCaption;
            EditUserButton.FlatAppearance.BorderSize = 0;
            EditUserButton.FlatStyle = FlatStyle.Flat;
            EditUserButton.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            EditUserButton.ForeColor = SystemColors.InfoText;
            EditUserButton.Location = new Point(35, 54);
            EditUserButton.Name = "EditUserButton";
            EditUserButton.Size = new Size(135, 57);
            EditUserButton.TabIndex = 14;
            EditUserButton.Text = "Редактировать";
            EditUserButton.UseVisualStyleBackColor = false;
            EditUserButton.Click += EditUserButton_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.BackColor = SystemColors.Info;
            flowLayoutPanel1.Location = new Point(35, 232);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(0, 0, 10, 0);
            flowLayoutPanel1.Size = new Size(1021, 220);
            flowLayoutPanel1.TabIndex = 15;
            flowLayoutPanel1.WrapContents = false;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.BackColor = SystemColors.Info;
            flowLayoutPanel2.Location = new Point(37, 522);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(0, 0, 10, 0);
            flowLayoutPanel2.Size = new Size(1019, 220);
            flowLayoutPanel2.TabIndex = 16;
            flowLayoutPanel2.WrapContents = false;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoScroll = true;
            flowLayoutPanel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel3.BackColor = SystemColors.Info;
            flowLayoutPanel3.Location = new Point(35, 834);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Padding = new Padding(0, 0, 10, 0);
            flowLayoutPanel3.Size = new Size(1021, 220);
            flowLayoutPanel3.TabIndex = 16;
            flowLayoutPanel3.WrapContents = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 10.8F, FontStyle.Bold);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(572, 35);
            label1.Name = "label1";
            label1.Size = new Size(62, 21);
            label1.TabIndex = 17;
            label1.Text = "КБЖУ";
            // 
            // CaloriesLabel
            // 
            CaloriesLabel.AutoSize = true;
            CaloriesLabel.Font = new Font("Cambria", 10.2F);
            CaloriesLabel.Location = new Point(572, 132);
            CaloriesLabel.Name = "CaloriesLabel";
            CaloriesLabel.Size = new Size(95, 20);
            CaloriesLabel.TabIndex = 21;
            CaloriesLabel.Text = "ККалории: ";
            // 
            // CarbsLabel
            // 
            CarbsLabel.AutoSize = true;
            CarbsLabel.Font = new Font("Cambria", 10.2F);
            CarbsLabel.Location = new Point(572, 112);
            CarbsLabel.Name = "CarbsLabel";
            CarbsLabel.Size = new Size(83, 20);
            CarbsLabel.TabIndex = 20;
            CarbsLabel.Text = "Углеводы";
            // 
            // FatsLabel
            // 
            FatsLabel.AutoSize = true;
            FatsLabel.Font = new Font("Cambria", 10.2F);
            FatsLabel.Location = new Point(572, 92);
            FatsLabel.Name = "FatsLabel";
            FatsLabel.Size = new Size(65, 20);
            FatsLabel.TabIndex = 19;
            FatsLabel.Text = "Жиры: ";
            // 
            // ProteinLabel
            // 
            ProteinLabel.AutoSize = true;
            ProteinLabel.Font = new Font("Cambria", 10.2F);
            ProteinLabel.Location = new Point(572, 72);
            ProteinLabel.Name = "ProteinLabel";
            ProteinLabel.Size = new Size(64, 20);
            ProteinLabel.TabIndex = 18;
            ProteinLabel.Text = "Белки: ";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1100, 1102);
            Controls.Add(CaloriesLabel);
            Controls.Add(CarbsLabel);
            Controls.Add(FatsLabel);
            Controls.Add(ProteinLabel);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(EditUserButton);
            Controls.Add(EveningButton);
            Controls.Add(LunchButton);
            Controls.Add(MorningButton);
            Controls.Add(label5);
            Controls.Add(LunchLabel);
            Controls.Add(MorningLabel);
            Controls.Add(ActivityLabel);
            Controls.Add(AgeLabel);
            Controls.Add(HeightLabel);
            Controls.Add(WeightLabel);
            Controls.Add(UserDataLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
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
        private Label label5;
        private Button MorningButton;
        private Button LunchButton;
        private Button EveningButton;
        private Button EditUserButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label label1;
        private Label CaloriesLabel;
        private Label CarbsLabel;
        private Label FatsLabel;
        private Label ProteinLabel;
    }
}