using System;
using SchoolProjectClient.Client.Model.Crypto;

namespace SchoolProjectClient.Client.Services.Binance
{
	public interface IBinanceService
	{
        Task<Crypto> GetPriceAsync(string symbol);
        Task<List<Crypto>> GetBinanceSymbolsAsync();
    }
}

