using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChessApi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : TabbedPage
    {
        public DetailPage()
        {
            InitializeComponent();
            activityIndicator.IsRunning = true;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            var result = await App.RestApiService.GetUserProfileAsync("");
            var statResult = await App.RestApiService.GetStatsAsync("");

            //avatar
            usernameLabel.Text = $"{result.username}";
            if(result.avatar == null)
            {
                avatarImage.Source = "noavatar.png";
            }
            else
            {
            avatarImage.Source = $"{result.avatar}";
            }

            //data dołączenia
            DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(result.joined);
            DateTime date = dateTimeOffset.LocalDateTime;
            string dateString = date.ToString("dd.MM.yyyy");
            JoinDate.Text = $"Joined: {dateString}";

            StatsLabel.Text = "Statistics";

            //league image
            string league = result.league;
            league = league.ToLower();
            leagueImage.Source = $"{league}.png";

            //rapid games info
            rapidRating.Text = $"Rapid: {statResult.chess_rapid.Last.rating}";
            rapidImage.Source = "rapid.png";
            rapidWins.Text = $"Win: {statResult.chess_rapid.Record.win}";
            rapidLoss.Text = $"Loss: {statResult.chess_rapid.Record.loss}";
            rapidDraw.Text = $"Draw: {statResult.chess_rapid.Record.draw}";
            int rapidGamesPlayed = statResult.chess_rapid.Record.win + statResult.chess_rapid.Record.loss;
            double rapidWinrate = (double)statResult.chess_rapid.Record.win / rapidGamesPlayed * 100;
            rapidWinrateLabel.Text = $"W/L: {(int)Math.Round(rapidWinrate)}%";
            if(rapidWinrate == 50)
            {
                rapidWinrateLabel.TextColor = Color.White;
            }
            else if (rapidWinrate > 50)
            {
                rapidWinrateLabel.TextColor = Color.Green;
            }
            else if (rapidWinrate < 49.5)
            {
                rapidWinrateLabel.TextColor = Color.Red;
            }

            //blitz games info
            blitzRating.Text = $"Blitz: {statResult.chess_blitz.Last.rating}";
            blitzImage.Source = "blitz.png";
            blitzWins.Text = $"Win: {statResult.chess_blitz.Record.win}";
            blitzLoss.Text = $"Loss: {statResult.chess_blitz.Record.loss}";
            blitzDraw.Text = $"Draw: {statResult.chess_blitz.Record.draw}";
            int blitzGamesPlayed = statResult.chess_blitz.Record.win + statResult.chess_blitz.Record.loss;
            double blitzWinrate = (double)statResult.chess_blitz.Record.win / blitzGamesPlayed * 100;
            blitzWinrateLabel.Text = $"W/L: {(int)Math.Round(blitzWinrate)}%";
            if (blitzWinrate == 50)
            {
                blitzWinrateLabel.TextColor = Color.White;
            }
            else if (blitzWinrate > 50)
            {
                blitzWinrateLabel.TextColor = Color.Green;
            }
            else if (blitzWinrate < 49.5)
            {
                blitzWinrateLabel.TextColor = Color.Red;
            }

            //bullet games info
            bulletRating.Text = $"Bullet: {statResult.chess_bullet.Last.rating}";
            bulletImage.Source = "bullet.png";
            bulletWins.Text = $"Win: {statResult.chess_bullet.Record.win}";
            bulletLoss.Text = $"Loss: {statResult.chess_bullet.Record.loss}";
            bulletDraw.Text = $"Draw: {statResult.chess_bullet.Record.draw}";
            int bulletGamesPlayed = statResult.chess_bullet.Record.win + statResult.chess_bullet.Record.loss;
            double bulletWinrate = (double)statResult.chess_bullet.Record.win / bulletGamesPlayed * 100;
            bulletWinrateLabel.Text = $"W/L: {(int)Math.Round(bulletWinrate)}%";
            if (bulletWinrate == 50)
            {
                bulletWinrateLabel.TextColor = Color.White;
            }
            else if (bulletWinrate > 50)
            {
                bulletWinrateLabel.TextColor = Color.Green;
            }
            else if (bulletWinrate < 49.5)
            {
                bulletWinrateLabel.TextColor = Color.Red;
            }

            puzzleRating.Text = $"Highest Rating: {statResult.tactics.Highest.rating}";
            puzzleImage.Source = "puzzle.png";

            activityIndicator.IsRunning = false;
            activityIndicator.IsVisible= false;
        }
    }
}