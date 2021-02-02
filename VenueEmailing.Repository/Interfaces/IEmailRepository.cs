using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VenueEmailing.Repository.Models;

namespace VenueEmailing.Repository.Interfaces
{
    public interface IEmailRepository
    {
        Task SendEmail(EmailMessage message);
    }
}
