using System;
namespace SchoolProjectClient.Client.Model.Comment
{
	public class AddComment
    {
        public string UserId { get; set; }
        public string PostId { get; set; }
        public string Content { get; set; }
    }
}

