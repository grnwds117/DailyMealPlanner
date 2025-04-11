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
            DailyCaloriesLabel = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // UserDataLabel
            // 
            UserDataLabel.AutoSize = true;
            UserDataLabel.Font = new Font("Cambria", 10.8F, FontStyle.Bold);
            UserDataLabel.ForeColor = Color.Navy;
            UserDataLabel.Location = new Point(200, 48);
            UserDataLabel.Name = "UserDataLabel";
            UserDataLabel.Size = new Size(287, 21);
            UserDataLabel.TabIndex = 0;
            UserDataLabel.Text = "Пользовательская информация";
            // 
            // WeightLabel
            // 
            WeightLabel.AutoSize = true;
            WeightLabel.Font = new Font("Cambria", 10.2F);
            WeightLabel.Location = new Point(201, 69);
            WeightLabel.Name = "WeightLabel";
            WeightLabel.Size = new Size(43, 20);
            WeightLabel.TabIndex = 1;
            WeightLabel.Text = "Вес: ";
            // 
            // HeightLabel
            // 
            HeightLabel.AutoSize = true;
            HeightLabel.Font = new Font("Cambria", 10.2F);
            HeightLabel.Location = new Point(201, 89);
            HeightLabel.Name = "HeightLabel";
            HeightLabel.Size = new Size(88, 20);
            HeightLabel.TabIndex = 2;
            HeightLabel.Text = "Рост (см): ";
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Font = new Font("Cambria", 10.2F);
            AgeLabel.Location = new Point(201, 109);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(78, 20);
            AgeLabel.TabIndex = 3;
            AgeLabel.Text = "Возраст: ";
            // 
            // ActivityLabel
            // 
            ActivityLabel.AutoSize = true;
            ActivityLabel.Font = new Font("Cambria", 10.2F);
            ActivityLabel.Location = new Point(201, 129);
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
            label5.Location = new Point(51, 763);
            label5.Name = "label5";
            label5.Size = new Size(70, 27);
            label5.TabIndex = 9;
            label5.Text = "Ужин";
            // 
            // MorningButton
            // 
            MorningButton.BackColor = SystemColors.Info;
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
            LunchButton.BackColor = SystemColors.Info;
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
            EveningButton.BackColor = SystemColors.Info;
            EveningButton.FlatAppearance.BorderSize = 0;
            EveningButton.FlatStyle = FlatStyle.Flat;
            EveningButton.Font = new Font("Cambria", 10.2F);
            EveningButton.Location = new Point(136, 765);
            EveningButton.Name = "EveningButton";
            EveningButton.Size = new Size(94, 29);
            EveningButton.TabIndex = 13;
            EveningButton.Text = "Добавить";
            EveningButton.UseVisualStyleBackColor = false;
            EveningButton.Click += EveningButton_Click;
            // 
            // EditUserButton
            // 
            EditUserButton.BackColor = Color.Transparent;
            EditUserButton.FlatStyle = FlatStyle.Flat;
            EditUserButton.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            EditUserButton.ForeColor = SystemColors.InfoText;
            EditUserButton.Location = new Point(35, 69);
            EditUserButton.Name = "EditUserButton";
            EditUserButton.Size = new Size(145, 80);
            EditUserButton.TabIndex = 14;
            EditUserButton.Text = "Редактировать информацию";
            EditUserButton.UseVisualStyleBackColor = false;
            EditUserButton.Click += EditUserButton_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.BackColor = SystemColors.Info;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
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
            flowLayoutPanel2.BorderStyle = BorderStyle.FixedSingle;
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
            flowLayoutPanel3.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel3.Location = new Point(35, 808);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Padding = new Padding(0, 0, 10, 0);
            flowLayoutPanel3.Size = new Size(1021, 235);
            flowLayoutPanel3.TabIndex = 16;
            flowLayoutPanel3.WrapContents = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 10.8F, FontStyle.Bold);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(537, 49);
            label1.Name = "label1";
            label1.Size = new Size(62, 21);
            label1.TabIndex = 17;
            label1.Text = "КБЖУ";
            // 
            // CaloriesLabel
            // 
            CaloriesLabel.AutoSize = true;
            CaloriesLabel.Font = new Font("Cambria", 10.2F);
            CaloriesLabel.Location = new Point(537, 140);
            CaloriesLabel.Name = "CaloriesLabel";
            CaloriesLabel.Size = new Size(95, 20);
            CaloriesLabel.TabIndex = 21;
            CaloriesLabel.Text = "ККалории: ";
            // 
            // CarbsLabel
            // 
            CarbsLabel.AutoSize = true;
            CarbsLabel.Font = new Font("Cambria", 10.2F);
            CarbsLabel.Location = new Point(537, 120);
            CarbsLabel.Name = "CarbsLabel";
            CarbsLabel.Size = new Size(83, 20);
            CarbsLabel.TabIndex = 20;
            CarbsLabel.Text = "Углеводы";
            // 
            // FatsLabel
            // 
            FatsLabel.AutoSize = true;
            FatsLabel.Font = new Font("Cambria", 10.2F);
            FatsLabel.Location = new Point(537, 100);
            FatsLabel.Name = "FatsLabel";
            FatsLabel.Size = new Size(65, 20);
            FatsLabel.TabIndex = 19;
            FatsLabel.Text = "Жиры: ";
            // 
            // ProteinLabel
            // 
            ProteinLabel.AutoSize = true;
            ProteinLabel.Font = new Font("Cambria", 10.2F);
            ProteinLabel.Location = new Point(537, 80);
            ProteinLabel.Name = "ProteinLabel";
            ProteinLabel.Size = new Size(64, 20);
            ProteinLabel.TabIndex = 18;
            ProteinLabel.Text = "Белки: ";
            // 
            // DailyCaloriesLabel
            // 
            DailyCaloriesLabel.AutoSize = true;
            DailyCaloriesLabel.Font = new Font("Cambria", 10.2F);
            DailyCaloriesLabel.Location = new Point(201, 149);
            DailyCaloriesLabel.Name = "DailyCaloriesLabel";
            DailyCaloriesLabel.Size = new Size(202, 20);
            DailyCaloriesLabel.TabIndex = 22;
            DailyCaloriesLabel.Text = "Дневная норма калорий: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(794, 21);
            label2.Name = "label2";
            label2.Size = new Size(262, 35);
            label2.TabIndex = 23;
            label2.Text = "Daily Meal Planner";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1100, 1055);
            Controls.Add(label2);
            Controls.Add(DailyCaloriesLabel);
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
            StartPosition = FormStartPosition.CenterScreen;
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
        private Label DailyCaloriesLabel;
        private Label label2;
    }
}