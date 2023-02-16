using Microsoft.Maui.Controls;
using System.ComponentModel;

namespace Esports_App
{
    public partial class ProfilePage : ContentPage, INotifyPropertyChanged
    {
        private string _name;
        private string _phone;
        private string _discord;
        private string _game;

        public string Name
        {
            get => _name;
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        public string Phone
        {
            get => _phone;
            set
            {
                if (_phone != value)
                {
                    _phone = value;
                    OnPropertyChanged(nameof(Phone));
                }
            }
        }

        public string Discord
        {
            get => _discord;
            set
            {
                if (_discord != value)
                {
                    _discord = value;
                    OnPropertyChanged(nameof(Discord));
                }
            }
        }

        public string Game
        {
            get => _game;
            set
            {
                if (_game != value)
                {
                    _game = value;
                    OnPropertyChanged(nameof(Game));
                }
            }
        }

        public ProfilePage()
        {
            // Set the initial values for the properties
            Name = "John Doe";
            Phone = "123-456-7890";
            Discord = "johndoe#1234";
            Game = "League of Legends";
        }

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            // Save the changes to the database or any other data store
            // You can add your custom save logic here
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}