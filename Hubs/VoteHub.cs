using Microsoft.AspNetCore.SignalR;
using PollingApi.Models;

namespace PollingApi.Hubs
{
    public class VoteHub : Hub
    {
        public async Task BroadcastVoteUpdate(int pollId, List<Option> options)
        {
            await Clients.All.SendAsync("ReceiveVoteUpdate", pollId, options);
        }
    }
}
