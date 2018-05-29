using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.SimpleAudioPlayer;
using Xamarin.Forms;

namespace Soundenizer
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

	    private void BtnSound_OnClicked(object sender, EventArgs e)
	    {
	        Button b = (Button) sender;

	        ISimpleAudioPlayer player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
	        player.Load("sound" + b.Text + ".mp3");
	        player.Play();
	    }
	}
}
