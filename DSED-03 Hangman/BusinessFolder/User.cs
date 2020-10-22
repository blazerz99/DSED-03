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
using SQLite;

namespace DSED_03_Hangman.BusinessFolder
{
    public static class User // putting this class as a static class until i figure out how to use the data adapter or find a way to add different users to the leaderboards without using sqlite/database
    {
        [PrimaryKey, AutoIncrement]
        public static int ListID { get; set; }
        public static string Title { get; set; }
        public static int Score { get; set; }

    }
}