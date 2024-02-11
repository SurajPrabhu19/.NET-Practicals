namespace StocksApp.ServiceContracts
{
    public interface IStockService
    {
        public async Task<Dictionary<string, object>> getStockPriceQuote(string stockSymbol);
    }
}
