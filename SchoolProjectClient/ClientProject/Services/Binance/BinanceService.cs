using System;
using System.Net.Http;
using SchoolProjectClient.Client.Model.Crypto;


namespace SchoolProjectClient.Client.Services.Binance
{
	public class BinanceService : IBinanceService
	{
        private readonly IHttpClientService _httpClientService;

        public BinanceService(IHttpClientService httpClientService)
        {
            _httpClientService = httpClientService;
        }

        public async Task<Crypto> GetPriceAsync(string symbol)
        {
            var url = $"https://api.binance.com/api/v3/ticker/price?symbol={symbol}";
            var a = new Crypto();
            try
            {
                a = await _httpClientService.GetFromUrlAsync<Crypto>(url);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            a = await _httpClientService.GetFromUrlAsync<Crypto>(url);


            return a;
        }

        public async Task<List<Crypto>> GetBinanceSymbolsAsync()
        {
            var response = await _httpClientService.GetFromUrlAsync<List<Crypto>>("https://api.binance.com/api/v3/ticker/price");
            return response;
        }
    }
}

