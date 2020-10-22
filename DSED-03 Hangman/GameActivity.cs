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
using Java.Lang;

namespace DSED_03_Hangman
{
    [Activity(Label = "GameActivity", MainLauncher = false)]
    public class GameActivity : Activity
    {
        //User myUser = new User(); // -- putting the user class as a static class until i figure out how to use the adapter for the leaderboards
        Button btnA;
        Button btnB;
        Button btnC;
        Button btnD;
        Button btnE;
        Button btnF;
        Button btnG;
        Button btnH;
        Button btnI;
        Button btnJ;
        Button btnK;
        Button btnL;
        Button btnM;
        Button btnN;
        Button btnO;
        Button btnP;
        Button btnQ;
        Button btnR;
        Button btnS;
        Button btnT;
        Button btnU;
        Button btnV;
        Button btnW;
        Button btnX;
        Button btnY;
        Button btnZ;
        TextView tvWord;
        Button btnPlay;
        ImageView HangFruit;
        TextView txtScore;
        TextView txtCurrentUser;

        char[] ChosenWordArray;
        char[] ChosenWordUnderScoreArray;
        string ChosenWord;
        string Name;
        int wrongLetter;
        //int FruitScore;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Game);
            // Create your application here
            HangFruit = FindViewById<ImageView>(Resource.Id.imgHangFruit);
            HangFruit.SetImageResource(Resource.Drawable.fruitbasket);
            txtScore = FindViewById<TextView>(Resource.Id.tvScore);
            txtCurrentUser = FindViewById<TextView>(Resource.Id.tvCurrentUser);
            AlphabetButtons();
            DisableButtons();
            Name = Intent.GetStringExtra("Name");
            txtCurrentUser.Text = "User: " + Name;
            User.Score = 0;
        }

        private void AlphabetButtons()
        {
            btnPlay = FindViewById<Button>(Resource.Id.btnPlay);
            btnPlay.Click += btnPlay_Click;

            tvWord = FindViewById<TextView>(Resource.Id.tvWord);

            
            btnA = FindViewById<Button>(Resource.Id.btnA);
            btnB = FindViewById<Button>(Resource.Id.btnB);
            btnC = FindViewById<Button>(Resource.Id.btnC);
            btnD = FindViewById<Button>(Resource.Id.btnD);
            btnE = FindViewById<Button>(Resource.Id.btnE);
            btnF = FindViewById<Button>(Resource.Id.btnF);
            btnG = FindViewById<Button>(Resource.Id.btnG);
            btnH = FindViewById<Button>(Resource.Id.btnH);
            btnI = FindViewById<Button>(Resource.Id.btnI);
            btnJ = FindViewById<Button>(Resource.Id.btnJ);
            btnK = FindViewById<Button>(Resource.Id.btnK);
            btnL = FindViewById<Button>(Resource.Id.btnL);
            btnM = FindViewById<Button>(Resource.Id.btnM);
            btnN = FindViewById<Button>(Resource.Id.btnN);
            btnO = FindViewById<Button>(Resource.Id.btnO);
            btnP = FindViewById<Button>(Resource.Id.btnP);
            btnQ = FindViewById<Button>(Resource.Id.btnQ);
            btnR = FindViewById<Button>(Resource.Id.btnR);
            btnS = FindViewById<Button>(Resource.Id.btnS);
            btnT = FindViewById<Button>(Resource.Id.btnT);
            btnU = FindViewById<Button>(Resource.Id.btnU);
            btnV = FindViewById<Button>(Resource.Id.btnV);
            btnW = FindViewById<Button>(Resource.Id.btnW);
            btnX = FindViewById<Button>(Resource.Id.btnX);
            btnY = FindViewById<Button>(Resource.Id.btnY);
            btnZ = FindViewById<Button>(Resource.Id.btnZ);

            btnA.Click += AllButton_Click;
            btnB.Click += AllButton_Click;
            btnC.Click += AllButton_Click;
            btnD.Click += AllButton_Click;
            btnE.Click += AllButton_Click;
            btnF.Click += AllButton_Click;
            btnG.Click += AllButton_Click;
            btnH.Click += AllButton_Click;
            btnI.Click += AllButton_Click;
            btnJ.Click += AllButton_Click;
            btnK.Click += AllButton_Click;
            btnL.Click += AllButton_Click;
            btnM.Click += AllButton_Click;
            btnN.Click += AllButton_Click;
            btnO.Click += AllButton_Click;
            btnP.Click += AllButton_Click;
            btnQ.Click += AllButton_Click;
            btnR.Click += AllButton_Click;
            btnS.Click += AllButton_Click;
            btnT.Click += AllButton_Click;
            btnU.Click += AllButton_Click;
            btnV.Click += AllButton_Click;
            btnW.Click += AllButton_Click;
            btnX.Click += AllButton_Click;
            btnY.Click += AllButton_Click;
            btnZ.Click += AllButton_Click;

        } //ALPHATBET BUTTON BINDINGS

