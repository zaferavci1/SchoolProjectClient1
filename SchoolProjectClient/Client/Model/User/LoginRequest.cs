using System;
namespace SchoolProjectClient.Client.Model.User
{
	public class LoginRequest
	{
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class AuthenticationResponse
    {
        public string Token { get; set; }
        public User User { get; set; }
    }
}

