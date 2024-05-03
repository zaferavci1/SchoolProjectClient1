using System;
namespace SchoolProjectClient.Client.Model.User
{
    public class User
    {
        public string Id { get; set; }
        public string NickName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
        public string PhoneNumber { get; set; }
        //public string Password { get; set; }
    }

    public class UserResponse
    {
        public List<User> UsersDTOs { get; set; }
        public int TotalUserCount { get; set; }
    }
}