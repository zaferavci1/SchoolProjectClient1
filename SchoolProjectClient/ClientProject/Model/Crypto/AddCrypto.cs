using System;
namespace SchoolProjectClient.Client.Model.Crypto
{
	public class AddCrypto
	{
        public string UserId { get; set; }
        public string BasketId { get; set; }
        public string Symbol { get; set; }
        public float Amount { get; set; }
        public float Cost { get; set; }
    }
}

