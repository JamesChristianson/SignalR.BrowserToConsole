using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfHostHub
{
    [HubName("myHub")]
    public class MyHub : Hub
    {
        public void DetermineLength(string message)
        {
            Console.WriteLine(message);
            string newMessage = string.Format(@"{0} has a length of: {1}", message, message.Length);
            Clients.All.ReceiveLength(newMessage);

        }

        public void Send(string name, string message)
        {
            Console.WriteLine(string.Format("{0} says: {1}", name, message));
            Clients.All.addMessage(name, message);
        }
    }
}
