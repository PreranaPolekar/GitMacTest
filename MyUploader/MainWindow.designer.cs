// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoMac.Foundation;
using System.CodeDom.Compiler;

namespace MyUploader
{
	[Register ("MainWindowController")]
	partial class MainWindowController
	{
		[Outlet]
		MonoMac.AppKit.NSTextField filetoupload { get; set; }

		[Outlet]
		MonoMac.AppKit.NSLevelIndicator progressbar { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField queuecnt { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField uploadpercent { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField uploadstatus { get; set; }

		[Action ("ShowLogs:")]
		partial void ShowLogs (MonoMac.Foundation.NSObject sender);

		[Action ("Upload:")]
		partial void Upload (MonoMac.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (filetoupload != null) {
				filetoupload.Dispose ();
				filetoupload = null;
			}

			if (progressbar != null) {
				progressbar.Dispose ();
				progressbar = null;
			}

			if (queuecnt != null) {
				queuecnt.Dispose ();
				queuecnt = null;
			}

			if (uploadpercent != null) {
				uploadpercent.Dispose ();
				uploadpercent = null;
			}

			if (uploadstatus != null) {
				uploadstatus.Dispose ();
				uploadstatus = null;
			}
		}
	}

	[Register ("MainWindow")]
	partial class MainWindow
	{
		
		void ReleaseDesignerOutlets ()
		{
		}
	}
}
