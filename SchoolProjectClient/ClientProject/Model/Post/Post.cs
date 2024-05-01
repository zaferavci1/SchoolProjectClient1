using System;
namespace SchoolProjectClient.Client.Model.Post
{
	public class Post
	{
        public string UserId { get; set; }
        public string Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int LikeCount { get; set; }
    }

    public class PostResponse
    {
        public List<GetAllPost> Posts { get; set; }
        public int TotalPostCount { get; set; }
    }
}

