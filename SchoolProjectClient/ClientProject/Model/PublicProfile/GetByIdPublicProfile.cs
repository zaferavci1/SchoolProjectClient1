using System;
namespace SchoolProjectClient.Client.Model.PublicProfile
{
	public class GetByIdPublicProfile
	{
        public string Id { get; set; }
        public string NickName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        //public List<PublicProfilesDTO> Followers { get; set; }
        //public List<PublicProfilesDTO> Follows { get; set; }
        //public List<GetAllPostsDTO> Posts { get; set; }
        //public List<GetAllCommentsDTO> Comments { get; set; }
    }
}

