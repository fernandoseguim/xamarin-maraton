using Android.App;
using Android.Content;
using Android.OS;
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
                    int immBrazil = int.Parse(edtImmBrazil.Text);
                    int emiBrazil = int.Parse(edtImmBrazil.Text);
                    int immEua = int.Parse(edtImmBrazil.Text);
                    int emiEua = int.Parse(edtImmBrazil.Text);

                    int popBrazil = immBrazil - emiBrazil;
                    int popEua = immEua - emiEua;

                    var information = new Information();
                    information.ImmBrazil = immBrazil;
                    information.EmiBrazil = emiBrazil;
                    information.ImmEua = immEua;
                    information.EmiEua = emiEua;

                    InformationDAO informationDAO = new InformationDAO(this);
                    informationDAO.Insert(information);
                    Toast.MakeText(this, "Salvando informações...", ToastLength.Short).Show();

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
