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

namespace TypeLayouts.Droid
{
    [Activity(Label = "RelativeLayoutActivity")]
    public class RelativeLayoutActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.RelativeLayout);
            Button btnVoltar = FindViewById<Button>(Resource.Id.button2);
            Button btnTableLayout = FindViewById<Button>(Resource.Id.button3);

            btnVoltar.Click += delegate
            {
                this.Finish();
            };

            btnTableLayout.Click += delegate
            {

                Intent intent = new Intent(this, typeof(TableLayoutActivity));
                StartActivity(intent);
            };
        }
    }
}