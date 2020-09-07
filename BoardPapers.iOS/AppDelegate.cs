using Foundation;
using MvvmCross.Forms.Platforms.Ios.Core;
using UIKit;

namespace BoardPapers.iOS
{
    [Register(nameof(AppDelegate))]
    public partial class AppDelegate : MvxFormsApplicationDelegate<MvxFormsIosSetup<Core.App, UI.FormsApp>, Core.App, UI.FormsApp>
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            return base.FinishedLaunching(app, options);
        }
    }
}

