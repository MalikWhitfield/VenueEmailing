using System.Threading.Tasks;
using VenueEmailing.Logicc.Models;
using VenueEmailing.Repository.Models;

namespace VenueEmailing.Logicc.Interfaces
{
    public interface INotificationsService
    {
        Task SendEmail(EmailMessage message);
        Task SendInformationRequestedMessage(InformationRequestMessage informationRequestMessage);
    }
}
