using SchoolProjectClient.Client.Model.Comment;
using SchoolProjectClient.Client.Model.Common;

namespace SchoolProjectClient.Client.Services.Comments
{
	public interface ICommentService
	{
		Task<BaseResponse<CommentResponse>> GetAllCommentListAsync(int page, int size);
		Task<BaseResponse<GetByIdComment>> GetByIdCommentAsync(string id);
		Task<BaseResponse<Comment>> AddCommentAsync(AddComment addComment);
		Task<BaseResponse<Comment>> UpdateCommentAsync(UpdateComment updateComment);
		Task<BaseResponse<Comment>> DeleteCommentAsync(string id);
	}
}

