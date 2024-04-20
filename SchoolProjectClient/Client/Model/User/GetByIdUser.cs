using System;
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
        //public List<PublicProfilesDTO> Followers { get; set; }
        //public List<PublicProfilesDTO> Follows { get; set; }
        //public List<GetAllPostsDTO> Posts { get; set; }
        //public List<GetAllCommentsDTO> Comments { get; set; }
    }
}

