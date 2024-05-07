using System;
using System.Net.Http;
using SchoolProjectClient.Client.Model.Common;
using SchoolProjectClient.Client.Model.Login;
using SchoolProjectClient.Client.Model.Post;
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
            => await _httpClientService.PostAsync<AddUser, BaseResponse<User>>(new RequestParameter() { Controller = "Auth", Action = "Register" }, addUser);

        public async Task<BaseResponse<User>> DeleteUserAsync(string id)
            => await _httpClientService.DeleteAsync<BaseResponse<User>>(new() { Controller = "User", Action = "Delete" }, id);

        public async Task<BaseResponse<UserDTO>> FollowUserAsync(FollowUser followUser)
            => await _httpClientService.PutAsync<FollowUser, BaseResponse<UserDTO>>(new RequestParameter() { Controller = "User", Action = "Follow" }, followUser);

        public async Task<BaseResponse<GetAllUserExceptUsersFolloweesResponse>> GetAllUsersExceptUsersFollowees(GetAllUserExceptUsersFollowees exceptUsersFollowees)
            => await _httpClientService.PutAsync<GetAllUserExceptUsersFollowees, BaseResponse<GetAllUserExceptUsersFolloweesResponse>>(new RequestParameter() { Controller = "User", Action = "GetAllUserExceptUsersFollowees" }, exceptUsersFollowees);

        public async Task<BaseResponse<UserResponse>> GetAllUserListAsync(int page, int size)
            => await _httpClientService.GetAsync<BaseResponse<UserResponse>>(new() { Controller = "User", Action = "GetAll", QueryString = $"page={page}&size={size}" });

        public async Task<BaseResponse<GetByIdUserPosts>> GetByIdUserPost(string id)
            => await _httpClientService.GetAsync<BaseResponse<GetByIdUserPosts>>(new() { Controller = "User", Action = "GetByIdUsersPosts" }, id);

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

        public async Task<BaseResponse<UserDTO>> UnFollowUserAsync(FollowUser unFollowUser)
            => await _httpClientService.PutAsync<FollowUser, BaseResponse<UserDTO>>(new RequestParameter() { Controller = "User", Action = "UnFollow" }, unFollowUser);

        public async Task<BaseResponse<User>> UpdateUserAsync(UpdateUser updateUser)
            => await _httpClientService.PutAsync<UpdateUser, BaseResponse<User>>(new RequestParameter() { Controller = "User", Action = "Update" }, updateUser);
        
    }
}

