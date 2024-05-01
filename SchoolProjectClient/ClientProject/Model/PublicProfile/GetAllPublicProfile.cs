using System;
namespace SchoolProjectClient.Client.Model.PublicProfile
{
	public class GetAllPublicProfile
	{
        public int Id { get; set; }
        public string NickName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
        //public List<User> Followers { get; set; }
        //public List<User> Follows { get; set; }
        //public List<GetAllPostsDTO> Posts { get; set; }
        //public bool IsActive { get; set; }
    }
}

