using CleanArchitecture.Application.DTOs.Email;

namespace CleanArchitecture.Application.Interfaces
{
    public interface IEmailService
    {
        Task SendAsync(EmailRequestDto request);
    }
}
