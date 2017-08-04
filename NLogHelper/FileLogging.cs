using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NLogHelper
{
    class FileLogging
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        //private static Logger logger = LogManager.GetLogger("FileLoging");

        public void Entry()
        {
            LogToFile();
        }

        public void LogToFile()
        {
            logger.Debug("Debug Message from FileLogging");
            //logger.Log(LogLevel.Debug, "Message from FileLogging"); //we can specify log level
        }
    }
}
