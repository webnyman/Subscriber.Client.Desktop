using System.Net.Http.Json;
using Subscriber.Client.Desktop.Models;

namespace Subscriber.Client.Desktop.Services
{
    public class SubscriberApiClient
    {
        private readonly HttpClient _http;

        public SubscriberApiClient(string baseUrl)
        {
            _http = new HttpClient
            {
                BaseAddress = new Uri(baseUrl)
            };
        }

        public async Task<List<SubscriberDto>> GetAllAsync()
        {
            var result = await _http.GetFromJsonAsync<List<SubscriberDto>>("/api/Subscribers");
            return result ?? new List<SubscriberDto>();
        }

        public async Task<SubscriberDto?> GetAsync(string subscriptionNumber)
        {
            return await _http.GetFromJsonAsync<SubscriberDto>($"/api/Subscribers/{subscriptionNumber}");
        }

        public async Task<bool> CreateAsync(SubscriberDto dto)
        {
            var response = await _http.PostAsJsonAsync("/api/Subscribers", dto);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateAsync(string subscriptionNumber, SubscriberDto dto)
        {
            var response = await _http.PutAsJsonAsync($"/api/Subscribers/{subscriptionNumber}", dto);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteAsync(string subscriptionNumber)
        {
            var response = await _http.DeleteAsync($"/api/Subscribers/{subscriptionNumber}");
            return response.IsSuccessStatusCode;
        }

        public async Task<byte[]?> ExportXmlAsync()
        {
            var response = await _http.GetAsync("/api/Subscribers/export/xml");
            if (!response.IsSuccessStatusCode)
                return null;

            return await response.Content.ReadAsByteArrayAsync();
        }
    }
}
