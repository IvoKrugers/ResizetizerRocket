using MvvmCross.Forms.Platforms.Uap.Core;
using MvvmCross.Forms.Platforms.Uap.Views;
using Windows.ApplicationModel.Activation;
using Windows.ApplicationModel.Core;

namespace BoardPapers.UWP
{
    sealed partial class App : UWPApp
    {
        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();
        }

        protected override void OnLaunched(LaunchActivatedEventArgs activationArgs)
        {
            //FFImageLoading.Forms.Platform.CachedImageRenderer.Init();
            //OxyPlot.Xamarin.Forms.Platform.UWP.PlotViewRenderer.Init();

            var coreTitleBar = CoreApplication.GetCurrentView().TitleBar;
            coreTitleBar.ExtendViewIntoTitleBar = false;

            base.OnLaunched(activationArgs);
        }
    }
}