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
        public string OwnersName { get; set; }
        public byte ProfilePictureId { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<Comment.Comment> Comments { get; set; }
    }
}

