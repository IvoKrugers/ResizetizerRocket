using BoardPapers.Core.Services.Logging;
using MvvmCross.ViewModels;

namespace BoardPapers.Core.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public LoginViewModel(ILoggingService loggingService): base(loggingService)
        {
            Title = "Login!";
        }
    }
}