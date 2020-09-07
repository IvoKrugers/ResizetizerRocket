using System;

namespace BoardPapers.Core.Services.Logging
{
    public interface ILoggingService
    {
        void Log(string message, string sourceFilePath = "", string memberName = "", int sourceLineNumber = 0);
        void LogEx(Exception ex, string sourceFilePath = "", string memberName = "", int sourceLineNumber = 0);
    }
}