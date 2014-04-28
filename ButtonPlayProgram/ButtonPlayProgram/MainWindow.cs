using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void Sound1Clicked (object sender, EventArgs e)
	{
		Console.WriteLine ("Button clicked");
		System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"/Users/MikkelMikkelsen/Documents/Skole/MED4/Object oriented software engeneering/OOSE-Project-JUS-PAU-MIK/Sounds/6992__kostasvomvolos__klmb-b4.wav");
		player.Play();

		//throw new NotImplementedException ();
	}

	protected void Sound2Clicked (object sender, EventArgs e)
	{
		throw new NotImplementedException ();
	}

	protected void Sound3Clicked (object sender, EventArgs e)
	{
		throw new NotImplementedException ();
	}
}
