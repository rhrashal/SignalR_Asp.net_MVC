<%@ Page Language="C#"
    Inherits="System.Web.UI.Page" EnableSessionState="false" %>

<%@ Import Namespace="System.Diagnostics" %>
<%@ Import Namespace="System.Threading" %>
<%@ Import Namespace="Microsoft.AspNet.SignalR" %>
<%@ Import Namespace="SignalRProject1" %>
<%
    
    Response.Expires = -1;
    var connectionId = Request["connId"];
    var hub = GlobalHost.ConnectionManager
    .GetHubContext<ProgressBarHub>();
    Stopwatch stopWatch = Stopwatch.StartNew();
    // Simulate a very very hard process...
    for (int i = 1; i <= 100; i++)
    {
        hub.Clients.Client(connectionId).update(i);
        Thread.Sleep(150);
    }
%>
<p>The answer to life, the universe and everything is: 42.</p>
<p>
    And it only took <%:stopWatch.ElapsedMilliseconds / 1000 %>
seconds to find it out.
</p>
