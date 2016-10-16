using System;
using Xamarin.Auth;

namespace GBank
{
	public class Authenticator
	{
		const string REDIRECT_URL = "";

		public Authenticator()
		{
		}

		void Authenticate() 
		{
			var auth = new OAuth2Authenticator(
				Constants.ClientId,
				Constants.Scope,
				new Uri(Constants.AuthorizeUrl),
				new Uri(Constants.RedirectUrl));
		}
	}
}
