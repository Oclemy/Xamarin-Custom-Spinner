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

namespace Custom_Spinner.mCode.mData
{
    class FruitsCollection
    {
        public static JavaList<Fruit> GetFruits()
        {
            JavaList<Fruit> fruits=new JavaList<Fruit>();
            Fruit fruit = null;


            //ADD FRUITS
            fruit=new Fruit();
            fruit.Name = "Mango";
            fruit.Image = Resource.Drawable.mango;
            fruits.Add(fruit);

            fruit = new Fruit();
            fruit.Name = "Oranges";
            fruit.Image = Resource.Drawable.oranges;
            fruits.Add(fruit);

            fruit = new Fruit();
            fruit.Name = "Coconut";
            fruit.Image = Resource.Drawable.coconut;
            fruits.Add(fruit);

            fruit = new Fruit();
            fruit.Name = "Grapes";
            fruit.Image = Resource.Drawable.grapes;
            fruits.Add(fruit);

            fruit = new Fruit();
            fruit.Name = "Apples";
            fruit.Image = Resource.Drawable.apples;
            fruits.Add(fruit);


            return fruits;
        }
    }
}