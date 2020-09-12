using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace WebApplication2.Hubs
{
    public class Chathub : Hub
    {
        public async Task sendmessage(string fromuser, string message)
        {
            await Clients.All.SendAsync("recievemessage", fromuser, message);

        }
       
    }
}
