using ChessApi.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ChessApi
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public List<string> lastUsers = new List<string>();
        private static string username;
        public async void UserSearchButton(object sender, EventArgs e)
        {
            username = usernameInput.Text;
            username = username.Replace(" ", "");
            lastUsers.Add(username);

            await Navigation.PushAsync(new DetailPage());
        }
        public static string RestUrl => "https://api.chess.com/pub/player/" + username;
        public static string StatsUrl => "https://api.chess.com/pub/player/" + username + "/stats";
    }
}
