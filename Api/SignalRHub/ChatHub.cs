using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace Api.SignalRHub
{
    [AllowAnonymous]
    public class ChatHub : Hub
    {


        public override Task OnConnectedAsync()
        {
            Console.WriteLine("Connected");
            return Task.CompletedTask;
        }


        public async Task Send(string message)
        {
            await this.Clients.All.SendAsync("Send", message);
        }
    }
}
