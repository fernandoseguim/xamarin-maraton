using Android.App;
using Android.Widget;
using Android.OS;

namespace ListViewDemo
{
    [Activity(Label = "ListViewDemo", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            var employees = EmployeeList.GetEmployees(20);

            ListView listEmployees = FindViewById<ListView>(Resource.Id.listView1);
            //ArrayAdapter<Employee> adapter = new ArrayAdapter<Employee>(
            //        this,
            //        Android.Resource.Layout.SimpleListItem1, 
            //        employees
            //    );
            EmployeeAdapter adapter = new EmployeeAdapter(employees);
            listEmployees.Adapter = adapter;

            

        }
    }
}

