using Microsoft.AspNetCore.SignalR;

namespace signalr_test
{
    public class MessageHub : Hub
    {
        public void Echo(string name, string message)
        {
            Clients.Client(Context.ConnectionId).SendAsync("echo", name, message + " (echo from server)");
        }
    }
}