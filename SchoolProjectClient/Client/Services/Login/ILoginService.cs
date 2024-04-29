using System;
using SchoolProjectClient.Client.Model.Common;
using SchoolProjectClient.Client.Model.Login;

namespace SchoolProjectClient.Client.Services.Login
{
	public interface ILoginService
	{
        Task<BaseResponse<AuthenticationResponse>> LoginUserAsync(LoginRequest request);
        void UpdateJwtToken(string jwt);
    }
}

