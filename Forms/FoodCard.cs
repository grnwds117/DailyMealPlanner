using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using DailyMealPlanner.Business_Layer;

namespace DailyMealPlanner.Forms
{
    public class FoodCard : UserControl
    {
        private Product _product;
        private Font _boldFont = new Font("Arial", 10, FontStyle.Bold);
        private Font _regularFont = new Font("Arial", 9);
        private const int LineHeight = 20;
        private const int StartY = 15;
        private const int ValueIndent = 80;
        private const int CornerRadius = 15;
        private readonly Color _bgColor = Color.FromArgb(240, 240, 240);

        public Product Product
        {
            get => _product;
            set
            {
                _product = value;
                Invalidate();
            }
        }

        public FoodCard()
        {
            Size = new Size(180, 150); // Уменьшили высоту, так как убрали одну строку
            BackColor = Color.Transparent;
            Padding = new Padding(10);
            DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Рисуем прямоугольник с закругленными углами
            using (var path = GetRoundedRectanglePath(new Rectangle(0, 0, Width - 1, Height - 1), CornerRadius))
            {
                using (var bgBrush = new SolidBrush(_bgColor))
                {
                    g.FillPath(bgBrush, path);
                }
                using (var borderPen = new Pen(Color.LightGray, 1))
                {
                    g.DrawPath(borderPen, path);
                }
            }

            // Заголовок продукта
            string title = _product != null ? $"# {_product.Name} #" : "# Product #";
            SizeF titleSize = g.MeasureString(title, _boldFont);
            float titleX = (Width - titleSize.Width) / 2;
            g.DrawString(title, _boldFont, Brushes.Black, titleX, StartY);

            // Параметры продукта (без "Кол-во")
            int currentY = StartY + LineHeight + 5;

            DrawLabelAndValue(g, "Масса (г):", "", ref currentY);
            DrawLabelAndValue(g, "Белки:", "", ref currentY);
            DrawLabelAndValue(g, "Углеводы:", "", ref currentY);
            DrawLabelAndValue(g, "Жиры:", "", ref currentY);
            DrawLabelAndValue(g, "Калории:", "", ref currentY);

            if (_product != null)
            {
                currentY = StartY + LineHeight + 5;
                DrawLabelAndValue(g, "", "100", ref currentY); // Масса по умолчанию 100г
                DrawLabelAndValue(g, "", _product.Proteins.ToString("0.0"), ref currentY);
                DrawLabelAndValue(g, "", _product.Carbs.ToString("0.0"), ref currentY);
                DrawLabelAndValue(g, "", _product.Fats.ToString("0.0"), ref currentY);
                DrawLabelAndValue(g, "", _product.Calories.ToString(), ref currentY);
            }
        }

        private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
        {
            var path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90);
            path.AddArc(rect.Right - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90);
            path.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void DrawLabelAndValue(Graphics g, string label, string value, ref int yPos)
        {
            if (!string.IsNullOrEmpty(label))
            {
                g.DrawString(label, _regularFont, Brushes.Black, Padding.Left, yPos);
            }

            if (!string.IsNullOrEmpty(value))
            {
                g.DrawString(value, _regularFont, Brushes.Black, ValueIndent, yPos);
            }

            yPos += LineHeight;
        }
    }
}