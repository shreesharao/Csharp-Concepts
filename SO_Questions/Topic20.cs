using System;
using System.Runtime.ExceptionServices;

namespace DotNet_store
{
    class Topic20
    {
        public void Entry()
        {
            try
            {
                ThrowExceptionSecondTime();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

            Console.Read();
        }

        private void ThrowExceptionFirstTime()
        {
            ExceptionDispatchInfo exceptionDispatchInfo = null;
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                //hold the exception and throw it at a later time
                exceptionDispatchInfo = ExceptionDispatchInfo.Capture(ex);
            }

            //Throw it after your task is done
            if (exceptionDispatchInfo != null)
            {
                exceptionDispatchInfo.Throw();
            }
        }

        private void ThrowExceptionSecondTime()
        {
            Exception exception = null;
            try
            {
                ThrowExceptionFirstTime();
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            if (exception != null)
            {
                //another way of using ExceptionDispatchInfo
                ExceptionDispatchInfo.Capture(exception).Throw();
            }
        }
    }
}
