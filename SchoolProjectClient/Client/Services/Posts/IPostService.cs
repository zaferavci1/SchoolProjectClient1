using System;
using SchoolProjectClient.Client.Model.Common;
using SchoolProjectClient.Client.Model.Post;

namespace SchoolProjectClient.Client.Services.Posts
{
	public interface IPostService
	{
		Task<BaseResponse<PostResponse>> GetAllPostAsync(int page, int size);
		Task<BaseResponse<GetByIdPost>> GetByIdPostAsync(string id);
		Task<BaseResponse<Post>> AddPostAsync(AddPost addPost);
		Task<BaseResponse<Post>> DeletePostAsync(PostUpdateRequest postUpdateRequest);
		Task<BaseResponse<Post>> UpdatePostAsync(UpdatePost updatePost);

	}
}

