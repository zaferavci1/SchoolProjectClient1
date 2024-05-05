using System;
using SchoolProjectClient.Client.Model.Common;
using SchoolProjectClient.Client.Model.PublicProfile;
using SchoolProjectClient.Client.Model.User;
using SchoolProjectClient.Client.Services;

namespace SchoolProjectClient.Client.Services.PublicProfile
{
    public class PublicProfileService : IPublicProfileService
    {
        public readonly IHttpClientService _httpClientService;

        public PublicProfileService(IHttpClientService httpClientService)
        {
            _httpClientService = httpClientService;
        }

        public async Task<BaseResponse<GetByIdPublicProfile>> GetPublicProfileByIdAsync(string id)
            => await _httpClientService.GetAsync<BaseResponse<GetByIdPublicProfile>>(new() { Controller = "PublicProfile", Action = "GetById" }, id);
    }
}

