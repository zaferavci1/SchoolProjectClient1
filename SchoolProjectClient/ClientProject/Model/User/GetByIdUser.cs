
namespace SchoolProjectClient.Client.Model.User
{
	public class GetByIdUser
	{
        public string Id { get; set; }
        public string NickName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsProfilePrivate { get; set; }
        public string Password { get; set; }
        
        public byte ProfilePictureId { get; set; }
        public List<UserDTO> Followers { get; set; }
        public List<UserDTO> Follows { get; set; }
        public List<Post.Post> Posts { get; set; }
        public List<Comment.GetAllComment> Comments { get; set; }
    }

    public class PublicProfilesDTO
    {
        public string Id { get; set; }
        public string NickName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}

