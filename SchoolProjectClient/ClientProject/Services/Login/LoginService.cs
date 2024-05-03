using System;
using SchoolProjectClient.Client.Model.Common;
using SchoolProjectClient.Client.Model.Login;
using SchoolProjectClient.Client.Model.User;

namespace SchoolProjectClient.Client.Services.Login
{
    public class LoginService : ILoginService
    {
        public readonly IHttpClientService _httpClientService;

        public LoginService(IHttpClientService httpClientService)
        {
            _httpClientService = httpClientService;

        }
        public async Task<BaseResponse<AuthenticationResponse>> LoginUserAsync(LoginRequest loginRequest)
            => await _httpClientService.LoginAsync<LoginRequest, BaseResponse<AuthenticationResponse>>(new RequestParameter() { Controller = "Auth", Action = "Login" }, loginRequest);

		public async Task<BaseResponse<AuthenticationResponse>> RegisterUserAsync(AddUser request)
		 => await _httpClientService.PostAsync<AddUser, BaseResponse<AuthenticationResponse>>(new RequestParameter() { Controller = "Auth", Action = "Register" }, request);


		//=> await _httpClientService.LoginUserAsync<BaseResponse<AuthenticationResponse>>(new RequestParameter() { Controller = "Auth", Action = "Login" }, loginRequest);
	}
}
