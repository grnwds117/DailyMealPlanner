using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DailyMealPlanner.Business_Layer;

namespace DailyMealPlanner.Forms
{
    public partial class AddMenuForm : Form
    {
        private List<Category> categories;
        private MealTime mealTime;
        private List<Product> selectedProducts = new List<Product>();
        public AddMenuForm(List<Category> md, MealTime mt)
        {
            InitializeComponent();
            categories = md;
            mealTime = mt;
            LoadCategories();
        }

        private void LoadCategories()
        {
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // Заполняет flowLayoutPanel объектами типа CollapsiblePanel,
            // содержащие название категории и список продуктов

            foreach (var category in categories)
            {
                var collapsiblePanel = new CollapsiblePanel
                {
                    Header = category.Name,
                    Width = flowLayoutPanel1.ClientSize.Width - 25,
                    Margin = new Padding(5)
                };

                FlowLayoutPanel productPanel = new FlowLayoutPanel
                {
                    Dock = DockStyle.Top,
                    AutoSize = true,
                    FlowDirection = FlowDirection.LeftToRight,
                    WrapContents = true,
                    Padding = new Padding(10),
                    Margin = new Padding(5)
                };

                foreach (var product in category.Products)
                {
                    var foodCard = new FoodCard
                    {
                        Product = product,
                        Width = 180,
                        Margin = new Padding(5)
                    };

                    foodCard.Click += (s, e) =>
                    {
                        if (foodCard.IsSelected)
                        {
                            if (!selectedProducts.Contains(product))
                                selectedProducts.Add(product);
                        }
                        else
                        {
                            selectedProducts.Remove(product);
                        }

                        UpdateSelectedProductsPanel();
                    };

                    productPanel.Controls.Add(foodCard);
                }

                collapsiblePanel.Content.Controls.Add(productPanel);
                flowLayoutPanel1.Controls.Add(collapsiblePanel);
            }
        }

        // Отображение выбранных продуктов
        private void UpdateSelectedProductsPanel()
        {
            flowLayoutPanel3.Controls.Clear(); 

            foreach (var product in selectedProducts)
            {
                var label = new Label
                {
                    Text = product.Name,
                    AutoSize = true,
                    Font = new Font("Segoe UI", 10),
                    Margin = new Padding(5)
                };
                flowLayoutPanel3.Controls.Add(label);
            }
        }


        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            foreach (var product in selectedProducts)
            {
                if (!mealTime.SelectedProducts.Contains(product))
                    mealTime.SelectedProducts.Add(product);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchText = SearchTextBox.Text.ToLower().Trim();
            flowLayoutPanel2.Controls.Clear(); 

            if (string.IsNullOrWhiteSpace(searchText))
                return;

            foreach (var category in categories)
            {
                foreach (var product in category.Products)
                {
                    if (product.Name.ToLower().Contains(searchText))
                    {
                        var foodCard = new FoodCard
                        {
                            Product = product,
                            Width = 180,
                            Margin = new Padding(5)
                        };

                        foodCard.Click += (s, args) =>
                        {
                            if (foodCard.IsSelected)
                            {
                                if (!selectedProducts.Contains(product))
                                    selectedProducts.Add(product);
                            }
                            else
                            {
                                selectedProducts.Remove(product);
                            }

                            UpdateSelectedProductsPanel();
                        };

                        flowLayoutPanel2.Controls.Add(foodCard);
                    }
                }
            }
        }

    }
}
