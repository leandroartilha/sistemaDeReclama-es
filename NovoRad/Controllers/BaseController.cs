using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NovoRad.Models.Notification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovoRad.Controllers
{
    public class BaseController : Controller
    {
        public void Notify(string message, string title = "Atenção!",
            Notification notificationType = Notification.warning)
        {
            var msg = new
            {
                message,
                title,
                icon = notificationType.ToString(),
                type = notificationType.ToString(),
                provider = ""
            };

            TempData["Message"] = JsonConvert.SerializeObject(msg);
        }
    }
}
