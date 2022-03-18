using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalRProject1
{
    public class Global : HttpApplication
    {
        private static IPersistentConnectionContext connSpy =
        GlobalHost.ConnectionManager.GetConnectionContext<ConnectionSpy>();
        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            var context = ((HttpApplication)sender).Context;
            var message = string.Format(
            "{0}: Requested '{1}' from IP {2} using {3}",
            DateTime.Now.ToShortTimeString(),
            context.Request.Url.ToString(),
            context.Request.UserHostAddress,
            context.Request.Browser.Type
            );
            connSpy.Connection.Broadcast(message);
        }
    }
}