using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SignalRChat.Notifiers;

namespace SignalRChat.Controllers
{
    public class NotifyController : Controller
    {
        [HttpPost]
        public void ReportEvent(string message)
        {
            var notifier = new ChatNotifier();
            notifier.NotifyEvent(message);
        }

        [HttpPost]
        public void WarningEvent(string message)
        {
            var notifier = new ChatNotifier();
            notifier.WarningEvent(message);
        }
    }
}