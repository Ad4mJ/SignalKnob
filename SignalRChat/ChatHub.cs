using System;
using System.Web;
using Microsoft.AspNet.SignalR;
namespace SignalRChat
{
    public class ChatHub : Hub
    {
        public void Change(int value)
        {
            // Call the broadcastMessage method to update clients.
            Clients.All.broadcastChange(value);
        }

        public void Release(int value)
        {
            // Call the broadcastMessage method to update clients.
            Clients.All.broadcastRelease(value);
        }
    }
}