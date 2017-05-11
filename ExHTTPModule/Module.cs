using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace ExHTTPModule
{
    public class Module : IHttpModule
    {
        public void Dispose()
        {

        }

        public void Init(HttpApplication context)
        {
            context.BeginRequest += context_BeginRequest;
            context.PreRequestHandlerExecute += context_PreRequestHandlerExecute;
            context.EndRequest += context_EndRequest;
            context.AuthorizeRequest += context_AuthorizeRequest;
        }

        void context_AuthorizeRequest(object sender, EventArgs e)
        {
            HttpContext context = ((HttpApplication)sender).Context;

            if (context.Request.RawUrl.Contains(".snp"))
            {
                var newUrl = context.Request.RawUrl.Replace(".snp", ".txt");

                context.RewritePath(newUrl);
            }

        }


        void context_EndRequest(object sender, EventArgs e)
        {
            //no need to do  anything here.
        }

        void context_PreRequestHandlerExecute(object sender, EventArgs e)
        {
            HttpContext context = ((HttpApplication)sender).Context;

            if(context.Items["orginalUrl"]!=null)
            {
                context.RewritePath((string)(context.Items["originalUrl"]));
            }
        }

        void context_BeginRequest(object sender, EventArgs e)
        {

            //We received a request, so we save the original URL here
            HttpContext context = ((HttpApplication)sender).Context;

            if (context.Request.RawUrl.Contains(".snp"))
            {
                context.Items["originalUrl"] = context.Request.RawUrl;
            }
        }
    }
}
