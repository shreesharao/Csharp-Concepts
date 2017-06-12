using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;


[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace Log4Net
{
    /*
     * log4net understanding
     * 7 levels of logging: OFF - nothing gets logged (cannot be called),FATAL,ERROR,WARN,INFO,DEBUG,ALL - everything gets logged (cannot be called)
     *log4net works without config file also.it uses default configuration.
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
            Entry();
            Console.Read();
        }

        public static void Entry()
        {
            log.Debug("debug logged");
            log.Info("info logged");
            log.Warn("warn logged");
            log.Error("error logged");
            log.Fatal("fatal logged");
          
        }

        //this method can not be used from outside because log4net is an exe not dll.

        //public void Write(string message,string level="Debug")
        //{
        //    switch (level)
        //    {
        //        case "Debug":
        //            log.Debug(message);
        //            break;
        //        case "Info":
        //            log.Info(message);
        //            break;
        //        case "Warn":
        //            log.Warn(message);
        //            break;
        //        case "Error":
        //            log.Error(message);
        //            break;
        //        case "Fatal":
        //            log.Fatal(message);
        //            break;
        //        default:
        //            log.Debug(message);
        //            break;
        //    }

        //}


    }
}