        private void btnPlay_Click(object sender, EventArgs e)
        {
            LoadWord();
            EnableButtons();
            btnPlay.Enabled = false;
            
        }

        private void AllButton_Click(object sender, EventArgs e)
        {
            Button fakeBtn = (Button)sender;

            fakeBtn.Enabled = false;

            GamePlay(fakeBtn.Text.ToLower());
        }




        private void LoadWord()
        {
            tvWord.Text = string.Empty; // empty the text box
            ChosenWord = Gameplay.GetRandomWord();//get the random word from the class


            //break the word into letters and stick it in the array 
            ChosenWordArray = ChosenWord.ToCharArray(); // breaks the word into letters eg. ("A", "P", "P", "L", "E")
            ChosenWordUnderScoreArray = new char[ChosenWordArray.Length]; // makes _ _ _ _

            for (int i = 0; i < ChosenWord.Length; i++)
            {
                tvWord.Text += "_ ";
                ChosenWordUnderScoreArray[i] = '_';
            }

        }

        private void GamePlay(string Letter)
        {
            if (ChosenWord.Contains(Letter))
            {
                for (int i = 0; i < ChosenWordArray.Length; i++)
                {
                    if (Letter == ChosenWordArray[i].ToString())
                    {
                        ChosenWordUnderScoreArray[i] = Convert.ToChar(Letter);
                        CompleteWord();
                    }
                }
            }

            else // if no letter in the word then move on to next
                {
    
                wrongLetter++;
                switch (wrongLetter)
                {
                    case 1:
                        HangFruit.SetImageResource(Resource.Drawable.fruit1);
                        break;
                    case 2:
                        HangFruit.SetImageResource(Resource.Drawable.fruit2);
                        break;
                    case 3:
                        HangFruit.SetImageResource(Resource.Drawable.fruit3);
                        break;
                    case 4:
                        HangFruit.SetImageResource(Resource.Drawable.fruit4);
                        break;
                    case 5:
                        HangFruit.SetImageResource(Resource.Drawable.fruit5);
                        break;
                    case 6:
                        HangFruit.SetImageResource(Resource.Drawable.fruit6);
                        break;
                    case 7:
                        var gameoverActivity = new Intent(this, typeof(GameOverActivity));
                        StartActivity(gameoverActivity);
                        break;
                }
                return;

            }

            tvWord.Text = string.Empty;

            foreach (var letter in ChosenWordUnderScoreArray)
            {
                tvWord.Text += letter + " "; // make it look like _ _ _ instead of ___
            }

        }

        private void CompleteWord()
        {
            if (ChosenWordArray.SequenceEqual(ChosenWordUnderScoreArray))
            {
                User.Score ++;
                txtScore.Text = "Score: " + User.Score;
                btnPlay.Enabled = true;
                btnPlay.Text = "Next Fruit";

                Toast.MakeText(this, "You Have Eaten the Fruit and gained a Score Guess the next fruit to eat some more!", ToastLength.Long).Show();

            }


        }

        private void DisableButtons()
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnE.Enabled = false;
            btnF.Enabled = false;
            btnG.Enabled = false;
            btnH.Enabled = false;
            btnI.Enabled = false;
            btnJ.Enabled = false;
            btnK.Enabled = false;
            btnL.Enabled = false;
            btnM.Enabled = false;
            btnN.Enabled = false;
            btnO.Enabled = false;
            btnP.Enabled = false;
            btnQ.Enabled = false;
            btnR.Enabled = false;
            btnS.Enabled = false;
            btnT.Enabled = false;
            btnU.Enabled = false;
            btnV.Enabled = false;
            btnW.Enabled = false;
            btnX.Enabled = false;
            btnY.Enabled = false;
            btnZ.Enabled = false;
        }

        private void EnableButtons()
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnE.Enabled = true;
            btnF.Enabled = true;
            btnG.Enabled = true;
            btnH.Enabled = true;
            btnI.Enabled = true;
            btnJ.Enabled = true;
            btnK.Enabled = true;
            btnL.Enabled = true;
            btnM.Enabled = true;
            btnN.Enabled = true;
            btnO.Enabled = true;
            btnP.Enabled = true;
            btnQ.Enabled = true;
            btnR.Enabled = true;
            btnS.Enabled = true;
            btnT.Enabled = true;
            btnU.Enabled = true;
            btnV.Enabled = true;
            btnW.Enabled = true;
            btnX.Enabled = true;
            btnY.Enabled = true;
            btnZ.Enabled = true;


        }



    }
}