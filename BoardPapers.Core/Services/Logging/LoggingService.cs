using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using MvvmCross.Logging;

namespace BoardPapers.Core.Services.Logging
{
    public class LoggingService: ILoggingService
    {
        private readonly IMvxLog _log;
        public LoggingService(IMvxLogProvider logProvider)
        {
            _log = logProvider.GetLogFor("");
        }

        public void Log(string message, [CallerFilePath] string sourceFilePath = "", [CallerMemberName] string memberName = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            var moduleStr = Path.GetFileNameWithoutExtension(sourceFilePath);
            moduleStr = $"[{moduleStr}.{memberName}]";
            //moduleStr = moduleStr.PadRight(45);

            var msg = $"{moduleStr} {message}";
            WriteToLog(msg);
        }

        public void LogEx(Exception ex, [CallerFilePath] string sourceFilePath = "", [CallerMemberName] string memberName = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            var moduleStr = Path.GetFileNameWithoutExtension(sourceFilePath);
            moduleStr = $"[{moduleStr}.{memberName}]";
            //moduleStr = moduleStr.PadRight(45);

            //if (ex.StackTrace.Contains("in ") && ex.StackTrace.Contains(".cs"))
            //{
            //    var where = e.StackTrace.Split('/', '\\');
            //    if (where.Count() > 0)
            //    {
            //        lineAndNumber = where.Last();
            //    }
            //}

            //Crashes.TrackError(e);

            //Analytics.TrackEvent($"[Exception] {className}.{functionName}()", new Dictionary<string, string>()
            //{
            //    { "type" , e.GetType().Name },
            //    { "message" , e.Message },
            //    { "where", lineAndNumber }
            //});
            var innerEx = ex;
            while(innerEx.InnerException !=null)
            {
                innerEx = innerEx.InnerException;
            }

            var msg = $"{moduleStr} [{ex.GetType().Name}] {ex.Message} InnerException: {innerEx.Message}\n{ex.StackTrace}";
            WriteToLog(msg);
        }


        private void WriteToLog(string message)
        {
            var msg = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}) {message}";
            Debug.WriteLine(msg);
            _log.Log(MvxLogLevel.Trace, ()=>message);
        }

    }
}