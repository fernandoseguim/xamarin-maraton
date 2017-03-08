using Android.App;
using Android.Widget;
using Android.OS;

namespace HelloXamarinAndroid
{
	[Activity(Label = "HelloXamarinAndroid", MainLauncher = true)]
	public class MainActivity : Activity
	{
		Button btnHelloWorld;
		TextView txtHelloWorld;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			btnHelloWorld = FindViewById<Button>(Resource.Id.btn_helloworld);
			txtHelloWorld = FindViewById<TextView>(Resource.Id.txt_helloworld);

			btnHelloWorld.Click += delegate {

				txtHelloWorld.Text = "Welcome to Xamarin World, this is your first Android App build with Xamarin Studio"; 

			};

		}

		 
	}
}

