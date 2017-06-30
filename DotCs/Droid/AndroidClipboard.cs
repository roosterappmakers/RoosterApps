using System;
using Android;
using Android.Content;
using Android.App;
using Android.OS;
using DotCs.Droid;
[assembly: Xamarin.Forms.Dependency(typeof(AndroidClipboard))]
namespace DotCs.Droid
{
	public class AndroidClipboard :  IClipboard
	{
		public AndroidClipboard()
		{

		}

		public void SendToClipbord(string thetext)
		{
			ClipboardManager cm = (ClipboardManager)Application.Context.GetSystemService("clipboard");
			ClipData clip = ClipData.NewPlainText("Clip", thetext);
			cm.PrimaryClip = clip;
		}
	}
}
