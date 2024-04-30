using System;
using System.Security.Claims;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;

namespace SchoolProjectClient.Client.Model.Utils
{
    public class AuthStateProvider : AuthenticationStateProvider
    {
        private AuthenticationState anonymus;

        public ILocalStorageService _localStorageService;

        public AuthStateProvider(ILocalStorageService localStorageService)
        {
            _localStorageService = localStorageService;
            anonymus = new AuthenticationState(new System.Security.Claims.ClaimsPrincipal(new ClaimsIdentity()));
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            string ApiToken = await _localStorageService.GetItemAsync<string>("Token");

            if (String.IsNullOrEmpty(ApiToken))
                return anonymus;

            string userId = await _localStorageService.GetItemAsync<string>("UserId");

            var mp = new ClaimsPrincipal(new ClaimsIdentity(new[] { new Claim(ClaimTypes.UserData, userId) }, "jwtAuthType"));

            return new AuthenticationState(mp);
        }

        public void NotifyUserLogin(string userId)
        {
            var cp = new ClaimsPrincipal(new ClaimsIdentity(new[] { new Claim(ClaimTypes.UserData, userId) }, "jwtAuthType"));
            var authState = Task.FromResult(new AuthenticationState(cp));

            NotifyAuthenticationStateChanged(authState);
        }

        public void NotifyUserLogout()
        {
            var authState = Task.FromResult(anonymus);
            NotifyAuthenticationStateChanged(authState);
        }
    }
}

