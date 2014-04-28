using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Sansula_Kalimba
{
	[Activity (Label = "Sansula Kalimba", MainLauncher = true)]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button_play = FindViewById<Button> (Resource.Id.Play);
			
			button_play.Click += delegate {
				button_play.Text = string.Format ("{0} clicks!", count++);
			};

			Button button_how = FindViewById<Button> (Resource.Id.HowToPlay);

			button_how.Click += delegate {
				button_how.Text = string.Format ("{0} clicks!", count++);
			};

		}
	}
}


