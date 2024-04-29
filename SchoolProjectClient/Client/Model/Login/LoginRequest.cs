using System;
namespace SchoolProjectClient.Client.Model.Login
{
	public class LoginRequest
	{
        public string UserNameOrMail { get; set; }
        public string Password { get; set; }
    }
    public class AuthenticationResponse
    {
        public Token TokenDTO { get; set; }
        public AuthUser UserDTO { get; set; }
    }
}


public class Token 
{
    public string AccessToken { get; set; }
    public DateTime Expiration { get; set; }
    public string RefreshToken { get; set; }
}

public class AuthUser
{
    public string Id { get; set; }
    public string NickName { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Mail { get; set; }
    public string PhoneNumber { get; set; }
}
