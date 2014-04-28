using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Media;

namespace Sansula_Kalimba
{
	[Activity (Label = "PlayPage")]			
	public class PlayPage : Activity
	{
		MediaPlayer _player;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Play);

			_player = MediaPlayer.Create(this, Resource.Raw.sound1);

			var sound1 = FindViewById<Button> (Resource.Id.sound1);

			sound1.Click += delegate {
				sound1.Text = string.Format ("asdasd");
				_player.Start();
			};
			//	_player = MediaPlayer.Create(this, Resource.Raw.sound1);

		



		}
	}
}

