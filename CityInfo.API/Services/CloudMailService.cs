﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Services
{
    public class CloudMailService : IMailService
    {
        private string _mailTo = Startup.Configuration["mailSettings:mailToAddress"];//"admin@mycompany.com";
        private string _mailFrom = Startup.Configuration["mailSettings:mailFromAddress"];//"noreply@mycompany.com";

        public void Send(string subject, string message)
        {
            Debug.WriteLine($"Mail from {_mailFrom} to {_mailTo}, with CloudService.");
            Debug.WriteLine($"Subject {subject}");
            Debug.WriteLine($"Message {message}");
        }
    }
}
