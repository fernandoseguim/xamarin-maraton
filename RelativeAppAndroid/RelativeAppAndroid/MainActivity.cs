using Android.App;
using Android.Widget;
using Android.OS;

namespace RelativeAppAndroid
{
	[Activity(Label = "RelativeAppAndroid", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.Main);

			Button btnConvert = FindViewById<Button>(Resource.Id.btn_convert);
			EditText edtDollar = FindViewById<EditText>(Resource.Id.edt_dollar);
			EditText edtReal = FindViewById<EditText>(Resource.Id.edt_real);

			double reals, dollars;

			btnConvert.Click += delegate {

				try
				{
					dollars = double.Parse(edtDollar.Text);
					reals = dollars * 3.5;
					edtReal.Text = reals.ToString();

				}
				catch (System.Exception e)
				{
					Toast.MakeText(this, e.Message, ToastLength.Short).Show();				
				}
			
			};
		}
	}
}

