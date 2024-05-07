using System;
using SchoolProjectClient.Client.Model.Comment;
using SchoolProjectClient.Client.Model.Post;
using SchoolProjectClient.Client.Model.User;

namespace SchoolProjectClient.Client.Model.PublicProfile
{
	public class GetByIdPublicProfile
	{
        public string Id { get; set; }
        public string NickName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int ProfilePictureId { get; set; }
        public List<UserDTO> Followers { get; set; }
        public List<UserDTO> Follows { get; set; }
        public List<Post.Post> Posts { get; set; }
        
        public List<Comment.GetAllComment> Comments { get; set; }
    }

}


