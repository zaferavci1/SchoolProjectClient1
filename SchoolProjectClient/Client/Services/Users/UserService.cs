using System;
using System.Net.Http;
using SchoolProjectClient.Client.Model.Common;
using SchoolProjectClient.Client.Model.Login;
using SchoolProjectClient.Client.Model.User;

namespace SchoolProjectClient.Client.Services.Users
{
    public class UserService : IUserService
    {

        public readonly IHttpClientService _httpClientService;

        public UserService(IHttpClientService httpClientService)
        {
            _httpClientService = httpClientService;
        }

        public async Task<BaseResponse<User>> AddUserAsync(AddUser addUser)
            => await _httpClientService.PostAsync<AddUser, BaseResponse<User>>(new RequestParameter() { Controller = "User", Action = "Add" }, addUser);

        public async Task<BaseResponse<User>> DeleteUserAsync(string id)
            => await _httpClientService.DeleteAsync<BaseResponse<User>>(new() { Controller = "User", Action = "Delete" }, id);

        public async Task<BaseResponse<UserResponse>> GetAllUserListAsync(int page, int size)
            => await _httpClientService.GetAsync<BaseResponse<UserResponse>>(new() { Controller = "User", Action = "GetAll", QueryString = $"page={page}&size={size}" });

        public async Task<BaseResponse<GetByIdUser>> GetUserByIdAsync(string id)
            => await _httpClientService.GetAsync<BaseResponse<GetByIdUser>>(new() { Controller = "User", Action = "GetById" }, id);

        public async Task<BaseResponse<AuthenticationResponse>> LoginUserAsync(LoginRequest request)
        {
            //var response = await _httpClientService.("/api/auth/login", request);

            //if (response.IsSuccessStatusCode)
            //{
            //    return await response.Content.ReadFromJsonAsync<BaseResponse<AuthenticationResponse>>();
            //}
            //else
            //{
            //    // Hata durumunda BaseResponse döndürün (hata mesajı, kodları vb. içerebilir)
            //    return new BaseResponse<AuthenticationResponse>() { IsSucceeded = false };
            //}
            throw new NotImplementedException();
        }

        public async Task<BaseResponse<User>> UpdateUserAsync(UpdateUser updateUser)
            => await _httpClientService.PutAsync<UpdateUser, BaseResponse<User>>(new RequestParameter() { Controller = "User", Action = "Update" }, updateUser);
    }
}

