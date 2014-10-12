
using Microsoft.AspNet.SignalR;
using SignalRChat.Hubs;

namespace SignalRChat.Notifiers
{
    public class ChatNotifier
    {
        private Microsoft.AspNet.SignalR.Hubs.IHubConnectionContext<dynamic> _clientNotifier;
        public ChatNotifier()
        {
            _clientNotifier = GlobalHost.ConnectionManager.GetHubContext<ChatHub>().Clients;
        }
        
        public void NotifyEvent(string message)
        {
            _clientNotifier.All.addMessage("Admin", message);
        }

        public void WarningEvent(string message)
        {
            _clientNotifier.All.warningMessage(message);
        }
    }
}