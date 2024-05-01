using System;
using SchoolProjectClient.Client.Model.User;

namespace SchoolProjectClient.Client.Model.Basket
{
	public class UpdateBasket
	{
        public string Id { get; set; }
        public string UserId { get; set; }
        public string BasketName { get; set; }
    }
}