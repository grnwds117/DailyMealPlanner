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
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = SystemColors.Info;
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
            ConfirmButton.Location = new Point(844, 28);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(213, 64);
            ConfirmButton.TabIndex = 1;
            ConfirmButton.Text = "Подтвердить и добавить";
            ConfirmButton.UseVisualStyleBackColor = true;
            ConfirmButton.Click += ConfirmButton_Click;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(844, 136);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(226, 27);
            SearchTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(843, 110);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 3;
            label1.Text = "Поиск блюда";
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(1076, 136);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(94, 29);
            SearchButton.TabIndex = 4;
            SearchButton.Text = "Поиск";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Location = new Point(848, 185);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(540, 626);
            flowLayoutPanel2.TabIndex = 5;
            // 
            // AddMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 853);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(SearchButton);
            Controls.Add(label1);
            Controls.Add(SearchTextBox);
            Controls.Add(ConfirmButton);
            Controls.Add(flowLayoutPanel1);
            Name = "AddMenuForm";
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
    }
}