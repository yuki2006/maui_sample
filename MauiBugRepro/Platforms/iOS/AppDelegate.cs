using System;
using Foundation;
using UIKit;

namespace MauiBugRepro;

[Register("AppDelegate")]
public class AppDelegate : UIResponder, IUIApplicationDelegate
{
    [Export("window")]
    public UIWindow? Window { get; set; }

    [Export("application:didFinishLaunchingWithOptions:")]
    public bool FinishedLaunching(UIApplication application, NSDictionary? launchOptions)
    {
        if (OperatingSystem.IsIOSVersionAtLeast(13, 0))
        {
            var request = new BackgroundTasks.BGAppRefreshTaskRequest("com.companyname.mauibugrepro.refreshtask");
        }
        return true;
    }
}