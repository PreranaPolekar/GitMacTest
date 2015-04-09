
using System;
using System.Collections.Generic;
using System.Linq;
using MonoMac.Foundation;
using MonoMac.AppKit;
using System.IO;
using System.Threading;

namespace MyUploader
{
	public partial class MainWindowController : MonoMac.AppKit.NSWindowController
	{
		List<string> imgpath = new List<string> ();
		List<string> imgpathP = new List<string> ();
		public static int cnt;
		#region Constructors

		// Called when created from unmanaged code
		public MainWindowController (IntPtr handle) : base (handle)
		{
			Initialize ();
		}
		
		// Called when created directly from a XIB file
		[Export ("initWithCoder:")]
		public MainWindowController (NSCoder coder) : base (coder)
		{
			Initialize ();
		}
		
		// Call to load from the XIB/NIB file
		public MainWindowController () : base ("MainWindow")
		{
			Initialize ();
		}
		
		// Shared initialization code
		void Initialize ()
		{
		}

		#endregion

		//strongly typed window accessor
		public new MainWindow Window {
			get {
				return (MainWindow)base.Window;
			}
		}

		public override void AwakeFromNib ()
		{
			imgpathP=GetFiles ();

    	}

		void HandleTimerCallback (object state)
		{
			
		}

		public List<string> GetFiles()
		{
			try
			{
				string[] files = Directory.GetFiles("/Users/betterlabs/Desktop/Salman SIr_Images", "*.JPG", SearchOption.AllDirectories);
			foreach (var f in files) 
			{
				imgpath.Add (f);
			}
			Console.WriteLine ("Images Count {0}", imgpath.Count);
			}
			catch(Exception ex)
			{
				Console.WriteLine (ex.ToString ());
			}
			return imgpath;


		}

		partial void Upload (NSObject sender)
		{
			int per=0;
			try
			{
				/*imgpathP=GetFiles ();

				foreach (var pp in imgpathP)
				{
					InvokeOnMainThread (() =>
					{
						filetoupload.StringValue=pp.ToString();
					
					});
				}
				*/
				Timer t = new Timer (delegate(object state) 
				{
					cnt++;
					foreach (var pp in imgpathP)
					{

						InvokeOnMainThread (() =>
							{

								filetoupload.StringValue=pp.ToString();
								uploadpercent.StringValue=cnt.ToString()+"%";


							});
					}
						InvokeOnMainThread(()=>
							{

						progressbar.IntValue=per++;
								uploadstatus.StringValue="Uploaded ("+per.ToString()+"/"+imgpathP.Count.ToString()+") files.";
							});

				});

				t.Change (0, 1000);



			}
			catch(Exception ex)
			{
				Console.WriteLine (ex.ToString ());

			}


		}

		partial void ShowLogs (NSObject sender)
		{
			FailedUploadsLogsController failed= new FailedUploadsLogsController();
			failed.ShowWindow(sender);

		}




	}
}

