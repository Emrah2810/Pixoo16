using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace Pixoo16Lib.Client
{
public class PixooHttpClient
{
    private readonly HttpClient _httpClient;

    public PixooHttpClient(string baseUrl)
    {
        _httpClient = new HttpClient { BaseAddress = new Uri(baseUrl) };
    }

    public async Task<T> GetAsync<T>(string endpoint)
    {
        var response = await _httpClient.GetAsync(endpoint);
        response.EnsureSuccessStatusCode();
        var json = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<T>(json);
    }

    public async Task PostAsync<T>(string endpoint, T content)
    {
        var json = JsonSerializer.Serialize(content);
        var stringContent = new StringContent(json, Encoding.UTF8, "application/json");
        var response = await _httpClient.PostAsync(endpoint, stringContent);
        response.EnsureSuccessStatusCode();
    }
}
}
