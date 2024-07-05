using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace CleanArchitecture.Infrastructure.Extensions
{
    public static class IdentitiyExtension
    {
        public static IServiceCollection AddCustomJwtAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            var keycloakConfig = configuration.GetSection("Keycloak");
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.Authority = keycloakConfig["Authority"];
                    options.Audience = keycloakConfig["Audience"];
                    options.RequireHttpsMetadata = false; // Geliştirme ortamı için HTTPS gereksinimini devre dışı bırak
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true
                    };
                });

            return services;
        }
    }
}