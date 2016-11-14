using System;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace GameDevAQ
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            //broadcastMessage update client
            Clients.All.broadcastMessage(name, message);
        }
    }
}