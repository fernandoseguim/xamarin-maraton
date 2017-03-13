
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
	[Activity(Label = "PopulationActivity")]
	public class PopulationActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.Population);

			EditText edtPopBrazil = FindViewById<EditText>(Resource.Id.edt_pop_brazil);
			EditText edtPopEua = FindViewById<EditText>(Resource.Id.edt_pop_eua);
			ImageView imgFlaBrazil = FindViewById<ImageView>(Resource.Id.img_flag_brazil);
			ImageView imgFlaEua = FindViewById<ImageView>(Resource.Id.img_flag_eua);

			Button btnGoToMain = FindViewById<Button>(Resource.Id.btn_go_to_main_screen);
			Button btnReturn = FindViewById<Button>(Resource.Id.btn_return);
			Button btnExit = FindViewById<Button>(Resource.Id.btn_exit);

			try
			{
				edtPopBrazil.Text = Intent.GetIntExtra("pop-brazil", defaultValue:0).ToString();
				edtPopEua.Text = Intent.GetIntExtra("pop-eua", defaultValue:0).ToString();
				imgFlaBrazil.SetImageResource(Resource.Drawable.brasil_flag);
				imgFlaEua.SetImageResource(Resource.Drawable.eua_flag);

                InformationDAO informationDAO = new InformationDAO(this);
                var informations = informationDAO.GetAll();

                foreach (var info in informations)
                {

                    Toast.MakeText(this, info.ImmBrazil.ToString(), ToastLength.Short).Show();
                    Toast.MakeText(this, info.EmiBrazil.ToString(), ToastLength.Short).Show();
                    Toast.MakeText(this, info.ImmEua.ToString(), ToastLength.Short).Show();
                    Toast.MakeText(this, info.EmiEua.ToString(), ToastLength.Short).Show();

                }

            }
			catch (System.Exception ex)
			{
				Toast.MakeText(this, ex.Message, ToastLength.Short).Show();
			}

			btnGoToMain.Click += delegate 
			{
				Intent intentMain = new Intent(this, typeof(MainActivity));
				intentMain.AddFlags(ActivityFlags.ClearTop);
				StartActivity(intentMain);
			};

			btnReturn.Click += delegate
			{
				this.Finish();
			};

			btnExit.Click += delegate
			{
				Process.KillProcess(Process.MyPid());
			};

		}
	}
}
