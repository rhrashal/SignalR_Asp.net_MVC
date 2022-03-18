using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRProject1
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR<TrackerConnection>("/tracker");
            app.MapSignalR<ConnectionSpy>("/spy");
            app.Use<SpyMiddleware>();
            app.MapSignalR();
        }
    }


}