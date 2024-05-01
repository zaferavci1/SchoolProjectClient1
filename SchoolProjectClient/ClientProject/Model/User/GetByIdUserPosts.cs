using System;
using SchoolProjectClient.Client.Model.Post;

namespace SchoolProjectClient.Client.Model.User
{
	public class GetByIdUserPosts
	{
        public List<GetAllPost> usersPosts { get; set; }
        public int totalCount { get; set; }
    }
}

