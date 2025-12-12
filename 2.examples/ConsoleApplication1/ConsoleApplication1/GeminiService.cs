using System.Net.Http;

namespace ConsoleApplication1
{
    internal class GeminiService
    {
        private readonly string _apiKey;
        private readonly HttpClient _httpClient;

        public GeminiService(string apiKey)
        {
            _apiKey = apiKey;
            _httpClient = new HttpClient();
        }
    }
}
