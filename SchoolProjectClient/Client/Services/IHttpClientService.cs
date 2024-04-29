using System;
using SchoolProjectClient.Client.Model.Common;
using SchoolProjectClient.Client.Model.Login;
using SchoolProjectClient.Client.Model.User;

namespace SchoolProjectClient.Client.Services
{
	public interface IHttpClientService
	{
        Task<TResponse> GetAsync<TResponse>(RequestParameter requestParameter, string id = null);
        Task<TResponse> PostAsync<TRequest, TResponse>(RequestParameter requestParameter, TRequest body);
        Task<TResponse> PutAsync<TRequest, TResponse>(RequestParameter requestParameter, TRequest body);
        Task<TResponse> DeleteAsync<TResponse>(RequestParameter requestParameter, string id);
        Task<BaseResponse<AuthenticationResponse>> LoginUserAsync(RequestParameter requestParameter, LoginRequest loginRequest);
        void AddJwtFirstTime(string jwt);
    }
}

