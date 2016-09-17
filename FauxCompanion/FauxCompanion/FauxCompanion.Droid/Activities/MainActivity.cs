using Android.App;
using Android.OS;

namespace EnergonSoftware.FauxCompanion.Droid.Activities
{
	[Activity (Label = "@string/app_name", MainLauncher = true, Icon = "@drawable/icon")]
	public sealed class MainActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.activity_main);
		}
	}
}


