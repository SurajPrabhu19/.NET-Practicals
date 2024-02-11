namespace StocksApp.Services
{
    public class StockService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public StockService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task Method()
        {
            using(HttpClient httpClient = _httpClientFactory.CreateClient())
            {
                HttpRequestMessage requestMessage = new HttpRequestMessage()
                {
                    RequestUri = new Uri("URL"),
                    Method = HttpMethod.Get,
                };
                HttpResponseMessage responseMessage = await httpClient.SendAsync(requestMessage);
            }
        }
    }
}
