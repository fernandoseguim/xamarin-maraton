
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

namespace RelativeAppAndroid
{
	[Activity(Label = "CapitalActivity")]
	public class CapitalActivity : Activity
	{
		
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.Capitals);

			EditText edtImmBrazil = FindViewById<EditText>(Resource.Id.edt_immigration_brazil);
			EditText edtEmiBrazil = FindViewById<EditText>(Resource.Id.edt_emigration_brazil);
			EditText edtImmEua = FindViewById<EditText>(Resource.Id.edt_immigration_eua);
			EditText edtEmiEua = FindViewById<EditText>(Resource.Id.edt_emigration_eua);

			Button btnCompute = FindViewById<Button>(Resource.Id.btn_compute); 
			Button btnReturn = FindViewById<Button>(Resource.Id.btn_return);


			btnCompute.Click += delegate {

				try
				{
					int popBrazil = int.Parse(edtImmBrazil.Text) - int.Parse(edtEmiBrazil.Text);
					int popEua = int.Parse(edtImmEua.Text) - int.Parse(edtEmiEua.Text);
					Compute(popBrazil, popEua);
				}
				catch (System.Exception ex)
				{
					Toast.MakeText(this, ex.Message, ToastLength.Short).Show();
				}

			};

			btnReturn.Click += delegate {
				this.Finish();
			};

		}

		public void Compute(int brazil, int eua)
		{
			Intent intentPopulation = new Intent(this, typeof(PopulationActivity));
			intentPopulation.PutExtra("pop-brazil", brazil);
			intentPopulation.PutExtra("pop-eua", eua);
			StartActivity(intentPopulation);
		}
	}
}
