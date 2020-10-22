using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DSED_03_Hangman.BusinessFolder;

namespace DSED_03_Hangman
{
    [Activity(Label = "GameOverActivity")]
    public class GameOverActivity : Activity
    {
        //User myUser = new User();
        Button btnPlayAgain;
        Button btnMainMenu;
        Button btnLeaderboards;
        ImageView imgGameOverFruit;
        TextView tvScore;
        TextView tvGOCurrentUser;
        string Name;



        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.GameOver);
            btnPlayAgain = FindViewById<Button>(Resource.Id.btnPlyAgain);
            btnMainMenu = FindViewById<Button>(Resource.Id.btnMenu);
            btnLeaderboards = FindViewById<Button>(Resource.Id.btnHighscore);
            imgGameOverFruit = FindViewById<ImageView>(Resource.Id.imgGameOverFruit);
            tvScore = FindViewById<TextView>(Resource.Id.tvGameOverScore);
            tvGOCurrentUser = FindViewById<TextView>(Resource.Id.tvGOCurrentUser);
            tvScore.Text = "Score: " + User.Score;
            imgGameOverFruit.SetImageResource(Resource.Drawable.fruit6);
            btnPlayAgain.Click += btnPlayAgn_Click;
            btnMainMenu.Click += btnMainMenu_Click;
            btnLeaderboards.Click += btnLeaderboard_Click;
        }

        private void btnLeaderboard_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            var mainActivity = new Intent(this, typeof(MainActivity));
            StartActivity(mainActivity);
        }

        private void btnPlayAgn_Click(object sender, EventArgs e)
        {
            var gameActivity = new Intent(this, typeof(GameActivity));
            StartActivity(gameActivity);
        }
    }
}