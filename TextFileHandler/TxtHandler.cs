using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.IO;

namespace TextFileHandler
{
    public class TxtHandler : IHttpHandler
    {
        public bool IsReusable
        {
            get { return false; }
        }

        public void ProcessRequest(HttpContext context)//HttpContext context
        {
            var tp = typeof(TxtHandler);
            File.WriteAllText("D:\\test.txt", context.Request.RawUrl);
            if (context.Request.RawUrl.Contains(".snp"))
            {
                context.Response.Write("Request recieved");
                context.Response.End();
            }
        }
    }
}
