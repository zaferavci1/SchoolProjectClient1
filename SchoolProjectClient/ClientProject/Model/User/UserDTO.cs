using System;
using SchoolProjectClient.Client.Model.User;

namespace SchoolProjectClient.Client.Model.User
{
	public class UserDTO
	{
        public string Id { get; set; }
        public string NickName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
        public string PhoneNumber { get; set; }
    }
}
public class GetAllUserExceptUsersFolloweesResponse
{
	public List<UserDTO> UserDtos { get; set; }
}

