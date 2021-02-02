using System.Threading.Tasks;
using VenueEmailing.Repository.Models;

namespace VenueEmailing.Logicc.Interfaces
{
    public interface INotificationsService
    {
        Task SendEmail(EmailMessage message);
    }
}
