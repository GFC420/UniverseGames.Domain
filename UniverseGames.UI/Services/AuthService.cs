using System.Text;
using System.Text.Json;
using UniverseGames.UI.Models;

namespace UniverseGames.UI.Services
{
    public class AuthService
    {
        private readonly HttpClient _httpClient;

        public AuthService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:5001/api/");
        }

        public async Task<bool> LoginAsync(LoginModel login)
        {
            var json = JsonSerializer.Serialize(login);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("auth/login", content);

            if (!response.IsSuccessStatusCode)
                return false;

            var result = await response.Content.ReadAsStringAsync();

            var obj = JsonSerializer.Deserialize<dynamic>(result);

            ApiService.Token = obj.token;

            return true;
        }
    }
}