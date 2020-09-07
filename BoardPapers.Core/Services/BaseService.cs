using BoardPapers.Core.Services.Logging;
using MvvmCross;

namespace BoardPapers.Core.Services
{
    public class BaseService
    {
        protected readonly ILoggingService LoggingService;

        public BaseService(ILoggingService loggingService)
        {
            LoggingService = loggingService;
        }
    }
}