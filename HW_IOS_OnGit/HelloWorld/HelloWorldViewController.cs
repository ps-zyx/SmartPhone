using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace HelloWorld
{
	public partial class HelloWorldViewController : UIViewController
	{
		public HelloWorldViewController () : base ("HelloWorldViewController", null)
		{

		}

		public override void DidReceiveMemoryWarning ()
		{	
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();


			this.Mybutton.TouchUpInside += (sender, e) => {
				Wview.LoadRequest (new NSUrlRequest (new NSUrl ("http://cdn.sencha.com/touch/sencha-touch-2.3.1a/built-examples/geocongress/index.html")));

			};

			// Perform any additional setup after loading the view, typically from a nib.
		}
	}
}

