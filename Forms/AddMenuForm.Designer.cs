namespace DailyMealPlanner.Forms
{
    partial class AddMenuForm
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            categoryBindingSource = new BindingSource(components);
            ConfirmButton = new Button();
            SearchTextBox = new TextBox();
            label1 = new Label();
            SearchButton = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label2 = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = SystemColors.Info;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.DataBindings.Add(new Binding("DataContext", categoryBindingSource, "", true));
            flowLayoutPanel1.Location = new Point(25, 28);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(804, 783);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(Business_Layer.Category);
            // 
            // ConfirmButton
            // 
            ConfirmButton.Location = new Point(1187, 571);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(208, 29);
            ConfirmButton.TabIndex = 1;
            ConfirmButton.Text = "Подтвердить и добавить";
            ConfirmButton.UseVisualStyleBackColor = true;
            ConfirmButton.Click += ConfirmButton_Click;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(856, 54);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(226, 27);
            SearchTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(855, 28);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 3;
            label1.Text = "Поиск блюда";
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(1116, 52);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(94, 29);
            SearchButton.TabIndex = 4;
            SearchButton.Text = "Поиск";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.BackColor = SystemColors.Info;
            flowLayoutPanel2.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel2.Location = new Point(855, 103);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(540, 441);
            flowLayoutPanel2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(855, 574);
            label2.Name = "label2";
            label2.Size = new Size(143, 22);
            label2.TabIndex = 6;
            label2.Text = "Выбранные блюда";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel3.Location = new Point(855, 606);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(540, 205);
            flowLayoutPanel3.TabIndex = 8;
            // 
            // AddMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 853);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(label2);
            Controls.Add(ConfirmButton);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(SearchButton);
            Controls.Add(label1);
            Controls.Add(SearchTextBox);
            Controls.Add(flowLayoutPanel1);
            MaximizeBox = false;
            Name = "AddMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddMenuForm";
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private BindingSource categoryBindingSource;
        private Button ConfirmButton;
        private TextBox SearchTextBox;
        private Label label1;
        private Button SearchButton;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel3;
    }
}