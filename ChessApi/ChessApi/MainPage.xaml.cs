using ChessApi.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            LastSearchesListview.ItemsSource = lastSearches;
        }

        public ObservableCollection<string> lastSearches = new ObservableCollection<string>();
        private static string username;
        public async void UserSearchButton(object sender, EventArgs e)
        {
            username = usernameInput.Text;
            username = username.Replace(" ", "");
            if(lastSearches.Contains(username))
            {
                lastSearches.Remove(username);
                lastSearches.Insert(0, username);
            }
            else
            {
            lastSearches.Insert(0, username);
            }
            if (lastSearches.Count >= 5){
                lastSearches.RemoveAt(4);
            }

            await Navigation.PushAsync(new DetailPage());
        }
        public static string RestUrl => "https://api.chess.com/pub/player/" + username;
        public static string StatsUrl => "https://api.chess.com/pub/player/" + username + "/stats";
    }
}
