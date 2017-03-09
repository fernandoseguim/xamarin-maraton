using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace RelativeAppAndroid
{
	[Activity(Label = "RelativeAppAndroid", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.Main);

			Button btnConvert = FindViewById<Button>(Resource.Id.btn_convert);
			Button btnCapitals = FindViewById<Button>(Resource.Id.btn_calc_capitals);

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
				catch (System.Exception ex)
				{
					Toast.MakeText(this, ex.Message, ToastLength.Short).Show();				
				}
			
			};

			btnCapitals.Click += delegate {

				Intent intentCapitals = new Intent(this, typeof(CapitalActivity));
				StartActivity(intentCapitals);
			};


		}
	}
}

