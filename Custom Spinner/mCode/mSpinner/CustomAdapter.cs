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
using Custom_Spinner.mCode.mData;
using Object = Java.Lang.Object;

namespace Custom_Spinner.mCode.mSpinner
{
    class CustomAdapter : BaseAdapter
    {
        private Context c;
        private JavaList<Fruit> fruits;
        private LayoutInflater inflater;

        public CustomAdapter(Context c, JavaList<Fruit> fruits)
        {
            this.c = c;
            this.fruits = fruits;
        }

        public override Object GetItem(int position)
        {
            return fruits.Get(position);
        }

        public override long GetItemId(int position)
        {
           return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            if (inflater == null)
            {
                inflater = (LayoutInflater) c.GetSystemService(Context.LayoutInflaterService);
            }

            if (convertView == null)
            {
                convertView = inflater.Inflate(Resource.Layout.Model, parent, false);
            }

            TextView nameTxt = convertView.FindViewById<TextView>(Resource.Id.nameTxt);
            ImageView img = convertView.FindViewById<ImageView>(Resource.Id.fruitImg);

            //BIND
            nameTxt.Text = fruits[position].Name;
            img.SetImageResource(fruits[position].Image);


            return convertView;
        }

        public override int Count
        {
            get { return fruits.Size(); }
        }
    }
}