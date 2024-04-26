using System;
namespace SchoolProjectClient.Client.Model.Post
{
	public class UpdatePost
    {
        public string UserId { get; set; }
        public string Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool IsActive { get; set; } = true;
    }
}

