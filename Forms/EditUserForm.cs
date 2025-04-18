namespace DailyMealPlanner.Forms
{
    public partial class EditUserForm : Form
    {
        private User currentUser;

        public EditUserForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            LoadUserData();
        }

        private void LoadUserData()
        {
            WeightTextBox.Text = currentUser.Weight.ToString();
            HeightTextBox.Text = currentUser.Height.ToString();
            AgeTextBox.Text = currentUser.Age.ToString();
            ActivityComboBox.Text = currentUser.Activity;
        }

        private bool ValidateInput()
        {
            int temp;
            if (string.IsNullOrWhiteSpace(WeightTextBox.Text) ||
                string.IsNullOrWhiteSpace(HeightTextBox.Text) ||
                string.IsNullOrWhiteSpace(AgeTextBox.Text) ||
                !int.TryParse(WeightTextBox.Text, out temp) ||
                !int.TryParse(HeightTextBox.Text, out temp) ||
                !int.TryParse(AgeTextBox.Text, out temp))
            {
                errorLabel.Text = "Некоторые данные введены некорректно";
                return false;
            }

            errorLabel.Text = "";
            return true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }

            currentUser.Weight = int.Parse(WeightTextBox.Text);
            currentUser.Height = int.Parse(HeightTextBox.Text);
            currentUser.Age = int.Parse(AgeTextBox.Text);
            currentUser.Activity = ActivityComboBox.Text;

            currentUser.SaveToXml("user.xml");
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
