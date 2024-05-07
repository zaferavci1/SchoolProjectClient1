using System;
using SchoolProjectClient.Client.Model.Common;
using SchoolProjectClient.Client.Model.PublicProfile;
using SchoolProjectClient.Client.Model.User;

namespace SchoolProjectClient.Client.Services.PublicProfile
{
	public interface IPublicProfileService
	{

        Task<BaseResponse<GetByIdPublicProfile>> GetPublicProfileByIdAsync(string id);
        Task<BaseResponse<GetByIdPublicProfile>> GetPublicProfileByNickNameAsync(GetUserByNickNameQueryRequest request);
    }
}

