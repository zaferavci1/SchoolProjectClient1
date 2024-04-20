using System;
namespace SchoolProjectClient.Client.Model.Comment
{
	public class GetByIdComment
	{
        public string UserId { get; set; }
        public string PostId { get; set; }
        public string Id { get; set; }
        public int LikeCount { get; set; }
        public string Content { get; set; }
        //public List<CommentDTO> ReplyComments { get; set; }
    }
}

