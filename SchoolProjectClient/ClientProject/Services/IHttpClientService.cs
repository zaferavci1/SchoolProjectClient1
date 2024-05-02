using System;
using System.Net.Http.Headers;
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
        Task<TResponse> LoginAsync<TRequest, TResponse>(RequestParameter requestParameter, TRequest body);
        Task UpdateAuthorizationHeader();
    }
}

