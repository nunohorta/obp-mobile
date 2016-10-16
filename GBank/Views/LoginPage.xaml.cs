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
				Navigation.PushModalAsync(new AuthenticationPage());
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
