using System;
using System.Collections.Generic;
using System.Text;

namespace VenueEmailing.Repository.Models
{
    public class EmailMessage
    {
        public List<string> RecipientEmails { get; set; }
        public List<string> BccRecipientEmails { get; set; }
        public string SenderEmail { get; set; }
        public string Subject { get; set; }
        public string HtmlBody { get; set; }
        public string TextBody { get; set; }
    }
}
