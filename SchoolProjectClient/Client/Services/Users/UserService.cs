using System;
using SchoolProjectClient.Client.Model.Common;
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
            => await _httpClientService.PostAsync<AddUser, BaseResponse<User>>(new RequestParameter() { Controller = "Users", Action = "Add" }, addUser);

        public async Task<BaseResponse<User>> DeleteUserAsync(string id)
            => await _httpClientService.DeleteAsync<BaseResponse<User>>(new() { Controller = "Users", Action = "Delete" }, id);

        public async Task<BaseResponse<UserResponse>> GetAllUserListAsync(int page, int size)
            => await _httpClientService.GetAsync<BaseResponse<UserResponse>>(new() { Controller = "Users", Action = "GetAll", QueryString = $"page={page}&size={size}" });

        public async Task<BaseResponse<GetByIdUser>> GetUserByIdAsync(string id)
            => await _httpClientService.GetAsync<BaseResponse<GetByIdUser>>(new() { Controller = "Users", Action = "GetById" }, id);

        public async Task<BaseResponse<User>> UpdateUserAsync(UpdateUser updateUser)
            => await _httpClientService.PutAsync<UpdateUser, BaseResponse<User>>(new RequestParameter() { Controller = "Users", Action = "Update" }, updateUser);
    }
}

