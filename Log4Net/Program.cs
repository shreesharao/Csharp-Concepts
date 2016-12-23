using System;
using System.Collections.Generic;
using System.Text;


[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace Log4Net
{
    /*
     * log4net understanding
     * 7 levels of logging: OFF - nothing gets logged (cannot be called),FATAL,ERROR,WARN,INFO,DEBUG,ALL - everything gets logged (cannot be called)
     */
    //
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            log.Debug("debug logged");
            log.Info("info logged");
            log.Warn("warn logged");
            log.Error("error logged");
            log.Fatal("fatal logged");
        }


    }
}
