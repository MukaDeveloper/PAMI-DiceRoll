namespace DiceRoller
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void onDiceRoll(object sender, EventArgs e)
        {
            int faces = (int) picker.SelectedItem;
            Random rnd = new Random();
            int random = rnd.Next(1, faces + 1);
            diceValueLabel.Text = random.ToString();
        }
    }

}
