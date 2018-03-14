﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WFStructureMap.Web.Interfaces;

namespace WFStructureMap.Web.Implementations
{
    public class EmailService : IEmailService
    {
        private readonly string connectionString;

        public EmailService(string connectionString)
        {
            // not sure why email service needs a connection to the DB
            // but for our sample, it will have to do :)
            this.connectionString = connectionString;
        }

        public bool SendEmail(string recepient, string emailBody)
        {
            // do so work here
            return true;
        }
    }
}