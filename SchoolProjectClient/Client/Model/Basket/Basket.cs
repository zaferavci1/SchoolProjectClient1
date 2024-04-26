namespace SchoolProjectClient.Client.Model.Basket;


public class Basket
{
    public string Id { get; set; }
    public string UserId { get; set; }
    public string BasketName { get; set; }
    public int LikeCount { get; set; }
}

public class BasketResponse
{
    public List<Basket> GetAllBasketsDTOs { get; set; }
    public int TotalUserCount { get; set; }
}

