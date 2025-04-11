using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace DailyMealPlanner.Forms
{
    public class CollapsiblePanel : UserControl
    {
        private Button toggleButton;
        private Panel contentPanel;
        private bool isCollapsed = true;

        public string Header
        {
            get => toggleButton.Text;
            set => toggleButton.Text = value;
        }

        public Panel Content => contentPanel;

        public CollapsiblePanel()
        {
            toggleButton = new Button
            {
                Dock = DockStyle.Top,
                Height = 30,
                Text = "Click to expand",
                FlatStyle = FlatStyle.Flat
            };
            toggleButton.Click += ToggleButton_Click;

            contentPanel = new Panel
            {
                Dock = DockStyle.Top,
                Visible = false,
                AutoScroll = true
            };


            this.Controls.Add(contentPanel);
            this.Controls.Add(toggleButton);
            this.Height = toggleButton.Height;
        }

        private void ToggleButton_Click(object sender, EventArgs e)
        {
            isCollapsed = !isCollapsed;
            contentPanel.Visible = !isCollapsed;

            if (!isCollapsed)
            {
                contentPanel.Height = 300; 
                this.Height = toggleButton.Height + contentPanel.Height;
            }
            else
            {
                this.Height = toggleButton.Height;
            }
        }

    }
}
