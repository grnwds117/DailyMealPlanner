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
            panel1 = new Panel();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(23, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(557, 508);
            panel1.TabIndex = 0;
            // 
            // AddMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 553);
            Controls.Add(panel1);
            Name = "AddMenuForm";
            Text = "AddMenuForm";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
    }
}