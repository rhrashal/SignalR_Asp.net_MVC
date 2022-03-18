using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SignalRProject1
{
    public class TrackerConnection : PersistentConnection
    {
        protected override Task OnReceived(IRequest request, string connectionId, string data)
        {
            return Connection.Broadcast(data);
        }
        //protected override Task OnConnected(IRequest request, string connectionId)
        //{
        //    // Notify all connected clients
        //    //return this.Connection.Broadcast(
        //    //"New connection: " + connectionId);
        //    return this.Connection.Send(connectionId, "Welcome, " + connectionId);
        //}
        //protected override Task OnDisconnected(IRequest request, string connectionId)
        //{
        //    // Notify all connected clients
        //    return this.Connection.Broadcast("Bye bye, " + connectionId);
        //}
    }
}