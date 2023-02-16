using Microsoft.Maui.Controls;
using Microsoft.Data.Sqlite;
using System;
using System.IO;
using SQLite;

namespace Esports_App
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            string name = RealnameEntry.Text;
            string phone = PhoneEntry.Text;
            string discord = DiscordEntry.Text;
            string game = GameEntry.Text;

            // Get a connection to the SQLite database
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "PlayerLogs.db");
            SQLiteConnection conn = new SQLiteConnection(dbPath);

            // Execute a query to insert the data into the database
            conn.Execute("INSERT INTO Players (name, phone, discord, game) VALUES (?, ?, ?, ?)", name, phone, discord, game);

            // Navigate to the profile page
            await Navigation.PushAsync(new ProfilePage());
        }
    }
}