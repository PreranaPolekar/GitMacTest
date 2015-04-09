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
	[Register ("FailedUploadsLogsController")]
	partial class FailedUploadsLogsController
	{
		[Outlet]
		MonoMac.AppKit.NSTableView tableview { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (tableview != null) {
				tableview.Dispose ();
				tableview = null;
			}
		}
	}

	[Register ("FailedUploadsLogs")]
	partial class FailedUploadsLogs
	{
		
		void ReleaseDesignerOutlets ()
		{
		}
	}
}
