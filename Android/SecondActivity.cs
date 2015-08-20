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

namespace Android
{
    [Activity(Label = "SecondActivity")]
    public class SecondActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here

            // SetContentView : 追加した画面
            SetContentView(Resource.Layout.Second);

            Button button = FindViewById<Button>(Resource.Id.button1);                        

            //button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); }; 
            
            // +=の後にTabキーを押下すると自動でイベントハンドラが生成される
            button.Click += button_Click;
            //button.Click += delegate { text.Text = wordPressResponse(); }; 

        }
       
        void button_Click(object sender, EventArgs e)
        {            
            TextView text = FindViewById<TextView>(Resource.Id.textView1);
            text.Text = "test";
        }              
    }
}