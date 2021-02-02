using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VenueEmailing.Repository.Interfaces;
using VenueEmailing.Repository.Models;

namespace VenueEmailing.Logicc
{
    public class NotificationsService
    {

        private readonly IEmailRepository _emailRepository;

        public NotificationsService(IEmailRepository emailRepository)
        {
            _emailRepository = emailRepository;
        }

        public async Task SendEmail(EmailMessage message)
        {
            await _emailRepository.SendEmail(message);
        }
    }
}
