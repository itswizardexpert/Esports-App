using Microsoft.Maui.Controls;

namespace Esports_App
{

    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            string username = UsernameEntry.Text;
            string password = PasswordEntry.Text;

            // Perform authentication logic here...

            // If authentication succeeds, navigate to the home page
            await Navigation.PushAsync(new HomePage());
        }
    }
}