using System;

using Xamarin.Forms;

namespace Greetings
{
	public class GreetingsPage : ContentPage
	{
		public GreetingsPage()
		{

			var MyLabel = new Label();
			MyLabel.Text = "Greetings, Xamarin.Forms!";
			this.Content = MyLabel;

			Padding = new Thickness(0, 20, 0, 0);

		}
	}
}

