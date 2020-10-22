using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Collections.Generic;
using System;
using Android.Content;
using DSED_03_Hangman.BusinessFolder;

namespace DSED_03_Hangman
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        //User myUser = new User();
        Button btnPlay2;
        TextView txtEnterName;
        ImageView imgFruitMenu;
       

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Menu);
            //create application here
            imgFruitMenu = FindViewById<ImageView>(Resource.Id.imgFruitMenu);
            txtEnterName = FindViewById<TextView>(Resource.Id.TVEnterName);
            btnPlay2 = FindViewById<Button>(Resource.Id.btnPlay2);
            btnPlay2.Click += btnPlay2_Click;
            imgFruitMenu.SetImageResource(Resource.Drawable.fruitbasket);

           
        }
            

        private void btnPlay2_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(txtEnterName.Text == string.Empty)) // true 
            {
                Toast.MakeText(this, "You Forgot Your Name", ToastLength.Long).Show();
                return; // dont write any else

            }

            var gameActivity = new Intent(this, typeof(GameActivity));
            gameActivity.PutExtra("Name", txtEnterName.Text);
            StartActivity(gameActivity);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}