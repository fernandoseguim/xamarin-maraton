using System;
namespace DemoFileLinked.Core
{
	public class Printer
	{
		public void ShowMessage()
		{
			Console.WriteLine("Hello Xamarin, this is a sample of file linked");
#if __ANDROID__
			Console.WriteLine("This app is running with Android SDK version: " + Android.OS.Build.VERSION.Sdk);
#elif __IOS__
			Console.WriteLine("This app is running with iOS SDK version: " + UIKit.UIDevice.CurrentDevice.SystemVersion);
#endif

		}
	}
}
