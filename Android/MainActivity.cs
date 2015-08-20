using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Android
{
    [Activity(Label = "MainActivity", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);            

            button.Click += button_Click;

            //button.Click += delegate 
            //{
            //    var intent = new Intent(this, typeof(SecondActivity));
            //    StartActivity(intent);
            //};

            //button.Click += (_, __) =>
            //{
            //    var intent = new Intent(this, typeof(SecondActivity));
            //    StartActivity(intent);
            //};
        }

        void button_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(SecondActivity));
            StartActivity(intent);
        }

    }
}

