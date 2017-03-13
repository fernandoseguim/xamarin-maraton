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

    public class Employee
    {

        public string Name{ get; set; }
        public string Job { get; set; }

        public string Email { get; set; }

        public Employee() { }

        public Employee(string _name, string _job, string _email)
        {
            Name = _name;
            Job = _job;
            Email = _email;
        }

        public override string ToString()
        {
            return Name;
        }

    }

    public class EmployeeList
    {
        public static Employee[] GetEmployees(int number)
        {

            Employee[] employees = new Employee[number];
            String[] jobs = { "Supoervisor", "Operador", "Gerente", "Diretor" };
            Random random = new Random();

            for(int i = 0; i < number; i++)
            {
                var name = Guid.NewGuid().ToString().Substring(0, 20);
                var employee = new Employee(
                    name,
                    jobs[random.Next(0, 3)],
                    name + "@seguim.it"
                    );
                employees[i] = employee;
            }

            return employees;
        }
        
    }

}