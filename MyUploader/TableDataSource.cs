using System;
using MonoMac.AppKit;
using MonoMac.Foundation;

namespace MyUploader
{
	public class TableDataSource:NSTableViewDataSource
	{
		public TableDataSource ()
		{
		}

		// This method will be called by the NSTableView control to learn the number of rows to display.
		[Export ("numberOfRowsInTableView:")]
		public int NumberOfRowsInTableView(NSTableView table)
		{
			Console.WriteLine("numberOfRowsInTableView:");
			// We just return a static 2. We will have two rows.
			return 4;
		}


		// This method will be called by the control for each column and each row.
		[Export ("tableView:objectValueForTableColumn:row:")]
		public NSObject ObjectValueForTableColumn(NSTableView table, NSTableColumn col, int row)
		{
			Console.WriteLine("tableView:objectValueForTableColumn:row:");
			switch (row)
			{
			case 0:
				// We will write "Hello" in the first row...
				//table.ColumnForView (new CustomControlViewController ().View);
				//table.AddSubview (new CustomControlViewController ().View);	
				//return 0;	

				return new NSString("Hello");
			case 1:
				// ...and "World" in the second.
				return new NSString("World");
				// Note that NSTableView requires an NSString, which we create with new NSString("bla").
				//table.AddSubview (new CustomControlViewController ().View);	
				//table.ColumnForView (new CustomControlViewController ().View);
			case 2:
				return new NSString ("Prerana");
				//table.AddSubview (new CustomControlViewController ().View);	
				//table.ColumnForView (new CustomControlViewController ().View);
			case 3:
				return new NSString ("Polekar");
				//table.AddSubview (new CustomControlViewController ().View);	
				//table.ColumnForView (new CustomControlViewController ().View);
			default:
				// We need a default value.
				return null;
			}
		}


		public override void SetObjectValue (NSTableView tableView, NSObject theObject, NSTableColumn tableColumn, int row)
		{

		}


	}
}

