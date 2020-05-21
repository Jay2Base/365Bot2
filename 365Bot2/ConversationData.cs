using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _365Bot2
{
    public class ConversationData
{
        public string Timestamp { get; set; }

        public string ChannelId { get; set; }

        public bool PromptedUserForName { get; set; } = false;
}
}
