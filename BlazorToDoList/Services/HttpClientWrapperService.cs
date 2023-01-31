using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using System.Text.Json;
using static System.Net.WebRequestMethods;

namespace BlazorToDoList.Services
{
    public class HttpClientWrapperService
    {
        public HttpClient httpClient;

        private readonly string _baseUrl = "https://localhost:7015/api/";

        public HttpClientWrapperService(HttpClient client)
        {
            httpClient = client;
        }

        public async Task<T> GetAsync<T>(string path)
        {
            var response = await httpClient.GetAsync(_baseUrl + path);
            response.EnsureSuccessStatusCode();
            var responseContent = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<T>(responseContent);
        }

        public async Task<T> PutAsync<T>(string path, HttpContent content)
        {
            var response = await httpClient.PutAsync(_baseUrl + path, content);
            response.EnsureSuccessStatusCode();
            using var responseContent = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<T>(responseContent);
        }

        public async Task<T> PostAsync<T>(string path, HttpContent content)
        {
            var response = await httpClient.PostAsync(_baseUrl + path, content);
            response.EnsureSuccessStatusCode();
            using var responseContent = response.Content.ReadAsStreamAsync().Result;
            return await JsonSerializer.DeserializeAsync<T>(responseContent);
        }

        public async Task<T> DeleteAsync<T>(string path)
        {
            var response = await httpClient.DeleteAsync(_baseUrl + path);
            response.EnsureSuccessStatusCode();
            using var responseContent = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<T>(responseContent);
        }
    }
}
