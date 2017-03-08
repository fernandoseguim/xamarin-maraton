using System;

using Xamarin.Forms;

namespace HelloXamarinFormsPCL
{
	public class GreetingPage : ContentPage
	{
		public GreetingPage()
		{
			Content = new StackLayout
			{
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}

