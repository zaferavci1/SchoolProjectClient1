using System;
namespace SchoolProjectClient.Client.Model.Post
{
	public class GetByIdPost
	{
        public string UserId { get; set; }
        public string Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int likeCount { get; set; }
       // public List<CommentDTO> Comments { get; set; }
    }
}

