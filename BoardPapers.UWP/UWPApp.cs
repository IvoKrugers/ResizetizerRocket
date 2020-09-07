using MvvmCross.Forms.Platforms.Uap.Core;
using MvvmCross.Forms.Platforms.Uap.Views;

namespace BoardPapers.UWP
{
    public abstract class UWPApp : MvxWindowsApplication<MvxFormsWindowsSetup<Core.App, UI.FormsApp>, Core.App, UI.FormsApp, MainPage>
    {
    }
}