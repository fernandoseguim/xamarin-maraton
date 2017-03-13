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

namespace ListViewDemo
{
    public class EmployeeAdapter : BaseAdapter<Employee>
    {

        Employee[] employees;

        public EmployeeAdapter(Employee[] employees)
        {
            this.employees = employees;
        }
        
        public override Employee this[int position]
        {
            get
            {
                return employees[position];
            }
        }
        

        public override int Count
        {
            get
            {
                return employees.Count();
            }

        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var inflater = LayoutInflater.From(parent.Context);
            var view = inflater.Inflate(Resource.Layout.EmployeeItemLayout, parent, false);

            var txtName = view.FindViewById<TextView>(Resource.Id.textName);
            var txtJob = view.FindViewById<TextView>(Resource.Id.textJob);
            var txtEmail = view.FindViewById<TextView>(Resource.Id.textEmail);

            txtName.Text = employees[position].Name;
            txtJob.Text = employees[position].Job;
            txtEmail.Text = employees[position].Email;

            return view;
        }
    }
}