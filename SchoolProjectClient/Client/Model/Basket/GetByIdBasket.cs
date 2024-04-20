using System;
namespace SchoolProjectClient.Client.Model.Basket
{
	public class GetByIdBasket
	{
        public string Id { get; set; }
        public string BasketName { get; set; }
        public int LikeCount { get; set; }
        //public List<Crypto> Cryptos { get; set; }
    }
}

