using SchoolProjectClient.Client.Model.User;

namespace SchoolProjectClient.Client.Model.Comment
{
    public class Comment
    {
        public string UserId { get; set; }
        public string PostId { get; set; }
        public string Id { get; set; }
        public int LikeCount { get; set; }
        public string Content { get; set; }
        public string UserName { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    public class CommentResponse
    {
        public List<Comment> Comments { get; set; }
        public int TotalCommentCount { get; set; }
    }
}
