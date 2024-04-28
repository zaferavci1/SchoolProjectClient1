using System;
using SchoolProjectClient.Client.Model.Comment;
using SchoolProjectClient.Client.Model.Common;
using SchoolProjectClient.Client.Model.Post;
using SchoolProjectClient.Client.Services;

namespace SchoolProjectClient.Client.Services.Posts
{
    public class PostService : IPostService
    {
        private readonly IHttpClientService _httpClientService;

        public PostService(IHttpClientService httpClientService)
        {
            _httpClientService = httpClientService;
        }

        public async Task<BaseResponse<Post>> AddPostAsync(AddPost addPost)
            => await _httpClientService.PostAsync<AddPost, BaseResponse<Post>>(new() { Controller = "Post", Action = "Add" }, addPost);

        public async Task<BaseResponse<Post>> DeletePostAsync(PostUpdateRequest postUpdateRequest)
            => await _httpClientService.PutAsync<PostUpdateRequest,BaseResponse<Post>>(new() { Controller = "Post", Action = "Delete" }, postUpdateRequest);

        public async Task<BaseResponse<PostResponse>> GetAllPostAsync(int page, int size)
            => await _httpClientService.GetAsync<BaseResponse<PostResponse>>(new() { Controller = "Post", Action = "GetAll", QueryString = $"page={page}&size={size}" });

        public async Task<BaseResponse<GetByIdPost>> GetByIdPostAsync(string id)
            => await _httpClientService.GetAsync<BaseResponse<GetByIdPost>>(new() { Controller = "Post", Action = "GetById" }, id);

        public async Task<BaseResponse<Post>> LikePostAsync(AddLikePost addLikePost)
            => await _httpClientService.PutAsync<AddLikePost, BaseResponse<Post>>(new RequestParameter() { Controller = "Post", Action = "Like" }, addLikePost);

        public async Task<BaseResponse<Post>> UpdatePostAsync(UpdatePost updatePost)
            => await _httpClientService.PutAsync<UpdatePost, BaseResponse<Post>>(new RequestParameter() { Controller = "Post", Action = "Update" }, updatePost);
    }
}
