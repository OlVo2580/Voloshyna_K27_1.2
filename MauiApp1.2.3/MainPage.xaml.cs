using Microsoft.Maui.Controls;

namespace MauiApp1._2._3
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnDisplayNumberClicked(object sender, System.EventArgs e)
        {
            if (int.TryParse(NumberEntry.Text, out int n))
            {
                ResultLabel.Text = $"You entered the number {n}";
            }
            else
            {
                ResultLabel.Text = "Invalid input. Please enter an integer.";
            }
        }
    }
}
