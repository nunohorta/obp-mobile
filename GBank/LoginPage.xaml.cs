using System;
using Xamarin.Forms;

namespace GBank
{
	public partial class LoginPage : ContentPage
	{
		public LoginPage()
		{
			InitializeComponent();
		}

		void OnLoginButtonClicked(object sender, EventArgs e)
		{
			var user = new User
			{
				Username = usernameEntry.Text,
				Password = passwordEntry.Text
			};

			var isValid = AreCredentialsCorrect(user);
			if (isValid)
			{
				Device.BeginInvokeOnMainThread(() => Application.Current.MainPage = new NavigationPage(new MainPage()));
			}
			else {
				messageLabel.Text = "Login failed";
				passwordEntry.Text = string.Empty;
			}
		}

		bool AreCredentialsCorrect(User user)
		{
			return true;
		}
	}
}
