using Android.Runtime;
using Android.OS;
using Android.Views;
using MvvmCross.Droid.Shared.Attributes;
using Core.ViewModels;
using Core.ViewModels.Home;

namespace Droid.Fragments
{
	[MvxFragment(typeof(MainViewModel), Resource.Id.content_frame)]
	[Register("droid.fragments.HomeFragment")]
	public class HomeFragment : BaseFragment<HomeViewModel>
	{
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			ShowHamburgerMenu = true;
			return base.OnCreateView(inflater, container, savedInstanceState);
		}

		protected override int FragmentId => Resource.Layout.fragment_home;
	}
}