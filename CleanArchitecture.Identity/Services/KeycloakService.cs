using CleanArchitecture.Identity.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace CleanArchitecture.Identity.Services
{
    public class KeycloakService
    {
        private readonly HttpClient _httpClient;
        private readonly string _tokenEndpoint;
        private readonly string _clientId;
        private readonly string _clientSecret;

        public KeycloakService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            var keycloakConfig = configuration.GetSection("Keycloak");
            _tokenEndpoint = $"{keycloakConfig["Authority"]}/protocol/openid-connect/token";
            _clientId = keycloakConfig["ClientId"];
            _clientSecret = keycloakConfig["ClientSecret"];
        }

        public async Task<TokenResponse> GetTokenAsync(TokenRequest request)
        {
            var parameters = new Dictionary<string, string>
            {
                { "grant_type", "password" },
                { "client_id", _clientId },
                { "client_secret", _clientSecret },
                { "username", request.Username },
                { "password", request.Password }
            };

            var content = new FormUrlEncodedContent(parameters);
            var response = await _httpClient.PostAsync(_tokenEndpoint, content);

            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<TokenResponse>(responseContent, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
    }
}
