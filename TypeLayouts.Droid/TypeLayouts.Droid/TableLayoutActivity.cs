using Android.App;
using Android.OS;

namespace TypeLayouts.Droid
{
    [Activity(Label = "TableLayoutActivity")]
    public class TableLayoutActivity : Activity
    {

        protected override void OnCreate(Bundle savedInstanceState) {

            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.TableLayout);

        }

    }
}