using System;
using SchoolProjectClient.Client.Model.Common;
using SchoolProjectClient.Client.Model.Login;
using SchoolProjectClient.Client.Model.User;

namespace SchoolProjectClient.Client.Services.Login
{
	public interface ILoginService
	{
        AppUserId User { get; }
        Task<BaseResponse<AuthenticationResponse>> LoginUserAsync(LoginRequest request);
        Task Logout();
    }
}

