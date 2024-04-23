using System;
using SchoolProjectClient.Client.Model.Comment;
using SchoolProjectClient.Client.Model.Common;

namespace SchoolProjectClient.Client.Services.Comments
{
    public class CommentService : ICommentService
    {
        private readonly IHttpClientService _httpClientService;

        public CommentService(IHttpClientService httpClientService)
        {
            _httpClientService = httpClientService;
        }

        public Task<BaseResponse<Comment>> AddCommentAsync(AddComment addComment)
            => _httpClientService.PostAsync<AddComment, BaseResponse<Comment>>(new RequestParameter() { Controller = "Comments", Action = "Add" }, addComment);

        public Task<BaseResponse<Comment>> DeleteCommentAsync(string id)
            => _httpClientService.DeleteAsync<BaseResponse<Comment>>(new() { Controller = "Comments", Action = "Delete" }, id);

        public Task<BaseResponse<CommentResponse>> GetAllCommentListAsync(int page, int size)
            => _httpClientService.GetAsync<BaseResponse<CommentResponse>>(new() { Controller = "Comments", Action = "GetAll", QueryString = $"page={page}&size={size}" });

        public Task<BaseResponse<GetByIdComment>> GetByIdCommentAsync(string id)
            => _httpClientService.GetAsync<BaseResponse<GetByIdComment>>(new() { Controller = "Comments", Action = "GetByID" });

        public Task<BaseResponse<Comment>> UpdateCommentAsync(UpdateComment updateComment)
            => _httpClientService.PutAsync<UpdateComment, BaseResponse<Comment>>(new RequestParameter() { Controller = "Comments", Action = "Update" }, updateComment);
    }
}

