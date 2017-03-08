using System;

using Xamarin.Forms;

namespace GreetingsSAP
{
	public class GreetingsSAPPage : ContentPage
	{
		public GreetingsSAPPage()
		{
			var MyLabel = new Label();
			MyLabel.Text = "Greetings, Xamarin.Forms!";
			this.Content = MyLabel;

			//#if __IOS__
			//			Padding = new Thickness(0, 20, 0, 0);
			//#endif

			//		Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);


			//Device.OnPlatform(iOS: () =>
			//{

			//	Padding = new Thickness(0, 20, 0, 0);

			//});

			//MyLabel.HorizontalOptions = LayoutOptions.Center;
			//MyLabel.VerticalOptions = LayoutOptions.Center;

			MyLabel.HorizontalTextAlignment = TextAlignment.Center;
			MyLabel.VerticalTextAlignment = TextAlignment.Center;

		}
	}
}

