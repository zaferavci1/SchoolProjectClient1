using System;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using Blazored.LocalStorage;
using SchoolProjectClient.Client.Model.Common;
using SchoolProjectClient.Client.Model.Login;
using SchoolProjectClient.Client.Model.User;

namespace SchoolProjectClient.Client.Services
{
    public class HttpClientService : IHttpClientService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        public string? jwtToken = null;
        private readonly ILocalStorageService localStorage;
        public HttpClientService(HttpClient httpClient, IConfiguration configuration, ILocalStorageService localStorage)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            this.localStorage = localStorage;
        }

        public async Task<TResponse> DeleteAsync<TResponse>(RequestParameter requestParameter, string id)
        {
            StringBuilder urlBuilder = new StringBuilder();
            urlBuilder.Append(Url(requestParameter));
            urlBuilder.Append(!String.IsNullOrEmpty(id) ? "" + id : "");
            HttpResponseMessage httpResponseMessage = await _httpClient.DeleteAsync(urlBuilder.ToString());
            return await httpResponseMessage.Content.ReadFromJsonAsync<TResponse>();
        }

        public async Task<TResponse> GetAsync<TResponse>(RequestParameter requestParameter, string id = null)
        {
            await UpdateAuthorizationHeader();
            JsonSerializerOptions options = new();
            options.PropertyNameCaseInsensitive = true;
            StringBuilder urlBuilder = new StringBuilder();
            urlBuilder.Append(Url(requestParameter));
            urlBuilder.Append(!String.IsNullOrEmpty(id) ? id : "");
            return await _httpClient.GetFromJsonAsync<TResponse>(urlBuilder.ToString(), options);
        }

        public async Task<TResponse> PostAsync<TRequest, TResponse>(RequestParameter requestParameter, TRequest body)
        {
            await UpdateAuthorizationHeader();
            string url = Url(requestParameter);
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync<TRequest>(url, body);
            return await httpResponseMessage.Content.ReadFromJsonAsync<TResponse>();
        }

        public async Task<TResponse> PutAsync<TRequest, TResponse>(RequestParameter requestParameter, TRequest body)
        {
            await UpdateAuthorizationHeader();
            JsonSerializerOptions jsonSerializerOptions = new();
            jsonSerializerOptions.PropertyNameCaseInsensitive = true;
            string url = Url(requestParameter);
            HttpResponseMessage httpResponseMessage = await _httpClient.PutAsJsonAsync<TRequest>(url, body, jsonSerializerOptions);
            return await httpResponseMessage.Content.ReadFromJsonAsync<TResponse>();
        }

        public async Task<TResponse> LoginAsync<TRequest, TResponse>(RequestParameter requestParameter, TRequest body)
        {
            await UpdateAuthorizationHeader();
            JsonSerializerOptions jsonSerializerOptions = new();
            jsonSerializerOptions.PropertyNameCaseInsensitive = true;
            string url = Url(requestParameter);
            HttpResponseMessage httpResponseMessage = await _httpClient.PutAsJsonAsync<TRequest>(url, body, jsonSerializerOptions);
            
            return await httpResponseMessage.Content.ReadFromJsonAsync<TResponse>();
            
        }

        public async Task UpdateAuthorizationHeader()
        {
            try
            {
                string token = await localStorage.GetItemAsync<string>("Token");
                if (!string.IsNullOrWhiteSpace(token))
                {
                    _httpClient.DefaultRequestHeaders.Authorization =
                       new AuthenticationHeaderValue("Bearer", token);
                }
                else
                {
                    _httpClient.DefaultRequestHeaders.Authorization = null;
                }
            }
            catch (Exception ex)
            {
                // Log the exception or handle it
                throw new Exception("Failed to update the authorization header.", ex);
            }
        }



        private string Url(RequestParameter requestParameter)
        {
            StringBuilder urlBuilder = new StringBuilder();
            //urlBuilder.Append(!String.IsNullOrEmpty(requestParameter.BaseUrl) ? requestParameter.BaseUrl : _configuration["BaseUrl"]);
            urlBuilder.Append("https://localhost:7154/api/");
            urlBuilder.Append(requestParameter.Controller + "/");
            urlBuilder.Append(!String.IsNullOrEmpty(requestParameter.Action) ? requestParameter.Action : "");
            urlBuilder.Append((!String.IsNullOrEmpty(requestParameter.QueryString) ? "?" + requestParameter.QueryString : "/"));
            return !String.IsNullOrEmpty(requestParameter.FullEndPoint) ? requestParameter.FullEndPoint : urlBuilder.ToString();
        }
    }
}

