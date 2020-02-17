using log4net;
using System;

namespace EnterpriseFramework.Core.CrossCuttingConcerns.Logging.Log4Net
{
    [Serializable]
    public class LoggerService
    {
        private ILog _log;

        public LoggerService(ILog log)
        {
            _log = log;
        }

        public bool IsDebugEnabled => _log.IsDebugEnabled;
        public bool IsInfoEnabled => _log.IsInfoEnabled;
        public bool IsWarnEnabled => _log.IsWarnEnabled;
        public bool IsFatalEnabled => _log.IsFatalEnabled;
        public bool IsErrorEnabled => _log.IsErrorEnabled;


        public void Debug(Object logMessage)
        {
            if (IsDebugEnabled)
            {
                _log.Debug(logMessage);
            }
        }
        public void Info(Object logMessage)
        {
            if (IsInfoEnabled)
            {
                _log.Info(logMessage);
            }
        }

        public void Warn(Object logMessage)
        {
            if (IsWarnEnabled)
            {
                _log.Warn(logMessage);
            }
        }

        public void Fatal(Object logMessage)
        {
            if (IsFatalEnabled)
            {
                _log.Fatal(logMessage);
            }
        }

        public void Error(Object logMessage)
        {
            if (IsErrorEnabled)
            {
                _log.Error(logMessage);
            }
        }

    } 
}
