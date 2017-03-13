using Android.App;
using Android.OS;
using Android.Content;
using Android.Widget;

namespace TypeLayouts.Droid
{
    [Activity(Label = "TypeLayouts.Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.LinearLayout);

            Button button = FindViewById<Button>(Resource.Id.button1);
            button.Click += delegate
            {

                Intent intent = new Intent(this, typeof(RelativeLayoutActivity));
                StartActivity(intent);
            };
            
        }
    }
}

