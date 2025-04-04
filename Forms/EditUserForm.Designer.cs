namespace DailyMealPlanner.Forms
{
    partial class EditUserForm
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
            WeightTextBox = new TextBox();
            WeightLabel = new Label();
            HeightLabel = new Label();
            HeightTextBox = new TextBox();
            AgeLabel = new Label();
            AgeTextBox = new TextBox();
            ActivityLabel = new Label();
            ActivityTextBox = new TextBox();
            SaveButton = new Button();
            SuspendLayout();
            // 
            // WeightTextBox
            // 
            WeightTextBox.Location = new Point(107, 64);
            WeightTextBox.Name = "WeightTextBox";
            WeightTextBox.Size = new Size(182, 27);
            WeightTextBox.TabIndex = 0;
            // 
            // WeightLabel
            // 
            WeightLabel.AutoSize = true;
            WeightLabel.Location = new Point(36, 67);
            WeightLabel.Name = "WeightLabel";
            WeightLabel.Size = new Size(33, 20);
            WeightLabel.TabIndex = 1;
            WeightLabel.Text = "Вес";
            // 
            // HeightLabel
            // 
            HeightLabel.AutoSize = true;
            HeightLabel.Location = new Point(36, 138);
            HeightLabel.Name = "HeightLabel";
            HeightLabel.Size = new Size(39, 20);
            HeightLabel.TabIndex = 3;
            HeightLabel.Text = "Рост";
            // 
            // HeightTextBox
            // 
            HeightTextBox.Location = new Point(107, 131);
            HeightTextBox.Name = "HeightTextBox";
            HeightTextBox.Size = new Size(182, 27);
            HeightTextBox.TabIndex = 2;
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(23, 207);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(64, 20);
            AgeLabel.TabIndex = 5;
            AgeLabel.Text = "Возраст";
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(107, 204);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.Size = new Size(182, 27);
            AgeTextBox.TabIndex = 4;
            // 
            // ActivityLabel
            // 
            ActivityLabel.AutoSize = true;
            ActivityLabel.Location = new Point(13, 275);
            ActivityLabel.Name = "ActivityLabel";
            ActivityLabel.Size = new Size(88, 20);
            ActivityLabel.TabIndex = 7;
            ActivityLabel.Text = "Активность";
            // 
            // ActivityTextBox
            // 
            ActivityTextBox.Location = new Point(107, 272);
            ActivityTextBox.Name = "ActivityTextBox";
            ActivityTextBox.Size = new Size(182, 27);
            ActivityTextBox.TabIndex = 6;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(138, 335);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(94, 29);
            SaveButton.TabIndex = 8;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // EditUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 376);
            Controls.Add(SaveButton);
            Controls.Add(ActivityLabel);
            Controls.Add(ActivityTextBox);
            Controls.Add(AgeLabel);
            Controls.Add(AgeTextBox);
            Controls.Add(HeightLabel);
            Controls.Add(HeightTextBox);
            Controls.Add(WeightLabel);
            Controls.Add(WeightTextBox);
            Name = "EditUserForm";
            Text = "EditUserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox WeightTextBox;
        private Label WeightLabel;
        private Label HeightLabel;
        private TextBox HeightTextBox;
        private Label AgeLabel;
        private TextBox AgeTextBox;
        private Label ActivityLabel;
        private TextBox ActivityTextBox;
        private Button SaveButton;
    }
}