using System;
namespace SchoolProjectClient.Client.Model.Comment
{
	public class UpdateComment
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string Content { get; set; }
        public bool IsActive { get; set; } = true;
    }
}

