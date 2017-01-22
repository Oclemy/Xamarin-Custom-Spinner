using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Custom_Spinner.mCode.mData;
using Custom_Spinner.mCode.mSpinner;


namespace Custom_Spinner
{
    [Activity(Label = "Custom_Spinner", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private Spinner sp;
        private CustomAdapter adapter;
        private JavaList<Fruit> fruits; 
 
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            sp = FindViewById<Spinner>(Resource.Id.sp);
            fruits = FruitsCollection.GetFruits();
            adapter=new CustomAdapter(this,fruits);

            sp.Adapter = adapter;
            sp.ItemSelected += sp_ItemSelected;
        }

        void sp_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Toast.MakeText(this,fruits[e.Position].Name,ToastLength.Short).Show();
        }
    }
}

