using System;
using SchoolProjectClient.Client.Model.Comment;

namespace SchoolProjectClient.Client.Model.Post
{
	public class GetAllPost
	{
        public string UserId { get; set; }
        public string Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int LikeCount { get; set; }
        public List<Comment.Comment> Comments { get; set; }
        public User.UserDTO PostOfUser { get; set; }
    }
}


