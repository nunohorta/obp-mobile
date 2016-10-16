using System;
using System.Linq;
using Xamarin.Forms;

namespace GBank
{
	public partial class App : Application
	{
		public static string AppName { get { return "GBank"; } }

		//public static TodoItemManager TodoManager { get; private set; }

		public static User User { get; set; }

		//public static ITextToSpeech Speech { get; set; }

		static NavigationPage NavPage;

		public static bool IsLoggedIn
		{
			get
			{
				if (User != null)
					return !string.IsNullOrWhiteSpace(User.Email);
				else
					return false;
			}
		}

		public static Action SuccessfulLoginAction
		{
			get
			{
				return new Action(() =>
				{
					NavPage.Navigation.PopModalAsync();

					if (IsLoggedIn)
					{
						NavPage.Navigation.InsertPageBefore(new MainPage(), NavPage.Navigation.NavigationStack.First());
						NavPage.Navigation.PopToRootAsync();
					}
				});
			}
		}


		public App()
		{
			InitializeComponent();

			MainPage = new LoginPage();
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
