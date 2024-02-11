using StocksApp.ServiceContracts;
using System.Text.Json;

namespace StocksApp.Services
{
    public class StockService : IStockService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public StockService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<Dictionary<string, object>> getStockPriceQuote(string stockSymbol)
        {
            using(HttpClient httpClient = _httpClientFactory.CreateClient())
            {
                HttpRequestMessage requestMessage = new HttpRequestMessage()
                {
                    RequestUri = new Uri("URL"),
                    Method = HttpMethod.Get,
                };
                HttpResponseMessage responseMessage = await httpClient.SendAsync(requestMessage);

                Stream stream = await responseMessage.Content.ReadAsStreamAsync();
                StreamReader streamReader = new StreamReader(stream);
                string responseBody = await streamReader.ReadToEndAsync();

                Dictionary<string,object>? dictionary = JsonSerializer.Deserialize<Dictionary<string, object>>(responseBody);

                return dictionary;
            }
        }
    }
}
