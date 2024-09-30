using BlazorApp1FrontEndSIGA;
using BlazorApp1FrontEndSIGA.Entidades;
using BlazorApp1FrontEndSIGA.Layout;
using BlazorApp1FrontEndSIGA.Pages;
using BlazorApp1FrontEndSIGA.Service;
using BlazorApp1FrontEndSIGA.Shared;
using System.Net.Http.Json;

namespace BlazorApp1FrontEndSIGA.Service
{
    public class BackupService
    {
        private readonly HttpClient _httpClient;

        public BackupService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task BackupDataAsync(object data)
        {
            var response = await _httpClient.PostAsJsonAsync("api/backup", data);
            response.EnsureSuccessStatusCode();
        }

        public async Task<T> RestoreDataAsync<T>()
        {
            var response = await _httpClient.GetAsync("api/backup");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<T>();
        }
    }


}
