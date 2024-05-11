using SchoolProjectClient.Client.Model.Basket;
using SchoolProjectClient.Client.Model.Common;
using SchoolProjectClient.Client.Model.Crypto;

namespace SchoolProjectClient.Client.Services.Baskets
{
    public class BasketService : IBasketService
    {
        public readonly IHttpClientService _httpClientService;

        public BasketService(IHttpClientService httpClientService)
        {
            _httpClientService = httpClientService;
        }

        public async Task<BaseResponse<Basket>> AddBasketAsync(AddBasket addBasket)
            => await _httpClientService.PostAsync<AddBasket, BaseResponse<Basket>>(new RequestParameter() { Controller = "Basket", Action = "Add" }, addBasket);

        public async Task<BaseResponse<Basket>> DeleteBasketAsync(string id)
            => await _httpClientService.DeleteAsync<BaseResponse<Basket>>(new() { Controller = "Basket", Action = "Delete" }, id);

        public async Task<BaseResponse<BasketResponse>> GetAllBasketListAsync(int page, int size)
            => await _httpClientService.GetAsync<BaseResponse<BasketResponse>>(new() { Controller = "Basket", Action = "GetAll", QueryString = $"page={page}&size={size}" });

        public Task<BaseResponse<GetByIdBasket>> GetByIdBasketAsync(string id)
            => _httpClientService.GetAsync<BaseResponse<GetByIdBasket>>(new() { Controller = "Basket", Action = "GetById" }, id);

        public Task<BaseResponse<Basket>> UpdateBasketAsync(UpdateBasket updateBasket)
            => _httpClientService.PutAsync<UpdateBasket, BaseResponse<Basket>>(new RequestParameter() { Controller = "Basket", Action = "Update" }, updateBasket);

        public Task<BaseResponse<Crypto>> BasketAddedCryptoAsync(AddCrypto addCrypto)
            => _httpClientService.PostAsync<AddCrypto, BaseResponse<Crypto>>(new RequestParameter() { Controller = "Basket", Action = "AddCrypto" }, addCrypto);
    }
}

