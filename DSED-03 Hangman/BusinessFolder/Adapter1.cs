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

namespace DSED_03_Hangman.BusinessFolder
{
    //Because BaseAdapter is an ABSTRACT class we have to have every Method in the class, even if we don't use them. 

    class DataAdapter : BaseAdapter<User>
    {
        private readonly Activity context;
        private readonly List<User> items;

        public DataAdapter(Activity context, List<User> items)
        {
            this.context = context;
            this.items = items;
        }

        public override User this[int position]
        {
            get { return items[position]; }
        }

        public override int Count
        {
            get { return items.Count; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }
        //this is the section that changes 
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = items[position];
            var view = convertView;
            if (view == null) // no view to re-use, create new
                view = context.LayoutInflater.Inflate(Resource.Layout.Highscores, null);
            view.FindViewById<TextView>(Resource.Id.TVEnterName).Text = item.Title;
            view.FindViewById<TextView>(Resource.Id.tvScore).Text = item.Score.ToString();
            return view;
        }

    }
}
