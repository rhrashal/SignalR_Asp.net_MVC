using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRProject1
{
    [HubName("CustomHubNewName")]

    public class CustomHubName : Hub

    {        
        /// Method to broadcast message to all connected clients. It uses HubMethodName attribte to avoid camel
        [HubMethodName("CustomSendMethod")]

        public void Send(string name, string message)
        {
            Clients.All.broadcastMessage(name, message);
        }

    }

}