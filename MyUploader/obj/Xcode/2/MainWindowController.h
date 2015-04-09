// WARNING
// This file has been generated automatically by Xamarin Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <AppKit/AppKit.h>


@interface MainWindowController : NSWindowController {
	NSTextField *_filetoupload;
	NSLevelIndicator *_progressbar;
	NSTextField *_queuecnt;
	NSTextField *_uploadpercent;
	NSTextField *_uploadstatus;
}

@property (nonatomic, retain) IBOutlet NSTextField *filetoupload;

@property (nonatomic, retain) IBOutlet NSLevelIndicator *progressbar;

@property (nonatomic, retain) IBOutlet NSTextField *queuecnt;

@property (nonatomic, retain) IBOutlet NSTextField *uploadpercent;

@property (nonatomic, retain) IBOutlet NSTextField *uploadstatus;

- (IBAction)Upload:(id)sender;

- (IBAction)ShowLogs:(id)sender;

@end
