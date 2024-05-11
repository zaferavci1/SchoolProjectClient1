using SchoolProjectClient.Client.Model.Basket;
using SchoolProjectClient.Client.Model.Common;
using SchoolProjectClient.Client.Model.Crypto;

namespace SchoolProjectClient.Client.Services.Baskets
{
	public interface IBasketService
	{
        Task<BaseResponse<BasketResponse>> GetAllBasketListAsync(int page, int size);
        Task<BaseResponse<GetByIdBasket>> GetByIdBasketAsync(string id);
        Task<BaseResponse<Basket>> AddBasketAsync(AddBasket addBasket);
        Task<BaseResponse<Basket>> DeleteBasketAsync(string id);
        Task<BaseResponse<Basket>> UpdateBasketAsync(UpdateBasket updateBasket);
        Task<BaseResponse<Crypto>> BasketAddedCryptoAsync(AddCrypto addCrypto);
    }
}

