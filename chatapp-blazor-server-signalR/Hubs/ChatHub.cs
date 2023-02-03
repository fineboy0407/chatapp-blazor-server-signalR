using Microsoft.AspNetCore.SignalR;

namespace chatapp_blazor_server_signalR.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage",user, message);
        }
    }
}
