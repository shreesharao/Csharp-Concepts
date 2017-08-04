using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NLogHelper
{
    class LoggerSpecificRouting
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public void Entry()
        {
            LogToFile();
        }

        public void LogToFile()
        {
            logger.Trace("Trace message from LoggerSpceficRouting");
        }
    }
}
