using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace DSED_03_Hangman
{
    static class Gameplay
    {
        //Fruits Array for Guess the Fruit
        public static string[] FruitData()
        {

            string[] FruitGuess = new string[] { "Apple", "Orange", "Grapes", "Mango", "Mandarin", "Banana" };
            return FruitGuess; 
        }

        public static IEnumerable<string> GetFruits(string[] FruitData)
        {
            List<string> ListNames = new List<string>();
            foreach (var fruit in FruitData)
            {
                ListNames.Add(fruit.ToLower());
            }
            return ListNames;
        }

        public static int RndNum(int UpperLength)
        {
            Random rnd = new Random();
            int rndNum = rnd.Next(1, UpperLength);
            return rndNum;

        }

        public static string GetRandomWord()
        {
            List<string> Words = new List<string>();
            Words.AddRange(GetFruits(FruitData()));
            int rnd = RndNum(Words.Count);

            return Words[rnd];
        }










    }
}