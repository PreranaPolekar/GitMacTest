
using System;
using System.Collections.Generic;
using System.Linq;
using MonoMac.Foundation;
using MonoMac.AppKit;

namespace MyUploader
{
	public partial class FailedUploadsLogsController : MonoMac.AppKit.NSWindowController
	{
		#region Constructors

		// Called when created from unmanaged code
		public FailedUploadsLogsController (IntPtr handle) : base (handle)
		{
			Initialize ();
		}
		
		// Called when created directly from a XIB file
		[Export ("initWithCoder:")]
		public FailedUploadsLogsController (NSCoder coder) : base (coder)
		{
			Initialize ();
		}
		
		// Call to load from the XIB/NIB file
		public FailedUploadsLogsController () : base ("FailedUploadsLogs")
		{
			Initialize ();
		}
		
		// Shared initialization code
		void Initialize ()
		{
		}

		#endregion

		//strongly typed window accessor
		public new FailedUploadsLogs Window {
			get {
				return (FailedUploadsLogs)base.Window;
			}
		}

		public override void AwakeFromNib ()
		{
			tableview.DataSource = new TableDataSource ();
		
		}
	}
}

