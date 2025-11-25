using System.Net;
using System.Net.Http.Json;
using Subscriber.Client.Desktop.Models;
using System.Net.Http.Headers;
using System.IO;


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
            var url = $"/api/Subscribers/{subscriptionNumber}";
            var response = await _http.GetAsync(url);

            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                return null;
            }

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<SubscriberDto>();
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
        public async Task<bool> ImportXmlAsync(string filePath)
        {
            using var fs = File.OpenRead(filePath);
            using var content = new MultipartFormDataContent();

            var fileContent = new StreamContent(fs);
            fileContent.Headers.ContentType = new MediaTypeHeaderValue("application/xml");

            content.Add(fileContent, "file", Path.GetFileName(filePath));

            var response = await _http.PostAsync("/api/Subscribers/import/xml", content);
            return response.IsSuccessStatusCode;
        }

    }
}
