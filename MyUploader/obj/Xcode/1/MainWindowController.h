// WARNING
// This file has been generated automatically by Xamarin Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <AppKit/AppKit.h>


@interface MainWindowController : NSWindowController {
	NSTextField *_filetoupload;
	NSTextField *_queuecnt;
    NSTextField *_uploadpercent;
    NSLevelIndicator *_progressbar;
    NSTextField *_uploadstatus;
}

@property (nonatomic, retain) IBOutlet NSTextField *filetoupload;

@property (nonatomic, retain) IBOutlet NSTextField *queuecnt;

- (IBAction)Upload:(id)sender;
@property (assign) IBOutlet NSTextField *uploadpercent;
@property (assign) IBOutlet NSLevelIndicator *progressbar;
@property (assign) IBOutlet NSTextField *uploadstatus;

@end
