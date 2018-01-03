using System.Threading.Tasks;

namespace SciBoard.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
