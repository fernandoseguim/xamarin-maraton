using System;
using DemoPortableLibrary.PCL;

namespace DemoPortableLibrary.iOS
{
	public class Printer : IPrinter
	{
		public Printer()
		{
		}


		public void ShowMessage()
		{
			Console.WriteLine("Hello Xamarin, this is a sample of shared project");
			Console.WriteLine("This app is running with iOS SDK version: " + UIKit.UIDevice.CurrentDevice.SystemVersion);
		}
	}
}
