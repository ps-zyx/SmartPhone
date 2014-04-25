// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace HelloWorld
{
	[Register ("HelloWorldViewController")]
	partial class HelloWorldViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton Mybutton { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIWebView Wview { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (Mybutton != null) {
				Mybutton.Dispose ();
				Mybutton = null;
			}

			if (Wview != null) {
				Wview.Dispose ();
				Wview = null;
			}
		}
	}
}
