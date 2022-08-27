using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Nasarna.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Nasarna.Hubs
{
    public class NasarnaHub:Hub
    {
        private readonly UserManager<AppUser> _userManager;

        public NasarnaHub(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public override Task OnConnectedAsync()
        {
            if (Context.User.Identity.IsAuthenticated)
            {
                AppUser user = _userManager.FindByNameAsync(Context.User.Identity.Name).Result;

                user.ConnectionId = Context.ConnectionId;

                var result = _userManager.UpdateAsync(user).Result;
                Clients.All.SendAsync("showAsOnline", user.Id);
            }


            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            if (Context.User.Identity.IsAuthenticated)
            {
                AppUser user = _userManager.FindByNameAsync(Context.User.Identity.Name).Result;

                user.ConnectionId = null;
                user.ConnectedAt = DateTime.Now;

                var result = _userManager.UpdateAsync(user).Result;
                Clients.All.SendAsync("showAsOffline", user.Id);
            }

            return base.OnDisconnectedAsync(exception);
        }

        public async Task SendPrivateMessage(string id,string message)
        {
            if (Context.User.Identity.IsAuthenticated)
            {
                AppUser sender = _userManager.Users.FirstOrDefault(x => x.UserName == Context.User.Identity.Name);

                if (sender != null)
                {
                    AppUser user = _userManager.FindByIdAsync(id).Result;

                    if (user != null)
                    {
                        if (user.ConnectionId != null && sender.ConnectionId != null)
                        {
                            await Clients.Client(user.ConnectionId).SendAsync("recievePrivateMessage", sender.Id, sender.FullName, message);
                            await Clients.Client(sender.ConnectionId).SendAsync("sendPrivMessage", user.Id, user.FullName, message);
                        }
                    }
                }
               
            }
            
        }

        public async Task BlockedUser(string userId,bool isActive)
        {
            if (Context.User.Identity.IsAuthenticated)
            {
                var user = _userManager.FindByIdAsync(userId).Result;
                if(user != null)
                {
                    user.ConnectionId = null;
                    user.ConnectedAt = DateTime.Now;

                    var result = await _userManager.UpdateAsync(user);
                }
            }

        }
        /*
                public async Task SendMessage(Message message) =>
                    await Clients.All.SendAsync("recieveMessage",message);*/
    }
}
