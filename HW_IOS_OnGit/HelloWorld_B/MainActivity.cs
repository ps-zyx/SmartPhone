using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Webkit;

namespace HelloWorld_B
{
	[Activity (Label = "HelloWorld_B", MainLauncher = true)]
	public class MainActivity : Activity
	{
		int count = 1;

		WebView myView;
		Button button;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			button = FindViewById<Button> (Resource.Id.myButton);
			myView = FindViewById<WebView> (Resource.Id.WView);
			//myView.Settings.LoadWithOverviewMode = true;
			//myView.Settings.UseWideViewPort = true;
			//myView.LoadUrl("http://cdn.sencha.com/touch/sencha-touch-2.3.1a/built-examples/geocongress/index.html");
			button.Click += When_Click;
		}

		private void When_Click(object sender,EventArgs e)
		{
			button.Text="Loading...";
			myView.Settings.AllowFileAccess = true;
			myView.Settings.JavaScriptEnabled = true;
			myView.Settings.BuiltInZoomControls = true;
			myView.LoadUrl("http://cdn.sencha.com/touch/sencha-touch-2.3.1a/built-examples/touchtomatoes/index.html");
		
		}
	}
}


