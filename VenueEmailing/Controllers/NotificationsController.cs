using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VenueEmailing.Logicc.Interfaces;

namespace VenueEmailing.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NotificationsController : ControllerBase
    {
        private readonly ILogger<NotificationsController> _logger;
        private readonly INotificationsService _notificationsService;
        public NotificationsController(ILogger<NotificationsController> logger, INotificationsService notificationsService)
        {
            _logger = logger;
            _notificationsService = notificationsService;
        }

        [HttpPost]
        [Route("sendEmailNotification")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task SendEmail([FromBody] InformationRequestMessage informationRequest)
        {
            
        }
    }
}
