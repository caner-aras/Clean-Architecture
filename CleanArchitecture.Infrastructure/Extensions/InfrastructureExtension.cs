using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Domain.Common;
using CleanArchitecture.Domain.Common.Interfaces;
using CleanArchitecture.Infrastructure.Services;

using MediatR;

using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Infrastructure.Extensions
{
    public static class InfrastructureExtension
    {
        public static void AddInfrastructureLayer(this IServiceCollection services)
        {
            services.AddServices();
        }

        private static void AddServices(this IServiceCollection services)
        {
            services
                .AddTransient<IMediator, Mediator>()
                .AddTransient<IDomainEventDispatcher, DomainEventDispatcher>()
                .AddTransient<IDateTimeService, DateTimeService>()
                .AddTransient<IEmailService, EmailService>();
        }
    }
}
