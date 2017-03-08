using System;
using DemoPortableLibrary.PCL;

namespace DemoPortableLibrary.Droid
{
	public class Printer : IPrinter
	{
		public Printer()
		{
		}

		public void ShowMessage()
		{
			Console.WriteLine("Hello Xamarin, this is a sample of shared project");
			Console.WriteLine("This app is running with Android SDK version: " + Android.OS.Build.VERSION.Sdk);

		}
	}
}
