using System;

using Xamarin.Forms;

namespace HelloXamarinFormsSAP
{
	public class App : Application
	{
		public App()
		{
			// The root page of your application
			var content = new ContentPage
			{
				Title = "HelloXamarinFormsSAP",
				Content = new StackLayout
				{
					VerticalOptions = LayoutOptions.Center,
					Children = {
						new Label {
							HorizontalTextAlignment = TextAlignment.Center,

							#if __IOS__
							Text = "Welcome to iOS Xamarin Forms!"
							#elif __ANDROID__
							Text = "Welcome to Android Xamarin Forms!"
							#endif
						}
					}
				}
			};

			MainPage = new NavigationPage(content);
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
