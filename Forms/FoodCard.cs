using DailyMealPlanner.Business_Layer;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

// 
// Кастомный виджет для отображения информации о продукте в виде карточки
//
public class FoodCard : UserControl
{
    private Product _product;
    private bool isSelected;

    private readonly Font _boldFont = new Font("Arial", 10, FontStyle.Bold);
    private readonly Font _regularFont = new Font("Arial", 9);
    private readonly Color _defaultBgColor = Color.FromArgb(240, 240, 240);
    private const int LineHeight = 20;
    private const int StartY = 15;
    private const int ValueIndent = 80;
    private const int CornerRadius = 15;

    private Button closeButton;

    public Product Product
    {
        get => _product;
        set
        {
            _product = value;
            Invalidate();
        }
    }

    public bool IsSelected => isSelected;

    public event Action<FoodCard> RemoveFoodCard;

    public FoodCard()
    {
        Size = new Size(180, 150);
        BackColor = _defaultBgColor;
        Padding = new Padding(10);
        DoubleBuffered = true;

        closeButton = new Button
        {
            Size = new Size(20, 20),
            Text = "X",
            BackColor = Color.Red,
            ForeColor = Color.White,
            FlatStyle = FlatStyle.Flat,
            Anchor = AnchorStyles.Bottom | AnchorStyles.Right
        };
        closeButton.FlatAppearance.BorderSize = 0;
        closeButton.Location = new Point(Width - 30, Height - 30);
        closeButton.Click += CloseButton_Click;

        Controls.Add(closeButton);

        this.Click += FoodCard_Click;
        foreach (Control ctrl in Controls)
        {
            ctrl.Click += FoodCard_Click;
        }
    }

    private void FoodCard_Click(object sender, EventArgs e)
    {
        isSelected = !isSelected;
        BackColor = isSelected ? Color.LightBlue : _defaultBgColor;
    }

    private void CloseButton_Click(object sender, EventArgs e)
    {
        RemoveFoodCard?.Invoke(this);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Graphics g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        using (var path = GetRoundedRectanglePath(new Rectangle(0, 0, Width - 1, Height - 1), CornerRadius))
        {
            using (var bgBrush = new SolidBrush(BackColor))
            {
                g.FillPath(bgBrush, path);
            }

            using (var borderPen = new Pen(Color.LightGray, 1))
            {
                g.DrawPath(borderPen, path);
            }
        }

        string title = _product != null ? _product.Name : "Продукт";
        string trimmedTitle = TrimTextToFit(g, title, _boldFont, Width - Padding.Left - Padding.Right);

        SizeF titleSize = g.MeasureString(trimmedTitle, _boldFont);
        float titleX = (Width - titleSize.Width) / 2;
        g.DrawString(trimmedTitle, _boldFont, Brushes.Black, titleX, StartY);

        int currentY = StartY + LineHeight + 5;

        if (_product != null)
        {
            DrawLabelAndValue(g, "Масса (г):", "100", ref currentY);
            DrawLabelAndValue(g, "Белки:", _product.Proteins.ToString("0.0"), ref currentY);
            DrawLabelAndValue(g, "Углеводы:", _product.Carbs.ToString("0.0"), ref currentY);
            DrawLabelAndValue(g, "Жиры:", _product.Fats.ToString("0.0"), ref currentY);
            DrawLabelAndValue(g, "Калории:", _product.Calories.ToString(), ref currentY);
        }
    }

    private string TrimTextToFit(Graphics g, string text, Font font, int maxWidth)
    {
        string ellipsis = "...";
        if (g.MeasureString(text, font).Width <= maxWidth)
            return text;

        for (int i = text.Length - 1; i > 0; i--)
        {
            string subText = text.Substring(0, i) + ellipsis;
            if (g.MeasureString(subText, font).Width <= maxWidth)
                return subText;
        }

        return ellipsis; // если даже одна буква не помещается
    }

    private void DrawLabelAndValue(Graphics g, string label, string value, ref int yPos)
    {
        g.DrawString(label, _regularFont, Brushes.Black, Padding.Left, yPos);
        g.DrawString(value, _regularFont, Brushes.Black, ValueIndent, yPos);
        yPos += LineHeight;
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
}
