using System;
using System.Collections.Generic;
using Xamarin.Auth;
using Xamarin.Forms;

namespace GBank
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			var auth = new OAuth2Authenticator(
				Constants.ClientId,
				Constants.Scope,
				new Uri(Constants.AuthorizeUrl),
				new Uri(Constants.RedirectUrl));
		}
	}
}
