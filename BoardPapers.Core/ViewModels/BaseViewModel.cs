using System;
using System.Threading.Tasks;
using BoardPapers.Core.Services.Logging;
using MvvmCross.ViewModels;

namespace BoardPapers.Core.ViewModels
{
    public class BaseViewModel: MvxViewModel
    {
        protected readonly ILoggingService LoggingService;

        private string _title="";
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        private bool _isBusy = false;
        public bool IsBusy
        {
            get => _isBusy;
            set => SetProperty(ref _isBusy, value);
        }

        public BaseViewModel(ILoggingService loggingService)
        {
            LoggingService = loggingService;
        }

        public override void ViewAppearing()
        {
            base.ViewAppearing();
            LoggingService.Log(this.GetType().Name);
        }

        public override void ViewAppeared()
        {
            base.ViewAppeared();
            ViewAppearedAsync();
        }

        public override void ViewDisappeared()
        {
            base.ViewDisappeared();
            LoggingService.Log(this.GetType().Name);
        }

        internal Task ViewAppearedAsync()
        {
            return Task.CompletedTask;
        }
    }
}